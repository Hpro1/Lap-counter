namespace Laskuri
{
    partial class MainFrm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PN_Header = new System.Windows.Forms.Panel();
            this.PN_Minimize = new System.Windows.Forms.Panel();
            this.LB_Minimize = new System.Windows.Forms.Label();
            this.PN_Close = new System.Windows.Forms.Panel();
            this.LB_Close = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.PB_Icon = new System.Windows.Forms.PictureBox();
            this.PN_RaceManager = new System.Windows.Forms.Panel();
            this.PN_RaceManager_Header = new System.Windows.Forms.Panel();
            this.LB_RaceManager_Title = new System.Windows.Forms.Label();
            this.PN_Players_Header = new System.Windows.Forms.Panel();
            this.LB_Players_1_Title = new System.Windows.Forms.Label();
            this.PN_Players = new System.Windows.Forms.Panel();
            this.PN_Players_2 = new System.Windows.Forms.Panel();
            this.PN_Players_1 = new System.Windows.Forms.Panel();
            this.PN_Scoreboard = new System.Windows.Forms.Panel();
            this.PN_Scoreboard_3 = new System.Windows.Forms.Panel();
            this.LB_Scoreboard_3 = new System.Windows.Forms.Label();
            this.PN_Scoreboard_2 = new System.Windows.Forms.Panel();
            this.LB_Scoreboard_2 = new System.Windows.Forms.Label();
            this.PN_Scoreboard_1 = new System.Windows.Forms.Panel();
            this.LB_Scoreboard_1 = new System.Windows.Forms.Label();
            this.PN_Scoreboard_Header = new System.Windows.Forms.Panel();
            this.LB_Scoreboard_Title = new System.Windows.Forms.Label();
            this.CB_TopMost = new System.Windows.Forms.CheckBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.CB_Shout = new System.Windows.Forms.CheckBox();
            this.BT_Clear = new Laskuri.Fluent_Button();
            this.BT_ClearUsers = new Laskuri.Fluent_Button();
            this.BT_Stops = new Laskuri.Fluent_Button();
            this.BT_Laps = new Laskuri.Fluent_Button();
            this.BT_EndRace = new Laskuri.Fluent_Button();
            this.BT_NewRace = new Laskuri.Fluent_Button();
            this.TB_Stops = new Laskuri.Labeled_TextBox();
            this.TB_Laps = new Laskuri.Labeled_TextBox();
            this.PL_20 = new Laskuri.Player_Item();
            this.PL_19 = new Laskuri.Player_Item();
            this.PL_18 = new Laskuri.Player_Item();
            this.PL_17 = new Laskuri.Player_Item();
            this.PL_16 = new Laskuri.Player_Item();
            this.PL_15 = new Laskuri.Player_Item();
            this.PL_14 = new Laskuri.Player_Item();
            this.PL_13 = new Laskuri.Player_Item();
            this.PL_12 = new Laskuri.Player_Item();
            this.PL_11 = new Laskuri.Player_Item();
            this.PL_10 = new Laskuri.Player_Item();
            this.PL_9 = new Laskuri.Player_Item();
            this.PL_8 = new Laskuri.Player_Item();
            this.PL_7 = new Laskuri.Player_Item();
            this.PL_6 = new Laskuri.Player_Item();
            this.PL_5 = new Laskuri.Player_Item();
            this.PL_4 = new Laskuri.Player_Item();
            this.PL_3 = new Laskuri.Player_Item();
            this.PL_2 = new Laskuri.Player_Item();
            this.PL_1 = new Laskuri.Player_Item();
            this.PN_Header.SuspendLayout();
            this.PN_Minimize.SuspendLayout();
            this.PN_Close.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
            this.PN_RaceManager.SuspendLayout();
            this.PN_RaceManager_Header.SuspendLayout();
            this.PN_Players_Header.SuspendLayout();
            this.PN_Players.SuspendLayout();
            this.PN_Players_2.SuspendLayout();
            this.PN_Players_1.SuspendLayout();
            this.PN_Scoreboard.SuspendLayout();
            this.PN_Scoreboard_3.SuspendLayout();
            this.PN_Scoreboard_2.SuspendLayout();
            this.PN_Scoreboard_1.SuspendLayout();
            this.PN_Scoreboard_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Header
            // 
            this.PN_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.PN_Header.Controls.Add(this.PN_Minimize);
            this.PN_Header.Controls.Add(this.PN_Close);
            this.PN_Header.Controls.Add(this.LB_Title);
            this.PN_Header.Controls.Add(this.PB_Icon);
            this.PN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Header.Location = new System.Drawing.Point(0, 0);
            this.PN_Header.Name = "PN_Header";
            this.PN_Header.Size = new System.Drawing.Size(614, 34);
            this.PN_Header.TabIndex = 1;
            this.PN_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.PN_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            this.PN_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // PN_Minimize
            // 
            this.PN_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.PN_Minimize.Controls.Add(this.LB_Minimize);
            this.PN_Minimize.Location = new System.Drawing.Point(479, 0);
            this.PN_Minimize.Name = "PN_Minimize";
            this.PN_Minimize.Size = new System.Drawing.Size(48, 29);
            this.PN_Minimize.TabIndex = 3;
            this.PN_Minimize.Click += new System.EventHandler(this.PN_Minimize_Click);
            this.PN_Minimize.MouseEnter += new System.EventHandler(this.PN_Minimize_MouseEnter);
            this.PN_Minimize.MouseLeave += new System.EventHandler(this.PN_Minimize_MouseLeave);
            // 
            // LB_Minimize
            // 
            this.LB_Minimize.AutoSize = true;
            this.LB_Minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Minimize.ForeColor = System.Drawing.Color.LightGray;
            this.LB_Minimize.Location = new System.Drawing.Point(11, 3);
            this.LB_Minimize.Name = "LB_Minimize";
            this.LB_Minimize.Size = new System.Drawing.Size(26, 21);
            this.LB_Minimize.TabIndex = 4;
            this.LB_Minimize.Text = "—";
            this.LB_Minimize.Click += new System.EventHandler(this.PN_Minimize_Click);
            this.LB_Minimize.MouseEnter += new System.EventHandler(this.PN_Minimize_MouseEnter);
            this.LB_Minimize.MouseLeave += new System.EventHandler(this.PN_Minimize_MouseLeave);
            // 
            // PN_Close
            // 
            this.PN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.PN_Close.Controls.Add(this.LB_Close);
            this.PN_Close.Location = new System.Drawing.Point(531, 0);
            this.PN_Close.Name = "PN_Close";
            this.PN_Close.Size = new System.Drawing.Size(48, 29);
            this.PN_Close.TabIndex = 2;
            this.PN_Close.Click += new System.EventHandler(this.PN_Close_Click);
            this.PN_Close.MouseEnter += new System.EventHandler(this.PN_Close_MouseEnter);
            this.PN_Close.MouseLeave += new System.EventHandler(this.PN_Close_MouseLeave);
            // 
            // LB_Close
            // 
            this.LB_Close.AutoSize = true;
            this.LB_Close.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Close.ForeColor = System.Drawing.Color.White;
            this.LB_Close.Location = new System.Drawing.Point(15, 3);
            this.LB_Close.Name = "LB_Close";
            this.LB_Close.Size = new System.Drawing.Size(19, 21);
            this.LB_Close.TabIndex = 5;
            this.LB_Close.Text = "X";
            this.LB_Close.Click += new System.EventHandler(this.PN_Close_Click);
            this.LB_Close.MouseEnter += new System.EventHandler(this.PN_Close_MouseEnter);
            this.LB_Close.MouseLeave += new System.EventHandler(this.PN_Close_MouseLeave);
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.ForeColor = System.Drawing.Color.White;
            this.LB_Title.Location = new System.Drawing.Point(29, 5);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(60, 21);
            this.LB_Title.TabIndex = 1;
            this.LB_Title.Text = "Laskuri";
            this.LB_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.LB_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            this.LB_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // PB_Icon
            // 
            this.PB_Icon.Image = global::Laskuri.Properties.Resources.flag_icon;
            this.PB_Icon.Location = new System.Drawing.Point(9, 10);
            this.PB_Icon.Name = "PB_Icon";
            this.PB_Icon.Size = new System.Drawing.Size(17, 14);
            this.PB_Icon.TabIndex = 0;
            this.PB_Icon.TabStop = false;
            this.PB_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.PB_Icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            this.PB_Icon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // PN_RaceManager
            // 
            this.PN_RaceManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PN_RaceManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_RaceManager.Controls.Add(this.BT_Stops);
            this.PN_RaceManager.Controls.Add(this.BT_Laps);
            this.PN_RaceManager.Controls.Add(this.BT_EndRace);
            this.PN_RaceManager.Controls.Add(this.BT_NewRace);
            this.PN_RaceManager.Controls.Add(this.TB_Stops);
            this.PN_RaceManager.Controls.Add(this.TB_Laps);
            this.PN_RaceManager.Controls.Add(this.PN_RaceManager_Header);
            this.PN_RaceManager.Location = new System.Drawing.Point(4, 38);
            this.PN_RaceManager.Name = "PN_RaceManager";
            this.PN_RaceManager.Size = new System.Drawing.Size(277, 226);
            this.PN_RaceManager.TabIndex = 3;
            // 
            // PN_RaceManager_Header
            // 
            this.PN_RaceManager_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.PN_RaceManager_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_RaceManager_Header.Controls.Add(this.LB_RaceManager_Title);
            this.PN_RaceManager_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_RaceManager_Header.Location = new System.Drawing.Point(0, 0);
            this.PN_RaceManager_Header.Name = "PN_RaceManager_Header";
            this.PN_RaceManager_Header.Size = new System.Drawing.Size(275, 36);
            this.PN_RaceManager_Header.TabIndex = 0;
            // 
            // LB_RaceManager_Title
            // 
            this.LB_RaceManager_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_RaceManager_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RaceManager_Title.ForeColor = System.Drawing.Color.White;
            this.LB_RaceManager_Title.Location = new System.Drawing.Point(0, 0);
            this.LB_RaceManager_Title.Name = "LB_RaceManager_Title";
            this.LB_RaceManager_Title.Size = new System.Drawing.Size(273, 34);
            this.LB_RaceManager_Title.TabIndex = 2;
            this.LB_RaceManager_Title.Text = "Kilpailu hallinta";
            this.LB_RaceManager_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_Players_Header
            // 
            this.PN_Players_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.PN_Players_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Players_Header.Controls.Add(this.LB_Players_1_Title);
            this.PN_Players_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Players_Header.Location = new System.Drawing.Point(0, 0);
            this.PN_Players_Header.Name = "PN_Players_Header";
            this.PN_Players_Header.Size = new System.Drawing.Size(320, 36);
            this.PN_Players_Header.TabIndex = 0;
            // 
            // LB_Players_1_Title
            // 
            this.LB_Players_1_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Players_1_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Players_1_Title.ForeColor = System.Drawing.Color.White;
            this.LB_Players_1_Title.Location = new System.Drawing.Point(0, 0);
            this.LB_Players_1_Title.Name = "LB_Players_1_Title";
            this.LB_Players_1_Title.Size = new System.Drawing.Size(318, 34);
            this.LB_Players_1_Title.TabIndex = 2;
            this.LB_Players_1_Title.Text = "Pelaajat";
            this.LB_Players_1_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_Players
            // 
            this.PN_Players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PN_Players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Players.Controls.Add(this.PN_Players_2);
            this.PN_Players.Controls.Add(this.PN_Players_1);
            this.PN_Players.Controls.Add(this.PN_Players_Header);
            this.PN_Players.Location = new System.Drawing.Point(287, 38);
            this.PN_Players.Name = "PN_Players";
            this.PN_Players.Size = new System.Drawing.Size(322, 398);
            this.PN_Players.TabIndex = 2;
            // 
            // PN_Players_2
            // 
            this.PN_Players_2.Controls.Add(this.PL_20);
            this.PN_Players_2.Controls.Add(this.PL_19);
            this.PN_Players_2.Controls.Add(this.PL_18);
            this.PN_Players_2.Controls.Add(this.PL_17);
            this.PN_Players_2.Controls.Add(this.PL_16);
            this.PN_Players_2.Controls.Add(this.PL_15);
            this.PN_Players_2.Controls.Add(this.PL_14);
            this.PN_Players_2.Controls.Add(this.PL_13);
            this.PN_Players_2.Controls.Add(this.PL_12);
            this.PN_Players_2.Controls.Add(this.PL_11);
            this.PN_Players_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.PN_Players_2.Location = new System.Drawing.Point(161, 36);
            this.PN_Players_2.Name = "PN_Players_2";
            this.PN_Players_2.Size = new System.Drawing.Size(161, 360);
            this.PN_Players_2.TabIndex = 2;
            // 
            // PN_Players_1
            // 
            this.PN_Players_1.Controls.Add(this.PL_10);
            this.PN_Players_1.Controls.Add(this.PL_9);
            this.PN_Players_1.Controls.Add(this.PL_8);
            this.PN_Players_1.Controls.Add(this.PL_7);
            this.PN_Players_1.Controls.Add(this.PL_6);
            this.PN_Players_1.Controls.Add(this.PL_5);
            this.PN_Players_1.Controls.Add(this.PL_4);
            this.PN_Players_1.Controls.Add(this.PL_3);
            this.PN_Players_1.Controls.Add(this.PL_2);
            this.PN_Players_1.Controls.Add(this.PL_1);
            this.PN_Players_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PN_Players_1.Location = new System.Drawing.Point(0, 36);
            this.PN_Players_1.Name = "PN_Players_1";
            this.PN_Players_1.Size = new System.Drawing.Size(161, 360);
            this.PN_Players_1.TabIndex = 1;
            // 
            // PN_Scoreboard
            // 
            this.PN_Scoreboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Scoreboard.Controls.Add(this.PN_Scoreboard_3);
            this.PN_Scoreboard.Controls.Add(this.PN_Scoreboard_2);
            this.PN_Scoreboard.Controls.Add(this.PN_Scoreboard_1);
            this.PN_Scoreboard.Controls.Add(this.PN_Scoreboard_Header);
            this.PN_Scoreboard.Location = new System.Drawing.Point(4, 270);
            this.PN_Scoreboard.Name = "PN_Scoreboard";
            this.PN_Scoreboard.Size = new System.Drawing.Size(276, 144);
            this.PN_Scoreboard.TabIndex = 4;
            // 
            // PN_Scoreboard_3
            // 
            this.PN_Scoreboard_3.Controls.Add(this.LB_Scoreboard_3);
            this.PN_Scoreboard_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Scoreboard_3.Location = new System.Drawing.Point(0, 108);
            this.PN_Scoreboard_3.Name = "PN_Scoreboard_3";
            this.PN_Scoreboard_3.Size = new System.Drawing.Size(274, 36);
            this.PN_Scoreboard_3.TabIndex = 3;
            // 
            // LB_Scoreboard_3
            // 
            this.LB_Scoreboard_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Scoreboard_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Scoreboard_3.ForeColor = System.Drawing.Color.White;
            this.LB_Scoreboard_3.Location = new System.Drawing.Point(0, 0);
            this.LB_Scoreboard_3.Name = "LB_Scoreboard_3";
            this.LB_Scoreboard_3.Size = new System.Drawing.Size(274, 36);
            this.LB_Scoreboard_3.TabIndex = 4;
            this.LB_Scoreboard_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_Scoreboard_2
            // 
            this.PN_Scoreboard_2.Controls.Add(this.LB_Scoreboard_2);
            this.PN_Scoreboard_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Scoreboard_2.Location = new System.Drawing.Point(0, 72);
            this.PN_Scoreboard_2.Name = "PN_Scoreboard_2";
            this.PN_Scoreboard_2.Size = new System.Drawing.Size(274, 36);
            this.PN_Scoreboard_2.TabIndex = 2;
            // 
            // LB_Scoreboard_2
            // 
            this.LB_Scoreboard_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Scoreboard_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Scoreboard_2.ForeColor = System.Drawing.Color.White;
            this.LB_Scoreboard_2.Location = new System.Drawing.Point(0, 0);
            this.LB_Scoreboard_2.Name = "LB_Scoreboard_2";
            this.LB_Scoreboard_2.Size = new System.Drawing.Size(274, 36);
            this.LB_Scoreboard_2.TabIndex = 4;
            this.LB_Scoreboard_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_Scoreboard_1
            // 
            this.PN_Scoreboard_1.Controls.Add(this.LB_Scoreboard_1);
            this.PN_Scoreboard_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Scoreboard_1.Location = new System.Drawing.Point(0, 36);
            this.PN_Scoreboard_1.Name = "PN_Scoreboard_1";
            this.PN_Scoreboard_1.Size = new System.Drawing.Size(274, 36);
            this.PN_Scoreboard_1.TabIndex = 1;
            // 
            // LB_Scoreboard_1
            // 
            this.LB_Scoreboard_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Scoreboard_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Scoreboard_1.ForeColor = System.Drawing.Color.White;
            this.LB_Scoreboard_1.Location = new System.Drawing.Point(0, 0);
            this.LB_Scoreboard_1.Name = "LB_Scoreboard_1";
            this.LB_Scoreboard_1.Size = new System.Drawing.Size(274, 36);
            this.LB_Scoreboard_1.TabIndex = 4;
            this.LB_Scoreboard_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_Scoreboard_Header
            // 
            this.PN_Scoreboard_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.PN_Scoreboard_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Scoreboard_Header.Controls.Add(this.LB_Scoreboard_Title);
            this.PN_Scoreboard_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Scoreboard_Header.Location = new System.Drawing.Point(0, 0);
            this.PN_Scoreboard_Header.Name = "PN_Scoreboard_Header";
            this.PN_Scoreboard_Header.Size = new System.Drawing.Size(274, 36);
            this.PN_Scoreboard_Header.TabIndex = 0;
            // 
            // LB_Scoreboard_Title
            // 
            this.LB_Scoreboard_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Scoreboard_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Scoreboard_Title.ForeColor = System.Drawing.Color.White;
            this.LB_Scoreboard_Title.Location = new System.Drawing.Point(0, 0);
            this.LB_Scoreboard_Title.Name = "LB_Scoreboard_Title";
            this.LB_Scoreboard_Title.Size = new System.Drawing.Size(272, 34);
            this.LB_Scoreboard_Title.TabIndex = 3;
            this.LB_Scoreboard_Title.Text = "Viimeisimmät";
            this.LB_Scoreboard_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_TopMost
            // 
            this.CB_TopMost.AutoSize = true;
            this.CB_TopMost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TopMost.ForeColor = System.Drawing.Color.White;
            this.CB_TopMost.Location = new System.Drawing.Point(483, 441);
            this.CB_TopMost.Name = "CB_TopMost";
            this.CB_TopMost.Size = new System.Drawing.Size(127, 25);
            this.CB_TopMost.TabIndex = 11;
            this.CB_TopMost.Text = "Always on top";
            this.CB_TopMost.UseVisualStyleBackColor = true;
            this.CB_TopMost.CheckedChanged += new System.EventHandler(this.CB_TopMost_CheckedChanged);
            // 
            // TB_Search
            // 
            this.TB_Search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(288, 450);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(136, 33);
            this.TB_Search.TabIndex = 12;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            // 
            // CB_Shout
            // 
            this.CB_Shout.AutoSize = true;
            this.CB_Shout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Shout.ForeColor = System.Drawing.Color.White;
            this.CB_Shout.Location = new System.Drawing.Point(483, 462);
            this.CB_Shout.Name = "CB_Shout";
            this.CB_Shout.Size = new System.Drawing.Size(70, 25);
            this.CB_Shout.TabIndex = 13;
            this.CB_Shout.Text = "Shout";
            this.CB_Shout.UseVisualStyleBackColor = true;
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BT_Clear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BT_Clear.ForeColor = System.Drawing.Color.Black;
            this.BT_Clear.Location = new System.Drawing.Point(430, 450);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(47, 33);
            this.BT_Clear.TabIndex = 14;
            this.BT_Clear.Text = "Clear";
            this.BT_Clear.UseVisualStyleBackColor = false;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // BT_ClearUsers
            // 
            this.BT_ClearUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BT_ClearUsers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BT_ClearUsers.ForeColor = System.Drawing.Color.Black;
            this.BT_ClearUsers.Location = new System.Drawing.Point(4, 421);
            this.BT_ClearUsers.Name = "BT_ClearUsers";
            this.BT_ClearUsers.Size = new System.Drawing.Size(276, 62);
            this.BT_ClearUsers.TabIndex = 10;
            this.BT_ClearUsers.Text = "Nollaa (resettaa huone)";
            this.BT_ClearUsers.UseVisualStyleBackColor = false;
            this.BT_ClearUsers.Click += new System.EventHandler(this.BT_ClearUsers_Click);
            // 
            // BT_Stops
            // 
            this.BT_Stops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BT_Stops.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BT_Stops.ForeColor = System.Drawing.Color.Black;
            this.BT_Stops.Location = new System.Drawing.Point(140, 108);
            this.BT_Stops.Name = "BT_Stops";
            this.BT_Stops.Size = new System.Drawing.Size(129, 33);
            this.BT_Stops.TabIndex = 9;
            this.BT_Stops.Text = "Aseta varikkolaatat";
            this.BT_Stops.UseVisualStyleBackColor = false;
            this.BT_Stops.Click += new System.EventHandler(this.BT_Stops_Click);
            // 
            // BT_Laps
            // 
            this.BT_Laps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BT_Laps.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BT_Laps.ForeColor = System.Drawing.Color.Black;
            this.BT_Laps.Location = new System.Drawing.Point(5, 108);
            this.BT_Laps.Name = "BT_Laps";
            this.BT_Laps.Size = new System.Drawing.Size(129, 33);
            this.BT_Laps.TabIndex = 8;
            this.BT_Laps.Text = "Aseta kisalaatat";
            this.BT_Laps.UseVisualStyleBackColor = false;
            this.BT_Laps.Click += new System.EventHandler(this.BT_Laps_Click);
            // 
            // BT_EndRace
            // 
            this.BT_EndRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BT_EndRace.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BT_EndRace.ForeColor = System.Drawing.Color.Black;
            this.BT_EndRace.Location = new System.Drawing.Point(5, 186);
            this.BT_EndRace.Name = "BT_EndRace";
            this.BT_EndRace.Size = new System.Drawing.Size(264, 33);
            this.BT_EndRace.TabIndex = 7;
            this.BT_EndRace.Text = "Lopeta kisa";
            this.BT_EndRace.UseVisualStyleBackColor = false;
            this.BT_EndRace.Click += new System.EventHandler(this.BT_EndRace_Click);
            // 
            // BT_NewRace
            // 
            this.BT_NewRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BT_NewRace.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BT_NewRace.ForeColor = System.Drawing.Color.Black;
            this.BT_NewRace.Location = new System.Drawing.Point(5, 147);
            this.BT_NewRace.Name = "BT_NewRace";
            this.BT_NewRace.Size = new System.Drawing.Size(264, 33);
            this.BT_NewRace.TabIndex = 6;
            this.BT_NewRace.Text = "Luo uusi kisa";
            this.BT_NewRace.UseVisualStyleBackColor = false;
            this.BT_NewRace.Click += new System.EventHandler(this.BT_NewRace_Click);
            // 
            // TB_Stops
            // 
            this.TB_Stops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.TB_Stops.Label = "Varikot";
            this.TB_Stops.Location = new System.Drawing.Point(140, 42);
            this.TB_Stops.Name = "TB_Stops";
            this.TB_Stops.Size = new System.Drawing.Size(129, 60);
            this.TB_Stops.TabIndex = 5;
            this.TB_Stops.Texto = "";
            // 
            // TB_Laps
            // 
            this.TB_Laps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.TB_Laps.Label = "Kierrokset";
            this.TB_Laps.Location = new System.Drawing.Point(5, 42);
            this.TB_Laps.Name = "TB_Laps";
            this.TB_Laps.Size = new System.Drawing.Size(129, 60);
            this.TB_Laps.TabIndex = 4;
            this.TB_Laps.Texto = "";
            // 
            // PL_20
            // 
            this.PL_20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_20.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_20.Index = -1;
            this.PL_20.Laps = 0;
            this.PL_20.Location = new System.Drawing.Point(0, 324);
            this.PL_20.Name = "PL_20";
            this.PL_20.Size = new System.Drawing.Size(161, 36);
            this.PL_20.Stops = 0;
            this.PL_20.TabIndex = 10;
            this.PL_20.Username = "";
            // 
            // PL_19
            // 
            this.PL_19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_19.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_19.Index = -1;
            this.PL_19.Laps = 0;
            this.PL_19.Location = new System.Drawing.Point(0, 288);
            this.PL_19.Name = "PL_19";
            this.PL_19.Size = new System.Drawing.Size(161, 36);
            this.PL_19.Stops = 0;
            this.PL_19.TabIndex = 9;
            this.PL_19.Username = "";
            // 
            // PL_18
            // 
            this.PL_18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_18.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_18.Index = -1;
            this.PL_18.Laps = 0;
            this.PL_18.Location = new System.Drawing.Point(0, 252);
            this.PL_18.Name = "PL_18";
            this.PL_18.Size = new System.Drawing.Size(161, 36);
            this.PL_18.Stops = 0;
            this.PL_18.TabIndex = 8;
            this.PL_18.Username = "";
            // 
            // PL_17
            // 
            this.PL_17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_17.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_17.Index = -1;
            this.PL_17.Laps = 0;
            this.PL_17.Location = new System.Drawing.Point(0, 216);
            this.PL_17.Name = "PL_17";
            this.PL_17.Size = new System.Drawing.Size(161, 36);
            this.PL_17.Stops = 0;
            this.PL_17.TabIndex = 7;
            this.PL_17.Username = "";
            // 
            // PL_16
            // 
            this.PL_16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_16.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_16.Index = -1;
            this.PL_16.Laps = 0;
            this.PL_16.Location = new System.Drawing.Point(0, 180);
            this.PL_16.Name = "PL_16";
            this.PL_16.Size = new System.Drawing.Size(161, 36);
            this.PL_16.Stops = 0;
            this.PL_16.TabIndex = 6;
            this.PL_16.Username = "";
            // 
            // PL_15
            // 
            this.PL_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_15.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_15.Index = -1;
            this.PL_15.Laps = 0;
            this.PL_15.Location = new System.Drawing.Point(0, 144);
            this.PL_15.Name = "PL_15";
            this.PL_15.Size = new System.Drawing.Size(161, 36);
            this.PL_15.Stops = 0;
            this.PL_15.TabIndex = 5;
            this.PL_15.Username = "";
            // 
            // PL_14
            // 
            this.PL_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_14.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_14.Index = -1;
            this.PL_14.Laps = 0;
            this.PL_14.Location = new System.Drawing.Point(0, 108);
            this.PL_14.Name = "PL_14";
            this.PL_14.Size = new System.Drawing.Size(161, 36);
            this.PL_14.Stops = 0;
            this.PL_14.TabIndex = 4;
            this.PL_14.Username = "";
            // 
            // PL_13
            // 
            this.PL_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_13.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_13.Index = -1;
            this.PL_13.Laps = 0;
            this.PL_13.Location = new System.Drawing.Point(0, 72);
            this.PL_13.Name = "PL_13";
            this.PL_13.Size = new System.Drawing.Size(161, 36);
            this.PL_13.Stops = 0;
            this.PL_13.TabIndex = 3;
            this.PL_13.Username = "";
            // 
            // PL_12
            // 
            this.PL_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_12.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_12.Index = -1;
            this.PL_12.Laps = 0;
            this.PL_12.Location = new System.Drawing.Point(0, 36);
            this.PL_12.Name = "PL_12";
            this.PL_12.Size = new System.Drawing.Size(161, 36);
            this.PL_12.Stops = 0;
            this.PL_12.TabIndex = 2;
            this.PL_12.Username = "";
            // 
            // PL_11
            // 
            this.PL_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_11.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_11.Index = -1;
            this.PL_11.Laps = 0;
            this.PL_11.Location = new System.Drawing.Point(0, 0);
            this.PL_11.Name = "PL_11";
            this.PL_11.Size = new System.Drawing.Size(161, 36);
            this.PL_11.Stops = 0;
            this.PL_11.TabIndex = 1;
            this.PL_11.Username = "";
            // 
            // PL_10
            // 
            this.PL_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_10.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_10.Index = -1;
            this.PL_10.Laps = 0;
            this.PL_10.Location = new System.Drawing.Point(0, 324);
            this.PL_10.Name = "PL_10";
            this.PL_10.Size = new System.Drawing.Size(161, 36);
            this.PL_10.Stops = 0;
            this.PL_10.TabIndex = 9;
            this.PL_10.Username = "";
            // 
            // PL_9
            // 
            this.PL_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_9.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_9.Index = -1;
            this.PL_9.Laps = 0;
            this.PL_9.Location = new System.Drawing.Point(0, 288);
            this.PL_9.Name = "PL_9";
            this.PL_9.Size = new System.Drawing.Size(161, 36);
            this.PL_9.Stops = 0;
            this.PL_9.TabIndex = 8;
            this.PL_9.Username = "";
            // 
            // PL_8
            // 
            this.PL_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_8.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_8.Index = -1;
            this.PL_8.Laps = 0;
            this.PL_8.Location = new System.Drawing.Point(0, 252);
            this.PL_8.Name = "PL_8";
            this.PL_8.Size = new System.Drawing.Size(161, 36);
            this.PL_8.Stops = 0;
            this.PL_8.TabIndex = 7;
            this.PL_8.Username = "";
            // 
            // PL_7
            // 
            this.PL_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_7.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_7.Index = -1;
            this.PL_7.Laps = 0;
            this.PL_7.Location = new System.Drawing.Point(0, 216);
            this.PL_7.Name = "PL_7";
            this.PL_7.Size = new System.Drawing.Size(161, 36);
            this.PL_7.Stops = 0;
            this.PL_7.TabIndex = 6;
            this.PL_7.Username = "";
            // 
            // PL_6
            // 
            this.PL_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_6.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_6.Index = -1;
            this.PL_6.Laps = 0;
            this.PL_6.Location = new System.Drawing.Point(0, 180);
            this.PL_6.Name = "PL_6";
            this.PL_6.Size = new System.Drawing.Size(161, 36);
            this.PL_6.Stops = 0;
            this.PL_6.TabIndex = 5;
            this.PL_6.Username = "";
            // 
            // PL_5
            // 
            this.PL_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_5.Index = -1;
            this.PL_5.Laps = 0;
            this.PL_5.Location = new System.Drawing.Point(0, 144);
            this.PL_5.Name = "PL_5";
            this.PL_5.Size = new System.Drawing.Size(161, 36);
            this.PL_5.Stops = 0;
            this.PL_5.TabIndex = 4;
            this.PL_5.Username = "";
            // 
            // PL_4
            // 
            this.PL_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_4.Index = -1;
            this.PL_4.Laps = 0;
            this.PL_4.Location = new System.Drawing.Point(0, 108);
            this.PL_4.Name = "PL_4";
            this.PL_4.Size = new System.Drawing.Size(161, 36);
            this.PL_4.Stops = 0;
            this.PL_4.TabIndex = 3;
            this.PL_4.Username = "";
            // 
            // PL_3
            // 
            this.PL_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_3.Index = -1;
            this.PL_3.Laps = 0;
            this.PL_3.Location = new System.Drawing.Point(0, 72);
            this.PL_3.Name = "PL_3";
            this.PL_3.Size = new System.Drawing.Size(161, 36);
            this.PL_3.Stops = 0;
            this.PL_3.TabIndex = 2;
            this.PL_3.Username = "";
            // 
            // PL_2
            // 
            this.PL_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_2.Index = -1;
            this.PL_2.Laps = 0;
            this.PL_2.Location = new System.Drawing.Point(0, 36);
            this.PL_2.Name = "PL_2";
            this.PL_2.Size = new System.Drawing.Size(161, 36);
            this.PL_2.Stops = 0;
            this.PL_2.TabIndex = 1;
            this.PL_2.Username = "";
            // 
            // PL_1
            // 
            this.PL_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PL_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_1.Index = -1;
            this.PL_1.Laps = 0;
            this.PL_1.Location = new System.Drawing.Point(0, 0);
            this.PL_1.Name = "PL_1";
            this.PL_1.Size = new System.Drawing.Size(161, 36);
            this.PL_1.Stops = 0;
            this.PL_1.TabIndex = 0;
            this.PL_1.Username = "";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(614, 489);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.CB_Shout);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.CB_TopMost);
            this.Controls.Add(this.BT_ClearUsers);
            this.Controls.Add(this.PN_Scoreboard);
            this.Controls.Add(this.PN_RaceManager);
            this.Controls.Add(this.PN_Players);
            this.Controls.Add(this.PN_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laskuri";
            this.PN_Header.ResumeLayout(false);
            this.PN_Header.PerformLayout();
            this.PN_Minimize.ResumeLayout(false);
            this.PN_Minimize.PerformLayout();
            this.PN_Close.ResumeLayout(false);
            this.PN_Close.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
            this.PN_RaceManager.ResumeLayout(false);
            this.PN_RaceManager_Header.ResumeLayout(false);
            this.PN_Players_Header.ResumeLayout(false);
            this.PN_Players.ResumeLayout(false);
            this.PN_Players_2.ResumeLayout(false);
            this.PN_Players_1.ResumeLayout(false);
            this.PN_Scoreboard.ResumeLayout(false);
            this.PN_Scoreboard_3.ResumeLayout(false);
            this.PN_Scoreboard_2.ResumeLayout(false);
            this.PN_Scoreboard_1.ResumeLayout(false);
            this.PN_Scoreboard_Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PN_Header;
        private System.Windows.Forms.Panel PN_Minimize;
        private System.Windows.Forms.Label LB_Minimize;
        private System.Windows.Forms.Panel PN_Close;
        private System.Windows.Forms.Label LB_Close;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.PictureBox PB_Icon;
        private System.Windows.Forms.Panel PN_RaceManager;
        private System.Windows.Forms.Panel PN_RaceManager_Header;
        private System.Windows.Forms.Label LB_RaceManager_Title;
        private Labeled_TextBox TB_Stops;
        private Labeled_TextBox TB_Laps;
        private Fluent_Button BT_NewRace;
        private Fluent_Button BT_EndRace;
        private System.Windows.Forms.Panel PN_Players_Header;
        private System.Windows.Forms.Label LB_Players_1_Title;
        private System.Windows.Forms.Panel PN_Players;
        private System.Windows.Forms.Panel PN_Players_2;
        private Player_Item PL_20;
        private Player_Item PL_19;
        private Player_Item PL_18;
        private Player_Item PL_17;
        private Player_Item PL_16;
        private Player_Item PL_15;
        private Player_Item PL_14;
        private Player_Item PL_13;
        private Player_Item PL_12;
        private Player_Item PL_11;
        private System.Windows.Forms.Panel PN_Players_1;
        private Player_Item PL_10;
        private Player_Item PL_9;
        private Player_Item PL_8;
        private Player_Item PL_7;
        private Player_Item PL_6;
        private Player_Item PL_5;
        private Player_Item PL_4;
        private Player_Item PL_3;
        private Player_Item PL_2;
        private Player_Item PL_1;
        private Fluent_Button BT_Stops;
        private Fluent_Button BT_Laps;
        private System.Windows.Forms.Panel PN_Scoreboard;
        private System.Windows.Forms.Panel PN_Scoreboard_1;
        private System.Windows.Forms.Panel PN_Scoreboard_Header;
        private System.Windows.Forms.Label LB_Scoreboard_Title;
        private System.Windows.Forms.Panel PN_Scoreboard_3;
        private System.Windows.Forms.Label LB_Scoreboard_3;
        private System.Windows.Forms.Panel PN_Scoreboard_2;
        private System.Windows.Forms.Label LB_Scoreboard_2;
        private System.Windows.Forms.Label LB_Scoreboard_1;
        private Fluent_Button BT_ClearUsers;
        private System.Windows.Forms.CheckBox CB_TopMost;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.CheckBox CB_Shout;
        private Fluent_Button BT_Clear;
    }
}

