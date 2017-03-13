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
            UpdateCharacter();
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
            //TODO: figure out how AP is gonna work
            lblXP.Text = (player.GetAttribute("XP").ToString());
            lblLevel.Text = (player.GetAttribute("Level").ToString());

            lblStr.Text = (player.GetAttribute("Str").ToString());



        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLevelUp LevelUp = new frmLevelUp(player);
            LevelUp.Show();

            if (LevelUp.DialogResult == DialogResult.OK)
                UpdateCharacter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddXP AddXP = new frmAddXP(player);
            AddXP.Show();

            if (DialogResult == DialogResult.OK)
                UpdateCharacter();
        }
    }
}
