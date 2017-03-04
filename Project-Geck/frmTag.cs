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
    public partial class frmTag : Form
    {

        int selected = 0;
        Player player = new Player();

        public frmTag(Player player1)
        {
            InitializeComponent();
            player = player1;
            label15.Text = ((int)(((2 + (player1.GetAttribute("Cha") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Barter
            label16.Text = ((int)(((2 + (player1.GetAttribute("Per") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //EW
            label17.Text = ((int)(((2 + (player1.GetAttribute("Per") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Explosives
            label18.Text = ((int)(((2 + (player1.GetAttribute("Agi") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Guns
            label19.Text = ((int)(((2 + (player1.GetAttribute("Per") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Lockpick
            label20.Text = ((int)(((2 + (player1.GetAttribute("Int") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Medicine
            label21.Text = ((int)(((2 + (player1.GetAttribute("Str") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //MW
            label22.Text = ((int)(((2 + (player1.GetAttribute("Int") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Repair
            label23.Text = ((int)(((2 + (player1.GetAttribute("Int") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Science
            label24.Text = ((int)(((2 + (player1.GetAttribute("Agi") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Sneak
            label25.Text = ((int)(((2 + (player1.GetAttribute("Cha") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Speech
            label26.Text = ((int)(((2 + (player1.GetAttribute("End") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Survival
            label27.Text = ((int)(((2 + (player1.GetAttribute("End") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString(); //Unarmed
            player.SetAttribute("Barter", ((int)(((2 + (player1.GetAttribute("Cha") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("EW", ((int)(((2 + (player1.GetAttribute("Per") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Explosives", ((int)(((2 + (player1.GetAttribute("Per") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Guns", ((int)(((2 + (player1.GetAttribute("Agi") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Lockpick", ((int)(((2 + (player1.GetAttribute("Per") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Medicine", ((int)(((2 + (player1.GetAttribute("Int") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("MW", ((int)(((2 + (player1.GetAttribute("Str") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Repair", ((int)(((2 + (player1.GetAttribute("Int") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Science", ((int)(((2 + (player1.GetAttribute("Int") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Sneak", ((int)(((2 + (player1.GetAttribute("Agi") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Speech", ((int)(((2 + (player1.GetAttribute("Cha") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Survival", ((int)(((2 + (player1.GetAttribute("End") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));
            player.SetAttribute("Unarmed", ((int)(((2 + (player1.GetAttribute("End") * 2) + Math.Round(((decimal)player1.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))));

            if(player.GetRace().Equals("Nightkin"))
            {
                player.SetAttribute("Guns", 30);
                player.SetAttribute("Sneak", 30);
                label18.Text = "30";
                label24.Text = "30";

            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTag_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            selected++;

            checkBox1.Enabled = false;
            if(selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label15.Text = ((int)(((2 + (player.GetAttribute("Cha") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                selected++;

            checkBox2.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

           
            label16.Text = ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                selected++;

            checkBox3.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

        
            label17.Text = ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                selected++;

            checkBox4.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label18.Text = ((int)(((2 + (player.GetAttribute("Agi") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();

            if (player.GetRace().Equals("Nightkin"))
            {
                label18.Text = "45";

            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                selected++;

            checkBox5.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label19.Text = ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                selected++;

            checkBox6.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label20.Text = ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                selected++;

            checkBox7.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label21.Text = ((int)(((2 + (player.GetAttribute("Str") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                selected++;

            checkBox8.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label22.Text = ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                selected++;

            checkBox9.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label23.Text = ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
                selected++;

            checkBox10.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label24.Text = ((int)(((2 + (player.GetAttribute("Agi") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();

            if (player.GetRace().Equals("Nightkin"))
            {
                label24.Text = "45";

            }

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox11.Checked)
            selected++;

            checkBox11.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label25.Text = ((int)(((2 + (player.GetAttribute("Cha") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
                selected++;
            checkBox12.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label26.Text = ((int)(((2 + (player.GetAttribute("End") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
                selected++;

            checkBox13.Enabled = false;

            if (selected == 3)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
            }

            label27.Text = ((int)(((2 + (player.GetAttribute("End") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero)))) + 15).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            checkBox11.Enabled = true;
            checkBox12.Enabled = true;
            checkBox13.Enabled = true;
            label15.Text = ((int)(((2 + (player.GetAttribute("Cha") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label16.Text = ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label17.Text = ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label18.Text = ((int)(((2 + (player.GetAttribute("Agi") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label19.Text = ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label20.Text = ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label21.Text = ((int)(((2 + (player.GetAttribute("Str") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label22.Text = ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label23.Text = ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label24.Text = ((int)(((2 + (player.GetAttribute("Agi") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label25.Text = ((int)(((2 + (player.GetAttribute("Cha") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label26.Text = ((int)(((2 + (player.GetAttribute("End") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();
            label27.Text = ((int)(((2 + (player.GetAttribute("End") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))).ToString();

            if (player.GetRace().Equals("Nightkin"))
            {
                label18.Text = "30";
                label24.Text = "30";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected == 3)
            {
                if (checkBox1.Checked)
                {
                    player.SetAttribute("Barter", ((int)(((2 + (player.GetAttribute("Cha") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.BarterTagged = true;
                }

                if (checkBox2.Checked)
                {
                    player.SetAttribute("EW", ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.EWTagged = true;
                }

                if (checkBox3.Checked)
                {
                    player.SetAttribute("Explosives", ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.ExplosivesTagged = true;
                }
                    

                if (checkBox4.Checked)
                {
                    player.SetAttribute("Guns", ((int)(((2 + (player.GetAttribute("Agi") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.GunsTagged = true;

                    if (player.GetRace().Equals("Nightkin"))
                    {
                        player.SetAttribute("Guns", 45);
                    }
                }
                

                if (checkBox5.Checked)
                {
                    player.SetAttribute("Lockpick", ((int)(((2 + (player.GetAttribute("Per") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.LockpickTagged = true;
                }
                    

                if (checkBox6.Checked)
                {
                    player.SetAttribute("Medicine", ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.MedicineTagged = true;
                }
                    

                if (checkBox7.Checked)
                {
                    player.SetAttribute("MW", ((int)(((2 + (player.GetAttribute("Str") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.MWTagged = true;
                }
                   

                if (checkBox8.Checked)
                {
                    player.SetAttribute("Repair", ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.RepairTagged = true;
                }
                    

                if (checkBox9.Checked)
                {
                    player.SetAttribute("Science", ((int)(((2 + (player.GetAttribute("Int") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.ScienceTagged = true;
                }
                   

                if (checkBox10.Checked)
                {
                    player.SetAttribute("Sneak", ((int)(((2 + (player.GetAttribute("Agi") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.SneakTagged = true;

                    if (player.GetRace().Equals("Nightkin"))
                    {
                        player.SetAttribute("Sneak", 45);

                    }
                }
                   

                if (checkBox11.Checked)
                {
                    player.SetAttribute("Speech", ((int)(((2 + (player.GetAttribute("Cha") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.SpeechTagged = true;
                }
                    

                if (checkBox12.Checked)
                {
                    player.SetAttribute("Survival", ((int)(((2 + (player.GetAttribute("End") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.SurvivalTagged = true;
                }
                   

                if (checkBox13.Checked)
                {
                    player.SetAttribute("Unarmed", ((int)(((2 + (player.GetAttribute("End") * 2) + Math.Round(((decimal)player.GetAttribute("Luc") / 2), MidpointRounding.AwayFromZero))))) + 15);
                    player.UnarmedTagged = true;
                }
                    

                DialogResult = DialogResult.OK;
                Close();
            }

            else
                MessageBox.Show("You must select 3 Tag skills.");

            

        }
    }
}
