using System.Drawing;
using System.Windows.Forms;

namespace Laskuri
{
    public partial class Player_Item : UserControl
    {
        public int Stops { get { return int.Parse(LB_Stops.Text); } set { LB_Stops.Text = value.ToString(); if (LB_Username.Text.Length > 0 && LB_Stops.Text == "0") LB_Stops.ForeColor = Color.Gold; else LB_Stops.ForeColor = Color.Red; } }
        public int Laps { get { return int.Parse(LB_Laps.Text); } set { LB_Laps.Text = value.ToString(); if (LB_Username.Text.Length > 0 && LB_Laps.Text == "0") LB_Laps.ForeColor = Color.Gold; else LB_Laps.ForeColor = Color.LightGreen; } }
        public string Username { get { return LB_Username.Text; } set { LB_Username.Text = value; } }
        public int Index { get; set; }

        public Player_Item()
        {
            InitializeComponent();
        }

        private void LB_Stops_Click(object sender, System.EventArgs e)
        {
            Stops--;
            LB_Stops.Text = Stops.ToString();
        }

        private void LB_Laps_Click(object sender, System.EventArgs e)
        {
            Laps--;
            LB_Laps.Text = Laps.ToString();
        }
    }
}
