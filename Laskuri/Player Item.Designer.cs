namespace Laskuri
{
    partial class Player_Item
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PN_Parent = new System.Windows.Forms.Panel();
            this.LB_Username = new System.Windows.Forms.Label();
            this.PN_Laps = new System.Windows.Forms.Panel();
            this.LB_Laps = new System.Windows.Forms.Label();
            this.PN_Stops = new System.Windows.Forms.Panel();
            this.LB_Stops = new System.Windows.Forms.Label();
            this.PN_Parent.SuspendLayout();
            this.PN_Laps.SuspendLayout();
            this.PN_Stops.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Parent
            // 
            this.PN_Parent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.PN_Parent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Parent.Controls.Add(this.LB_Username);
            this.PN_Parent.Controls.Add(this.PN_Laps);
            this.PN_Parent.Controls.Add(this.PN_Stops);
            this.PN_Parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_Parent.Location = new System.Drawing.Point(0, 0);
            this.PN_Parent.Name = "PN_Parent";
            this.PN_Parent.Size = new System.Drawing.Size(161, 36);
            this.PN_Parent.TabIndex = 3;
            // 
            // LB_Username
            // 
            this.LB_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.ForeColor = System.Drawing.Color.White;
            this.LB_Username.Location = new System.Drawing.Point(0, 0);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(119, 34);
            this.LB_Username.TabIndex = 3;
            this.LB_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_Laps
            // 
            this.PN_Laps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.PN_Laps.Controls.Add(this.LB_Laps);
            this.PN_Laps.Dock = System.Windows.Forms.DockStyle.Right;
            this.PN_Laps.Location = new System.Drawing.Point(119, 0);
            this.PN_Laps.Name = "PN_Laps";
            this.PN_Laps.Size = new System.Drawing.Size(20, 34);
            this.PN_Laps.TabIndex = 1;
            // 
            // LB_Laps
            // 
            this.LB_Laps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Laps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Laps.ForeColor = System.Drawing.Color.LightGreen;
            this.LB_Laps.Location = new System.Drawing.Point(0, 0);
            this.LB_Laps.Name = "LB_Laps";
            this.LB_Laps.Size = new System.Drawing.Size(20, 34);
            this.LB_Laps.TabIndex = 4;
            this.LB_Laps.Text = "0";
            this.LB_Laps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Laps.Click += new System.EventHandler(this.LB_Laps_Click);
            // 
            // PN_Stops
            // 
            this.PN_Stops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.PN_Stops.Controls.Add(this.LB_Stops);
            this.PN_Stops.Dock = System.Windows.Forms.DockStyle.Right;
            this.PN_Stops.Location = new System.Drawing.Point(139, 0);
            this.PN_Stops.Name = "PN_Stops";
            this.PN_Stops.Size = new System.Drawing.Size(20, 34);
            this.PN_Stops.TabIndex = 0;
            // 
            // LB_Stops
            // 
            this.LB_Stops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Stops.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Stops.ForeColor = System.Drawing.Color.Red;
            this.LB_Stops.Location = new System.Drawing.Point(0, 0);
            this.LB_Stops.Name = "LB_Stops";
            this.LB_Stops.Size = new System.Drawing.Size(20, 34);
            this.LB_Stops.TabIndex = 4;
            this.LB_Stops.Text = "0";
            this.LB_Stops.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Stops.Click += new System.EventHandler(this.LB_Stops_Click);
            // 
            // Player_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.PN_Parent);
            this.Name = "Player_Item";
            this.Size = new System.Drawing.Size(161, 36);
            this.PN_Parent.ResumeLayout(false);
            this.PN_Laps.ResumeLayout(false);
            this.PN_Stops.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PN_Laps;
        private System.Windows.Forms.Label LB_Laps;
        private System.Windows.Forms.Panel PN_Stops;
        private System.Windows.Forms.Label LB_Stops;
        public System.Windows.Forms.Label LB_Username;
        public System.Windows.Forms.Panel PN_Parent;
    }
}
