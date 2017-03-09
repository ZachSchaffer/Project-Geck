using System;
using System.Windows.Forms;

namespace Geck
{
    public partial class FrmCareer : Form
    {

        Player player = new Player();

        public FrmCareer(Player player)
        {
            this.player = player;
            InitializeComponent();
            
        }

        private void FrmCareer_Load(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
         
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabGeneral_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        public void UpdateCharacter()
        {
            lblHP.Text = (player.GetAttribute("HP").ToString() + " / " + player.GetAttribute("maxHP"));
        }
    }
}
