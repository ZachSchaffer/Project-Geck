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
            UpdateCharacterInfo();
        }

        private void FrmCareer_Load(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
         
        }

        public void UpdateCharacterInfo()
        {
            lblHP.Text = (player.HP + " / " + player.MaxHP);
            //TODO: figure out how AP is gonna work


            lblXP.Text = (player.XP + " / " + player.XpToNextLevel);

            lblLevel.Text = (player.Level.ToString());

            lblStr.Text = (player.Str.ToString());

            lblPer.Text = (player.Per.ToString());

            lblEnd.Text = (player.End.ToString());

            lblCha.Text = (player.Cha.ToString());

            lblInt.Text = (player.Int.ToString());

            lblAgi.Text = (player.Agi.ToString());

            lblLuc.Text = (player.Luc.ToString());

            lblBarter.Text = (player.Barter.ToString());

            lblEW.Text = (player.End.ToString());

            lblExplosives.Text = (player.Explosives.ToString());

            lblGuns.Text = (player.Guns.ToString());

            lblLockpick.Text = (player.Lockpick.ToString());

            lblMedicine.Text = (player.Medicine.ToString());

            lblMW.Text = (player.Melee_Weapons.ToString());

            lblRepair.Text = (player.Repair.ToString());

            lblScience.Text = (player.Science.ToString());

            lblSneak.Text = (player.Sneak.ToString());

            lblSpeech.Text = (player.Speech.ToString());

            lblSurvival.Text = (player.Survival.ToString());

            lblUnarmed.Text = (player.Unarmed.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player.HP + addHP.Value <= player.MaxHP)
                player.HP += (int)addHP.Value;

            else
                MessageBox.Show("You cannot increase your HP past its maximum value.");
            UpdateCharacterInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLevelUp_Click(object sender, EventArgs e)
        {
            frmLevelUp LevelUp = new frmLevelUp(player);
            LevelUp.Show();

            if (LevelUp.DialogResult == DialogResult.OK)
                UpdateCharacterInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int levelcount = 0;
            int remainingXP = 0;
            int backupXP = player.XP;
            int backupLvl = player.Level;


            if (player.XP + addXP.Value < player.XpToNextLevel)
                player.XP += (int)addXP.Value;

            else
            {
                for (int i = (int)addXP.Value + player.XP; i >= player.XpToNextLevel; i -= player.XpToNextLevel)
                {
                    levelcount++;
                    remainingXP = i;
                }

                DialogResult result = MessageBox.Show("Adding this amount of XP will increase your level " + levelcount + " time(s). Are you sure you want to level up?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    while(levelcount > 0)
                    {
                        frmLevelUp frmlvl = new frmLevelUp(player);
                        frmlvl.ShowDialog();
                        
                        if(frmlvl.DialogResult == DialogResult.OK)
                        {
                            levelcount--;
                        }
                        else
                        {
                            MessageBox.Show("Changes will be rolled back.");
                            remainingXP = backupXP;
                            player.Level = backupLvl;
                            levelcount = 0;
                        }

                    }

                    //TODO: if option reset xp on level is not checked
                    player.XP = (int)(remainingXP);
                }

            }

            addXP.Value = 0;
            UpdateCharacterInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player.HP - addHP.Value >= 0)
                player.HP -= (int)addHP.Value;

            else
                MessageBox.Show("You cannot decrease your HP below 0.");
            UpdateCharacterInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player.XP - addXP.Value >= 0)
                player.XP -= (int)addXP.Value;

            else
                MessageBox.Show("You cannot decrease your XP below 0.");
            UpdateCharacterInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to max your HP?", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            player.HP = player.MaxHP;

            UpdateCharacterInfo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like toset your HP to 1?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                player.HP = 1;

            UpdateCharacterInfo();
        }

    }
}
