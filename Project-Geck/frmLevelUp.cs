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

        //I need a better fix for this, but when the form initializes, it runs through each method it seems, which decrements skill points. So, for now I am doing this sloppy workaround
        bool firstPass = true;

        public frmLevelUp(Player player)
        {
            this.player = player;
            InitializeComponent();
            lblSkillPoints.Text = this.player.GetAttribute("Skill_Points").ToString();
            numericUpDown1.Value = this.player.GetAttribute("Barter");
            numericUpDown2.Value = this.player.GetAttribute("EW");
            numericUpDown3.Value = this.player.GetAttribute("Explosives");
            numericUpDown4.Value = this.player.GetAttribute("Guns");
            numericUpDown5.Value = this.player.GetAttribute("Lockpick");
            numericUpDown6.Value = this.player.GetAttribute("Medicine");
            numericUpDown7.Value = this.player.GetAttribute("MW");
            numericUpDown8.Value = this.player.GetAttribute("Repair");
            numericUpDown9.Value = this.player.GetAttribute("Science");
            numericUpDown10.Value = this.player.GetAttribute("Sneak");
            numericUpDown11.Value = this.player.GetAttribute("Speech");
            numericUpDown12.Value = this.player.GetAttribute("Survival");
            numericUpDown13.Value = this.player.GetAttribute("Unarmed");
            numericUpDown1.Minimum = this.player.GetAttribute("Barter");
            numericUpDown2.Minimum = this.player.GetAttribute("EW");
            numericUpDown3.Minimum = this.player.GetAttribute("Explosives");
            numericUpDown4.Minimum = this.player.GetAttribute("Guns");
            numericUpDown5.Minimum = this.player.GetAttribute("Lockpick");
            numericUpDown6.Minimum = this.player.GetAttribute("Medicine");
            numericUpDown7.Minimum = this.player.GetAttribute("MW");
            numericUpDown8.Minimum = this.player.GetAttribute("Repair");
            numericUpDown9.Minimum = this.player.GetAttribute("Science");
            numericUpDown10.Minimum = this.player.GetAttribute("Sneak");
            numericUpDown11.Minimum = this.player.GetAttribute("Speech");
            numericUpDown12.Minimum = this.player.GetAttribute("Survival");
            numericUpDown13.Minimum = this.player.GetAttribute("Unarmed");
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
                player.SetAttribute("Barter", (int)numericUpDown1.Value);
                player.SetAttribute("EW", (int)numericUpDown2.Value);
                player.SetAttribute("Explosives", (int)numericUpDown3.Value);
                player.SetAttribute("Guns", (int)numericUpDown4.Value);
                player.SetAttribute("Lockpick", (int)numericUpDown5.Value);
                player.SetAttribute("Medicine", (int)numericUpDown6.Value);
                player.SetAttribute("MW", (int)numericUpDown7.Value);
                player.SetAttribute("Repair", (int)numericUpDown8.Value);
                player.SetAttribute("Science", (int)numericUpDown9.Value);
                player.SetAttribute("Sneak", (int)numericUpDown10.Value);
                player.SetAttribute("Speech", (int)numericUpDown11.Value);
                player.SetAttribute("Survival", (int)numericUpDown12.Value);
                player.SetAttribute("Unarmed", (int)numericUpDown13.Value);

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
    }
}
