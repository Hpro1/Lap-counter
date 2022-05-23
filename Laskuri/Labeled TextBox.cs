using System.Windows.Forms;

namespace Laskuri
{
    public partial class Labeled_TextBox : UserControl
    {
        public string Label { get { return LB.Text; } set { LB.Text = value; } }
        public string Texto { get { return TB.Text; } set { TB.Text = value; } }

        public Labeled_TextBox()
        {
            InitializeComponent();
        }
    }
}
