using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geck
{
    public partial class frmAddXP : Form
    {
        Player player;
        public frmAddXP(Player player)
        {
            this.player = player;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == String.Empty)
                Close();

            int xpToAdd = Convert.ToInt32(textBox1.Text);
            player.XP += xpToAdd;
            this.DialogResult = DialogResult.OK;
            Close();
   
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
