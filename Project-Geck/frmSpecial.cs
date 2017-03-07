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
            lblStr.Text = player.GetAttribute("Str").ToString();
            lblPer.Text = player.GetAttribute("Per").ToString();
            lblEnd.Text = player.GetAttribute("End").ToString();
            lblCha.Text = player.GetAttribute("Cha").ToString();
            lblInt.Text = player.GetAttribute("Int").ToString();
            lblAgi.Text = player.GetAttribute("Agi").ToString();
            lblLuc.Text = player.GetAttribute("Luc").ToString();
            lblSpecialPointsRemaining.Text = player1.GetSpecialPoints().ToString();

            if (player.created)
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
            int Strength = player.GetAttribute("Str");

            if (player.GetSpecialPoints() > 0 && (player.GetAttribute("Str") < 10))
            {
                player.SetAttribute("Str", Strength + 1);
                player.SetSpecialPoints(player.GetSpecialPoints() - 1);
            }

            else if (player.GetAttribute("Str") < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblStr.Text = (player.GetAttribute("Str").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void DecStr_Click(object sender, EventArgs e)
        {
            int Strength = player.GetAttribute("Str");

            if (player.GetAttribute("Str") > 1)
            {
                player.SetAttribute("Str", Strength - 1);
                player.SetSpecialPoints((player.GetSpecialPoints()) + 1);
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblStr.Text = (player.GetAttribute("Str").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblStr_Click(object sender, EventArgs e)
        {
            lblStr.Text = player.GetAttribute("Str").ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int Perception = player.GetAttribute("Per");

            if (player.GetSpecialPoints() > 0 && (player.GetAttribute("Per") < 10))
            {
                player.SetAttribute("Per", Perception + 1);
                player.SetSpecialPoints(player.GetSpecialPoints() - 1);
            }

            else if (player.GetAttribute("Per") < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblPer.Text = (player.GetAttribute("Per").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int Charisma = player.GetAttribute("Cha");

            if (player.GetAttribute("Cha") > 1)
            {
                player.SetAttribute("Cha", Charisma - 1);
                player.SetSpecialPoints((player.GetSpecialPoints()) + 1);
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblCha.Text = (player.GetAttribute("Cha").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int Perception = player.GetAttribute("Per");

            if (player.GetAttribute("Per") > 1)
            {
                player.SetAttribute("Per", Perception - 1);
                player.SetSpecialPoints((player.GetSpecialPoints()) + 1);
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblPer.Text = (player.GetAttribute("Per").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int Endurance = player.GetAttribute("End");

            if (player.GetSpecialPoints() > 0 && (player.GetAttribute("End") < 10))
            {
                player.SetAttribute("End", Endurance + 1);
                player.SetSpecialPoints(player.GetSpecialPoints() - 1);
            }

            else if (player.GetAttribute("End") < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblEnd.Text = (player.GetAttribute("End").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int Endurance = player.GetAttribute("End");

            if (player.GetAttribute("End") > 1)
            {
                player.SetAttribute("End", Endurance - 1);
                player.SetSpecialPoints((player.GetSpecialPoints()) + 1);
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblEnd.Text = (player.GetAttribute("End").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int Charisma = player.GetAttribute("Cha");

            if (player.GetSpecialPoints() > 0 && (player.GetAttribute("Cha") < 10))
            {
                player.SetAttribute("Cha", Charisma + 1);
                player.SetSpecialPoints(player.GetSpecialPoints() - 1);
            }

            else if (player.GetAttribute("Cha") < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblCha.Text = (player.GetAttribute("Cha").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int Intelligence = player.GetAttribute("Int");

            if (player.GetAttribute("Int") > 1)
            {
                player.SetAttribute("Int", Intelligence - 1);
                player.SetSpecialPoints((player.GetSpecialPoints()) + 1);
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblInt.Text = (player.GetAttribute("Int").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int Intelligence = player.GetAttribute("Int");

            if (player.GetSpecialPoints() > 0 && (player.GetAttribute("Int") < 10))
            {
                player.SetAttribute("Int", Intelligence + 1);
                player.SetSpecialPoints(player.GetSpecialPoints() - 1);
            }

            else if (player.GetAttribute("Int") < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblInt.Text = (player.GetAttribute("Int").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int Agility = player.GetAttribute("Agi");

            if (player.GetAttribute("Agi") > 1)
            {
                player.SetAttribute("Agi", Agility - 1);
                player.SetSpecialPoints((player.GetSpecialPoints()) + 1);
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblAgi.Text = (player.GetAttribute("Agi").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            int Agility = player.GetAttribute("Agi");

            if (player.GetSpecialPoints() > 0 && (player.GetAttribute("Agi") < 10))
            {
                player.SetAttribute("Agi", Agility + 1);
                player.SetSpecialPoints(player.GetSpecialPoints() - 1);
            }

            else if (player.GetAttribute("Agi") < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblAgi.Text = (player.GetAttribute("Agi").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            int Luck = player.GetAttribute("Luc");

            if (player.GetAttribute("Luc") > 1)
            {
                player.SetAttribute("Luc", Luck - 1);
                player.SetSpecialPoints((player.GetSpecialPoints()) + 1);
            }


            else
                MessageBox.Show("You can not set an attribute lower than 1");

            lblLuc.Text = (player.GetAttribute("Luc").ToString());
            lblSpecialPointsRemaining.Text = player.GetSpecialPoints().ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            int Luck = player.GetAttribute("Luc");

            if (player.GetSpecialPoints() > 0 && (player.GetAttribute("Luc") < 10))
            {
                player.SetAttribute("Luc", Luck + 1);
                player.SetSpecialPoints(player.GetSpecialPoints() - 1);
            }

            else if (player.GetAttribute("Luc") < 10)
                MessageBox.Show("You have no remaining SPECIAL points");

            lblLuc.Text = (player.GetAttribute("Luc").ToString());
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