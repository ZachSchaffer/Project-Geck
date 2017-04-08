using System;
using System.ComponentModel;
using System.Windows.Forms;
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

        private void FILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void NumStr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
         
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
               
        }

        private void LoadCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "G.E.C.K Files (*.geck)|*.geck|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                LoadCharacter(openFileDialog.FileName);

            FrmCareer career = new FrmCareer(player);

        }

        private void LoadCharacter(string fileName)
        {
            if (File.Exists(fileName) && fileName.EndsWith("geck"))
            {
                Player player = new Player()
                {
                    FileName = fileName
                };
                player.Load();
                this.player = player;

                FrmCareer career = new FrmCareer(player)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };

                if(player.Created)
                career.Show();

            }
           
        }

        private void NewCharacterToolStripMenuItem_Click(object sender, EventArgs e)
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
                        player.Created = true;

                        FrmCareer career = new FrmCareer(player)
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };

                        career.Show();

                    }



                }
            }

            
        }

        private void SaveCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(player.Name))
            {
                MessageBox.Show("You must create a character first!");
            }

            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "G.E.C.K Files (*.geck)|*.geck|All Files (*.*)|*.*"
                };
                string strShowFileName = string.Empty;
                string[] strFile = player.FileName.Split(Path.DirectorySeparatorChar);
                strShowFileName = strFile[strFile.Length - 1];

                if (string.IsNullOrEmpty(strShowFileName))
                    strShowFileName = player.Name;

                saveFileDialog.FileName = strShowFileName;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    player.FileName = saveFileDialog.FileName;
                    player.Save();
                }
            }

            
                
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
