using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.IO;


namespace Geck
{
 
    public partial class frmMain : Form
    {
        
        Player player = new Player();
        public frmMain()
        {
            InitializeComponent();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numStr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
               
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "G.E.C.K Files (*.geck)|*.geck|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                LoadCharacter(openFileDialog.FileName);

            frmCareer career = new frmCareer(player);

        }

        private void LoadCharacter(string fileName)
        {
            if (File.Exists(fileName) && fileName.EndsWith("geck"))
            {
                Player player = new Player();
                player.FileName = fileName;
                player.Load();
                this.player = player;

                frmCreate frmCharacter = new frmCreate(objCharacter)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized,
                    Loading = true
                };
                frmCharacter.Show();

            }
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRace frmRace = new frmRace();
            frmRace.ShowDialog();
            Player player = frmRace.getPlayer();

            if(frmRace.DialogResult == DialogResult.OK)
            {
                frmSpecial Special = new frmSpecial(player);
                Special.ShowDialog();

                if(Special.DialogResult == DialogResult.OK)
                {
                    frmTag Tag = new frmTag(player);
                    Tag.ShowDialog();

                    if(Tag.DialogResult == DialogResult.OK)
                    {
                        this.player = player;
                    }

                    frmCareer career = new frmCareer(player);
                    career.Show();
                    this.Close();

                }
            }

            
        }

        private void saveCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(player.GetName()))
            {
                MessageBox.Show("You must create a character first!");
            }

            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "G.E.C.K Files (*.geck)|*.geck|All Files (*.*)|*.*";

                string strShowFileName = string.Empty;
                string[] strFile = player.FileName.Split(Path.DirectorySeparatorChar);
                strShowFileName = strFile[strFile.Length - 1];

                if (string.IsNullOrEmpty(strShowFileName))
                    strShowFileName = player.GetName();

                saveFileDialog.FileName = strShowFileName;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    player.FileName = saveFileDialog.FileName;
                    player.Save();
                }
            }

            
                
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
