namespace Geck
{
    partial class frmCareer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCareer));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tabCharacterTabs = new System.Windows.Forms.TabControl();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabOtherInfo = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabCharacterTabs.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitMain.Location = new System.Drawing.Point(1, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitMain.Panel1.Controls.Add(this.tabCharacterTabs);
            this.splitMain.Panel1MinSize = 849;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitMain.Panel2.Controls.Add(this.tabInfo);
            this.splitMain.Size = new System.Drawing.Size(1059, 637);
            this.splitMain.SplitterDistance = 879;
            this.splitMain.TabIndex = 55;
            // 
            // tabCharacterTabs
            // 
            this.tabCharacterTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCharacterTabs.Controls.Add(this.tabCommon);
            this.tabCharacterTabs.Controls.Add(this.tabSkills);
            this.tabCharacterTabs.Controls.Add(this.tabPage1);
            this.tabCharacterTabs.ItemSize = new System.Drawing.Size(42, 18);
            this.tabCharacterTabs.Location = new System.Drawing.Point(0, 0);
            this.tabCharacterTabs.Name = "tabCharacterTabs";
            this.tabCharacterTabs.SelectedIndex = 0;
            this.tabCharacterTabs.Size = new System.Drawing.Size(876, 634);
            this.tabCharacterTabs.TabIndex = 33;
            this.tabCharacterTabs.Tag = "";
            // 
            // tabCommon
            // 
            this.tabCommon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabCommon.Controls.Add(this.tabControl1);
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(868, 608);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Tag = "Tab_Common";
            this.tabCommon.Text = "Stats";
            // 
            // tabSkills
            // 
            this.tabSkills.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Size = new System.Drawing.Size(868, 608);
            this.tabSkills.TabIndex = 17;
            this.tabSkills.Tag = "Tab_Skills";
            this.tabSkills.Text = "Items";
            // 
            // tabInfo
            // 
            this.tabInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInfo.Controls.Add(this.tabOtherInfo);
            this.tabInfo.Location = new System.Drawing.Point(0, 0);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(176, 634);
            this.tabInfo.TabIndex = 50;
            // 
            // tabOtherInfo
            // 
            this.tabOtherInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabOtherInfo.Location = new System.Drawing.Point(4, 22);
            this.tabOtherInfo.Name = "tabOtherInfo";
            this.tabOtherInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherInfo.Size = new System.Drawing.Size(168, 608);
            this.tabOtherInfo.TabIndex = 1;
            this.tabOtherInfo.Tag = "Tab_OtherInfo";
            this.tabOtherInfo.Text = "Quick Stats";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 608);
            this.tabPage1.TabIndex = 18;
            this.tabPage1.Text = "Data";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabStatus);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStatus
            // 
            this.tabStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabStatus.Controls.Add(this.lblHP);
            this.tabStatus.Controls.Add(this.progressBar2);
            this.tabStatus.Controls.Add(this.progressBar1);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(857, 576);
            this.tabStatus.TabIndex = 0;
            this.tabStatus.Text = "Status";
            this.tabStatus.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(857, 576);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 28);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(518, 28);
            this.progressBar2.MarqueeAnimationSpeed = 10;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(317, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(158, 12);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(35, 13);
            this.lblHP.TabIndex = 2;
            this.lblHP.Text = "label1";
            // 
            // frmCareer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 635);
            this.ControlBox = false;
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCareer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Garden of Eden Creation Kit";
            this.Load += new System.EventHandler(this.frmCareer_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabCharacterTabs.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabOtherInfo;
        private System.Windows.Forms.TabControl tabCharacterTabs;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}