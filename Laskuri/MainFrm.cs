using System.Collections.Generic;
using System.Threading.Tasks;
using Sulakore.Communication;
using System.Windows.Forms;
using System.Threading;
using Sulakore.Modules;
using Sulakore.Habbo;
using System.Drawing;
using Tangine;
using System;

namespace Laskuri
{
    [Module("Laskuri", "A calculator for Habbo races!")]
    public partial class MainFrm : ExtensionForm
    {
        private int Laps;
        private int Stops;
        private bool isRaceRunning;
        private bool selectingLapTiles;
        private bool selectingStopTiles;
        private Point downPoint = Point.Empty;
        private List<Player_Item> playerControls;
        private List<Point> LapTiles = new List<Point>();
        private List<Point> StopTiles = new List<Point>();
        private List<int> RecentLapScore = new List<int>();
        private List<RoomUser> users = new List<RoomUser>();
        private List<int> RecentStopScore = new List<int>();
        private List<string> ShoutQueue = new List<string>();
        private List<int> freezeEffectIds = new List<int>() { 40, 41, 42, 43 };

        #region UI_Events
        private void PN_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PN_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Move_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        private void PN_Close_MouseLeave(object sender, EventArgs e)
        {
            PN_Close.BackColor = Color.FromArgb(40, 43, 48);
        }

        private void PN_Close_MouseEnter(object sender, EventArgs e)
        {
            PN_Close.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            var location = new Point(
                Left + e.X - downPoint.X,
                Top + e.Y - downPoint.Y);
            Location = location;
        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            foreach (var control in playerControls)
                if (TB_Search.Text.Length > 0 && control.Username.ToLower().Contains(TB_Search.Text.ToLower()))
                {
                    control.PN_Parent.BackColor = Color.FromArgb(215, 215, 215);
                    control.LB_Username.ForeColor = Color.Black;
                }
                else
                {
                    control.PN_Parent.BackColor = Color.FromArgb(54, 57, 62);
                    control.LB_Username.ForeColor = Color.White;
                }
        }

        private void PN_Minimize_MouseLeave(object sender, EventArgs e)
        {
            PN_Minimize.BackColor = Color.FromArgb(40, 43, 48);
        }

        private void PN_Minimize_MouseEnter(object sender, EventArgs e)
        {
            PN_Minimize.BackColor = Color.FromArgb(50, 53, 58);
        }

        private void CB_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = CB_TopMost.Checked;
        }
        #endregion

        public MainFrm()
        {
            InitializeComponent();

            Shout();
            playerControls = new List<Player_Item>() { PL_1, PL_2, PL_3, PL_4, PL_5, PL_6, PL_7, PL_8, PL_9, PL_10, PL_11, PL_12, PL_13, PL_14, PL_15, PL_16, PL_17, PL_18, PL_19, PL_20 };
        }
        
        private void Shout()
        {
            Task.Factory.StartNew(() =>
            {
                loop:
                if (ShoutQueue.Count > 0 && CB_Shout.Checked)
                {
                    Connection.SendToServerAsync(Out.RoomUserShout, ShoutQueue[0], 0);
                    ShoutQueue.RemoveAt(0);
                }
                Thread.Sleep(2000);
                goto loop;
            });
        }

        private void ClearLastest()
        {
            LB_Scoreboard_1.Text = "";
            LB_Scoreboard_2.Text = "";
            LB_Scoreboard_3.Text = "";
        }

        private void LastestAdd(string str)
        {
            LB_Scoreboard_3.Text = LB_Scoreboard_2.Text;
            LB_Scoreboard_2.Text = LB_Scoreboard_1.Text;
            LB_Scoreboard_1.Text = str;
        }

        [InDataCapture("84c6b9e56653d64d21cd8cf47c4242f1")]
        private void RoomUsers(DataInterceptedEventArgs e)
        {
            var _users = HEntity.Parse(e.Packet);
            foreach (var user in _users) users.Add(new RoomUser(user.Name, user.Index));
        }

        [OutDataCapture("f76a21e6be54cea897c44fbfc7c32839")]
        private void RoomUserWalk(DataInterceptedEventArgs e)
        {
            if (!selectingLapTiles && !selectingStopTiles) return;

            if (selectingLapTiles)
            {
                LapTiles.Add(new Point(e.Packet.ReadInteger(), e.Packet.ReadInteger()));
                if (LapTiles.Count == 3)
                {
                    selectingLapTiles = false;
                    Connection.SendToClientAsync(In.RoomUserWhisper, -1, "Lap tiles position set.", 0, 34, 0, -1);
                }
            }
            else if (selectingStopTiles)
            {
                StopTiles.Add(new Point(e.Packet.ReadInteger(), e.Packet.ReadInteger()));
                if (StopTiles.Count == 3)
                {
                    selectingStopTiles = false;
                    Connection.SendToClientAsync(In.RoomUserWhisper, -1, "Pit stop tiles position set.", 0, 34, 0, -1);
                }
            }

            e.IsBlocked = true;
        }

        [InDataCapture("1d1cb11cb8d5156afeb284fb1eb04339")]
        private void RoomUserStatus(DataInterceptedEventArgs e)
        {
            try
            {
                if (!isRaceRunning) return;
                var actions = HEntityUpdate.Parse(e.Packet);

                foreach (var action in actions)
                    foreach (Player_Item control in playerControls)
                        if (action.Index == control.Index)
                        {
                            var tile = new Point(action.Tile.X, action.Tile.Y);

                            if (LapTiles.Contains(tile))
                                if (!RecentLapScore.Contains(action.Index))
                                {
                                    LapScoreAdd(action.Index);
                                    if (control.Laps > 0) control.Laps--;
                                    LastestAdd($"{control.Username} {control.Laps}+{control.Stops}");
                                    if (control.Laps > 0 || control.Stops > 0)
                                        ShoutQueue.Add($"{control.Username} {control.Laps}+{control.Stops}");
                                    else if (control.Laps == 0 && control.Stops == 0) ShoutQueue.Add($"{control.Username} Maali!");
                                }

                            if (StopTiles.Contains(tile))
                                if (!RecentStopScore.Contains(action.Index))
                                {
                                    StopScoreAdd(action.Index);
                                    if (control.Stops > 0) control.Stops--;
                                    LastestAdd($"{control.Username} {control.Laps}+{control.Stops}");
                                    if (control.Laps > 0 || control.Stops > 0)
                                        ShoutQueue.Add($"{control.Username} {control.Laps}+{control.Stops}");
                                    else if (control.Laps == 0 && control.Stops == 0) ShoutQueue.Add($"{control.Username} Maali!");
                                }
                        }
            } catch(Exception ex) { MessageBox.Show(ex.ToString()); }
                    
        }

        [InDataCapture("3c41c27886b935d66ed6c320160e389a")]
        private void RoomUserRemove (DataInterceptedEventArgs e)
        {
            var index = int.Parse(e.Packet.ReadString());

            foreach (var user in users)
                if (user.Index == index)
                {
                    users.Remove(user);
                    break;
                }

            foreach (Player_Item control in playerControls)
                if (control.Index == index) RemoveUserFromRace(index);
        }

        [InDataCapture("379974c2501be47ab1ae749f3cc2453a")]
        private void UpdateUserEffect(DataInterceptedEventArgs e)
        {
            try
            {
                var isUserListed = false;
                var usr = new RoomUser("", -1);
                var index = e.Packet.ReadInteger();
                var effectId = e.Packet.ReadInteger();

                foreach (var user in users)
                    if (user.Index == index) usr = user;

                foreach (Player_Item control in playerControls)
                    if (control.Index == index) isUserListed = true;

                usr.Effect = effectId;

                if (freezeEffectIds.Contains(effectId))
                {
                    if (!isUserListed)
                        foreach (Player_Item control in playerControls)
                            if (control.Index == -1)
                            {
                                control.Username = usr.Name;
                                control.Index = usr.Index;
                                if (isRaceRunning)
                                {
                                    control.Laps = Laps;
                                    control.Stops = Stops;
                                }
                                break;
                            }
                }
                else
                {
                    if (isUserListed)
                        RemoveUserFromRace(index);
                }
            } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void LapScoreAdd(int index)
        {
            Task.Factory.StartNew(() =>
            {
                RecentLapScore.Add(index);
                Thread.Sleep(10000);
                RecentLapScore.Remove(index);
            });
        }

        private void StopScoreAdd(int index)
        {
            Task.Factory.StartNew(() =>
            {
                RecentStopScore.Add(index);
                Thread.Sleep(10000);
                RecentStopScore.Remove(index);
            });
        }

        private void RemoveUserFromRace(int index)
        {
            var controlList = new List<Player_Item>();

            foreach (Player_Item control in playerControls)
                if (control.Index == index)
                {
                    control.Username = "";
                    control.Index = -1;
                    control.Stops = 0;
                    control.Laps = 0;
                    break;
                }

            foreach (Player_Item control in playerControls)
                if (control.Index != -1) controlList.Add(control);

            for (var i = 0; i < 20; i++)
            {
                if (i < controlList.Count)
                {
                    playerControls[i].Username = controlList[i].Username;
                    playerControls[i].Index = controlList[i].Index;
                    playerControls[i].Stops = controlList[i].Stops;
                    playerControls[i].Laps = controlList[i].Laps;
                }
                else
                {
                    playerControls[i].Username = "";
                    playerControls[i].Index = -1;
                    playerControls[i].Stops = 0;
                    playerControls[i].Laps = 0;
                }
            }
        }

        private string GetNameFromIndex(int index)
        {
            return "";
        }

        private void BT_Laps_Click(object sender, EventArgs e)
        {
            selectingLapTiles = true;
            LapTiles.Clear();
        }

        private void BT_Stops_Click(object sender, EventArgs e)
        {
            selectingStopTiles = true;
            StopTiles.Clear();
        }

        private void BT_NewRace_Click(object sender, EventArgs e)
        {
            foreach (Player_Item control in playerControls)
            {
                if (control.Index == -1) continue;
                control.Stops = int.Parse(TB_Stops.Texto);
                control.Laps = int.Parse(TB_Laps.Texto);
            }

            Stops = int.Parse(TB_Stops.Texto);
            Laps = int.Parse(TB_Laps.Texto);
            isRaceRunning = true;
        }

        private void BT_EndRace_Click(object sender, EventArgs e)
        {
            isRaceRunning = false;
            foreach (Player_Item control in playerControls)
            {
                control.Stops = 0;
                control.Laps = 0;
            }
        }

        private void BT_ClearUsers_Click(object sender, EventArgs e)
        {
            users.Clear();
            foreach (Player_Item control in playerControls)
            {
                control.Username = "";
                control.Index = -1;
                control.Stops = 0;
                control.Laps = 0;
            }
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            TB_Search.Text = "";
        }
    }
}
