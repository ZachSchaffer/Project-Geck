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
    public partial class frmLevelUp : Form
    {

        Player player;
        List<Perk> perkQueue = new List<Perk>();

        //I need a better fix for this, but when the form initializes, it runs through each method it seems, which decrements skill points. So, for now I am doing this sloppy workaround
        bool firstPass = true;

        public frmLevelUp(Player player1)
        {

            //There is still issues with storing the previous things to roll back, either redo it or make new variables in player
            this.player = player1;
            InitializeComponent();
            lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            numericUpDown1.Value = player.GetAttribute("Barter");
            numericUpDown2.Value = player.GetAttribute("EW");
            numericUpDown3.Value = player.GetAttribute("Explosives");
            numericUpDown4.Value = player.GetAttribute("Guns");
            numericUpDown5.Value = player.GetAttribute("Lockpick");
            numericUpDown6.Value = player.GetAttribute("Medicine");
            numericUpDown7.Value = player.GetAttribute("MW");
            numericUpDown8.Value = player.GetAttribute("Repair");
            numericUpDown9.Value = player.GetAttribute("Science");
            numericUpDown10.Value = player.GetAttribute("Sneak");
            numericUpDown11.Value = player.GetAttribute("Speech");
            numericUpDown12.Value = player.GetAttribute("Survival");
            numericUpDown13.Value = player.GetAttribute("Unarmed");
            numericUpDown1.Minimum = player.GetAttribute("Barter");
            numericUpDown2.Minimum = player.GetAttribute("EW");
            numericUpDown3.Minimum = player.GetAttribute("Explosives");
            numericUpDown4.Minimum = player.GetAttribute("Guns");
            numericUpDown5.Minimum = player.GetAttribute("Lockpick");
            numericUpDown6.Minimum = player.GetAttribute("Medicine");
            numericUpDown7.Minimum = player.GetAttribute("MW");
            numericUpDown8.Minimum = player.GetAttribute("Repair");
            numericUpDown9.Minimum = player.GetAttribute("Science");
            numericUpDown10.Minimum = player.GetAttribute("Sneak");
            numericUpDown11.Minimum = player.GetAttribute("Speech");
            numericUpDown12.Minimum = player.GetAttribute("Survival");
            numericUpDown13.Minimum = player.GetAttribute("Unarmed");

            foreach (Perk i in player.Perklist)
            {
                if (!(i.Racial) && !(i.Name.Equals("error")) && !i.Taken)
                    listBox1.Items.Add(i.Name);

            }

            foreach(Perk i in player.Playerperks)
            {
                if (!i.Racial && !i.Name.Equals("error"))
                    listBox2.Items.Add(i.GetName());
            }
                

            //this can probably be done better and is probably bad coding practice but eh
            firstPass = false;

        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void frmLevelUp_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;
          
            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }


            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown num = sender as NumericUpDown;

            if ((Convert.ToInt32(num.Text) > num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") + 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

            if ((Convert.ToInt32(num.Text) < num.Value) && !firstPass)
            {
                player.SetAttribute("Skill_Points", player.GetAttribute("Skill_Points") - 1);
                lblSkillPoints.Text = player.GetAttribute("Skill_Points").ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player.GetAttribute("Skill_Points") == 0)
            {
                player.Barter = (int)numericUpDown1.Value;
                player.Energy_Weapons = (int)numericUpDown2.Value;
                player.Explosives = (int)numericUpDown3.Value;
                player.Guns = (int)numericUpDown4.Value;
                player.Lockpick = (int)numericUpDown5.Value;
                player.Medicine = (int)numericUpDown6.Value;
                player.Melee_Weapons = (int)numericUpDown7.Value;
                player.Repair = (int)numericUpDown8.Value;
                player.Science = (int)numericUpDown9.Value;
                player.Sneak = (int)numericUpDown10.Value;
                player.Speech = (int)numericUpDown11.Value;
                player.Survival = (int)numericUpDown12.Value;
                player.Unarmed = (int)numericUpDown13.Value;
                foreach(Perk i in perkQueue)
                {
                    player.AddPerk(i.Name);

                }
                player.Level++;
                DialogResult = DialogResult.OK;
                Close();
            }

            else if (player.GetAttribute("Skill_Points") < 0)
                MessageBox.Show("You cannot have negative skill points remaining.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to take " + listBox1.SelectedItem + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                perkQueue.Add(player.GetPerk(listBox1.SelectedItem.ToString()));
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(listBox1.SelectedItem != null)
                richTextBox1.Text = (player.GetPerk(listBox1.SelectedItem.ToString()).GetName() + ":\n" + player.GetPerk(listBox1.SelectedItem.ToString()).Definition);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
                richTextBox1.Text = (player.GetPerk(listBox2.SelectedItem.ToString()).GetName() + ":\n" + player.GetPerk(listBox2.SelectedItem.ToString()).Definition);
        }
    }
}
