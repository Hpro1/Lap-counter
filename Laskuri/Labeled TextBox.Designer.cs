namespace Laskuri
{
    partial class Labeled_TextBox
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
            this.TB = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB.Location = new System.Drawing.Point(0, 27);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(193, 33);
            this.TB.TabIndex = 0;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.ForeColor = System.Drawing.Color.White;
            this.LB.Location = new System.Drawing.Point(0, -3);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(47, 21);
            this.LB.TabIndex = 1;
            this.LB.Text = "Label";
            // 
            // Labeled_TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.LB);
            this.Controls.Add(this.TB);
            this.Name = "Labeled_TextBox";
            this.Size = new System.Drawing.Size(193, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Label LB;
    }
}
