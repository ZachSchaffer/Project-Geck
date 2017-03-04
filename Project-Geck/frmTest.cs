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
    public partial class frmTest : Form
    {
        public frmTest(Player player)
        {
            InitializeComponent();

            foreach (String i in player.GetSkillReport())
                richTextBox1.Text += "\n"+i;

            foreach (Perk i in player.GetAllPerks())
                richTextBox1.Text += "\n" + i.GetName();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
