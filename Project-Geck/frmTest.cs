using System;
using System.Windows.Forms;

namespace Geck
{
    public partial class frmTest : Form
    {
        public frmTest(Player player)
        {
            
            InitializeComponent();
            numericUpDown1.Value = 1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (Convert.ToInt32(num.Text) > num.Value)
                MessageBox.Show("Value decreased");
            else
                MessageBox.Show("Value increased");
        }
    }
}
