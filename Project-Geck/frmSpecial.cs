using System;
using System.Windows.Forms;

namespace Geck
{
    public partial class frmSpecial : Form
    {
        Player BackupPlayer = new Player();
        Player player = new Player();

        public frmSpecial(Player player1)
        {
            InitializeComponent();
            player = player1;
            lblStr.Text = player.Str.ToString();
            lblPer.Text = player.Per.ToString();
            lblEnd.Text = player.End.ToString();
            lblCha.Text = player.Cha.ToString();
            lblInt.Text = player.Int.ToString();
            lblAgi.Text = player.Agi.ToString();
            lblLuc.Text = player.Luc.ToString();
            lblSpecialPointsRemaining.Text = player1.GetSpecialPoints().ToString();

            if (player.Created)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button11.Enabled = false;
                button13.Enabled = false;
                button15.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void IncStr_Click(object sender, EventArgs e)
        {
            int Strength = player.Str;

            if (player.GetSpecialPoints() > 0 && (player.Str < 10))
            {
                player.Str--;
                player.SpecialPoints -= 1;
            }

            else if (player.Str < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblStr.Text = (player.Str.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void DecStr_Click(object sender, EventArgs e)
        {
            int Strength = player.Str;

            if (player.Str > 1)
            {
                player.Str--;
                player.SpecialPoints += 1;
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblStr.Text = (player.Str.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblStr_Click(object sender, EventArgs e)
        {
            lblStr.Text = player.Str.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int Perception = player.Per;

            if (player.GetSpecialPoints() > 0 && (player.Per < 10))
            {
                player.Per++;
                player.SpecialPoints -= 1;
            }

            else if (player.Per < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblPer.Text = (player.Per.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int Charisma = player.Cha;

            if (player.Cha > 1)
            {
                player.Cha--;
                player.SpecialPoints += 1;
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblCha.Text = (player.Cha.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int Perception = player.Per;

            if (player.Per > 1)
            {
                player.Per--;
                player.SpecialPoints += 1;
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblPer.Text = (player.Per.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int Endurance = player.End;

            if (player.GetSpecialPoints() > 0 && (player.End < 10))
            {
                player.End++;
                player.SpecialPoints -= 1;
            }

            else if (player.End < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblEnd.Text = (player.End.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int Endurance = player.End;

            if (player.End > 1)
            {
                player.End--;
                player.SpecialPoints += 1;
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblEnd.Text = (player.End.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int Charisma = player.Cha;

            if (player.GetSpecialPoints() > 0 && (player.Cha < 10))
            {
                player.Cha++;
                player.SpecialPoints -= 1;
            }

            else if (player.Cha < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblCha.Text = (player.Cha.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int Intelligence = player.Int;

            if (player.Int > 1)
            {
                player.Int--;
                player.SpecialPoints += 1;
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblInt.Text = (player.Int.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int Intelligence = player.Int;

            if (player.GetSpecialPoints() > 0 && (player.Int < 10))
            {
                player.Int++;
                player.SpecialPoints -= 1;
            }

            else if (player.Int < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblInt.Text = (player.Int.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int Agility = player.Agi;

            if (player.Agi > 1)
            {
                player.Agi--;
                player.SpecialPoints += 1;
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblAgi.Text = (player.Agi.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            int Agility = player.Agi;

            if (player.GetSpecialPoints() > 0 && (player.Agi < 10))
            {
                player.Agi++;
                player.SpecialPoints -= 1;
            }

            else if (player.Agi < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblAgi.Text = (player.Agi.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            int Luck = player.Luc;

            if (player.Luc > 1)
            {
                player.Luc--;
                player.SpecialPoints += 1;
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblLuc.Text = (player.Luc.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            int Luck = player.Luc;

            if (player.GetSpecialPoints() > 0 && (player.Luc < 10))
            {
                player.Luc++;
                player.SpecialPoints -= 1;
            }

            else if (player.Luc < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblLuc.Text = (player.Luc.ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(lblSpecialPointsRemaining.Text != "0")
            {
                MessageBox.Show("Please allocate all S.P.E.C.I.A.L points.");
            }

            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
          
        }

       
    }
}