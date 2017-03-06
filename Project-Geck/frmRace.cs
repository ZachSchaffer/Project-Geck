using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Geck
{
    public partial class frmRace : Form
    {
        Player player = new Player();
        int[] finalspec = new int[7];
        List<Perk> finalperks = new List<Perk>();
        
        public frmRace()
        {
            InitializeComponent();
        }

        private void Race_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Select();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            List<String> mods = new List<String>();

            if (comboBox1.SelectedIndex == 0)
            {
                int[] special = { 5, 5, 5, 5, 5, 5, 5 };
                label8.Text = special[0].ToString();
                label9.Text = special[1].ToString();
                label10.Text = special[2].ToString();
                label11.Text = special[3].ToString();
                label12.Text = special[4].ToString();
                label13.Text = special[5].ToString();
                label14.Text = special[6].ToString();
                mods.Add("");
                finalspec = special;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                //listBox1.SelectedIndex = 0;

                if (listBox1.SelectedIndex == 0)
                {
                    int[] special = { 4, 6, 6, 2, 5, 4, 6 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Ghoulified");
                    mods.Add("One of Us");
                    mods.Add("\"Zombie!\"");
                    finalspec = special;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    int[] special = { 4, 6, 7, 2, 4, 3, 7 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Freak of Nature");
                    finalspec = special;
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {

                if (listBox1.SelectedIndex == 0)
                {
                    int[] special = { 7, 4, 7, 3, 5, 5, 4 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Vault Educated");
                    mods.Add("Stigmatized");
                    finalspec = special;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    int[] special = { 8, 4, 8, 3, 2, 3, 4 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Brawler");
                    mods.Add("Brutish");
                    finalspec = special;
                }

                if (listBox1.SelectedIndex == 2)
                {
                    int[] special = { 9, 3, 9, 1, 7, 7, 4 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Schizophrenic");
                    mods.Add("Super Soldier");
                    finalspec = special;
                }

            }
            listBox2.DataSource = mods;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int[] special = new int[6];
            List<String> variants = new List<String>();
            List<String> mods = new List<String>();
            
            if (comboBox1.SelectedIndex == 0)
            {
                variants.Add("African American");
                variants.Add("Asian");
                variants.Add("Caucasian");
                variants.Add("Hispanic");
                int[] special = {5, 5, 5, 5, 5, 5, 5};
                label8.Text = special[0].ToString();
                label9.Text = special[1].ToString();
                label10.Text = special[2].ToString();
                label11.Text = special[3].ToString();
                label12.Text = special[4].ToString();
                label13.Text = special[5].ToString();
                label14.Text = special[6].ToString();
                mods.Add("");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                variants.Add("Ghoul");
                variants.Add("Glowing One");
                listBox1.SelectedIndex = 0;

                if (listBox1.SelectedIndex == 0)
                {
                    int[] special = { 4, 6, 6, 2, 5, 4, 6 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Ghoulified");
                    mods.Add("One of Us");
                   
                }

                if (listBox1.SelectedIndex == 1)
                {
                    int[] special = { 4, 6, 7, 2, 4, 3, 7 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Freak of Nature");
                }
            }

            if(comboBox1.SelectedIndex == 2)
            { 
                variants.Add("First Generation");
                variants.Add("Second Generation");
                variants.Add("Nightkin");
                listBox1.SelectedIndex = 0;

                if(listBox1.SelectedIndex == 0)
                {
                    int[] special = { 7, 4, 7, 3, 5, 5, 4 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Vault Educated");
                    mods.Add("Stigmatized");
                }

                if(listBox1.SelectedIndex == 1)
                {
                    int[] special = { 8, 4, 8, 3, 2, 3, 4 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Brawler");
                    mods.Add("Brutish");
                }

                if (listBox1.SelectedIndex == 2)
                {
                    int[] special = { 9, 3, 9, 1, 7, 7, 4 };
                    label8.Text = special[0].ToString();
                    label9.Text = special[1].ToString();
                    label10.Text = special[2].ToString();
                    label11.Text = special[3].ToString();
                    label12.Text = special[4].ToString();
                    label13.Text = special[5].ToString();
                    label14.Text = special[6].ToString();
                    mods.Add("Schizophrenic");
                    mods.Add("Super Soldier");
                }

            }

            listBox1.DataSource = variants;
            listBox2.DataSource = mods;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Player getPlayer()
        {
            player.SetAttribute("Str", finalspec[0]);
            player.SetAttribute("Per", finalspec[1]);
            player.SetAttribute("End", finalspec[2]);
            player.SetAttribute("Cha", finalspec[3]);
            player.SetAttribute("Int", finalspec[4]);
            player.SetAttribute("Agi", finalspec[5]);
            player.SetAttribute("Luc", finalspec[6]);
            player.Name = (textBox1.Text);

            if (radioButton1.Checked)
                player.Gender=("Male");

            if (radioButton2.Checked)
                player.Gender=("Female");


            if(comboBox1.SelectedIndex == 0)
            {
                if (listBox1.SelectedIndex == 0)
                    player.Race=("African American");

                if (listBox1.SelectedIndex == 1)
                    player.Race=("Asian");

                if (listBox1.SelectedIndex == 2)
                    player.Race=("Caucasian");

                if (listBox1.SelectedIndex == 3)
                    player.Race=("Hispanic");
            }


            if (comboBox1.SelectedIndex == 1)
            {

                if (listBox1.SelectedIndex == 0)
                {
                    player.AddPerk(81);
                    player.AddPerk(82);
                    player.AddPerk(83);
                    player.Race=("Ghoul");

                }

                if (listBox1.SelectedIndex == 1)
                {
                    player.AddPerk(84);
                    player.Race=("Glowing One");
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {

                if (listBox1.SelectedIndex == 0)
                {
                    player.AddPerk(85);
                    player.AddPerk(86);
                    player.Race=("First Generation Super Mutant");
                }

                if (listBox1.SelectedIndex == 1)
                {
                    player.AddPerk(87);
                    player.AddPerk(88);
                    player.Race=("Second Generation Super Mutant");
                }

                if (listBox1.SelectedIndex == 2)
                {                
                    player.AddPerk(89);
                    player.AddPerk(90);
                    player.Race=("Nightkin");
                }
                
            }

            return player;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please name your character.");
            }

            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
               
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
