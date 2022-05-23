using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskuri
{
    public partial class Fluent_Button : System.Windows.Forms.Button
    {
        private Color OuterBorderColor;
        private Color InnerBorderColor;
        private Color CurrentBackColor;

        public Fluent_Button()
        {
            BackColor = Color.FromArgb(204, 204, 204);
            Font = new Font("Segoe UI", 11f);
            CurrentBackColor = BackColor;
            OuterBorderColor = BackColor;
            InnerBorderColor = BackColor;
            ForeColor = Color.Black;
            Height = 32;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            OuterBorderColor = Color.FromArgb(122, 122, 122);
            InnerBorderColor = OuterBorderColor;
            CurrentBackColor = BackColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            OuterBorderColor = BackColor;
            InnerBorderColor = BackColor;
            CurrentBackColor = BackColor;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(OuterBorderColor), 0, 0, Width, Height);
            pevent.Graphics.FillRectangle(new SolidBrush(InnerBorderColor), 1, 1, Width - 2, Height - 2);
            pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 2, 2, Width - 4, Height - 4);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
            if (Enabled) return;
            pevent.Graphics.Clear(Color.FromArgb(235, 235, 235));
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), Color.FromArgb(191, 191, 191), flags);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            OuterBorderColor = Color.FromArgb(122, 122, 122);
            InnerBorderColor = OuterBorderColor;
            CurrentBackColor = BackColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            OuterBorderColor = Color.FromArgb(192, 192, 192);
            InnerBorderColor = Color.FromArgb(153, 153, 153);
            CurrentBackColor = Color.FromArgb(153, 153, 153);
            Invalidate();
        }
    }
}
