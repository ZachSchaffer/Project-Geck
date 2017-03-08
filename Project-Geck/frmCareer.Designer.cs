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
            this.tabControlStats = new System.Windows.Forms.TabControl();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabSpecial = new System.Windows.Forms.TabPage();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabOtherInfo = new System.Windows.Forms.TabPage();
            this.tabControlItems = new System.Windows.Forms.TabControl();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.tabApparel = new System.Windows.Forms.TabPage();
            this.tabAid = new System.Windows.Forms.TabPage();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.tabAmmo = new System.Windows.Forms.TabPage();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabPerks = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabCharacterTabs.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabControlStats.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabControlItems.SuspendLayout();
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
            this.tabCharacterTabs.Controls.Add(this.tabPage);
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
            this.tabCommon.Controls.Add(this.tabControlStats);
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(868, 608);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Tag = "Tab_Common";
            this.tabCommon.Text = "Stats";
            // 
            // tabControlStats
            // 
            this.tabControlStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlStats.Controls.Add(this.tabStatus);
            this.tabControlStats.Controls.Add(this.tabSpecial);
            this.tabControlStats.Controls.Add(this.tabSkills);
            this.tabControlStats.Controls.Add(this.tabPerks);
            this.tabControlStats.Controls.Add(this.tabGeneral);
            this.tabControlStats.Location = new System.Drawing.Point(3, 0);
            this.tabControlStats.Name = "tabControlStats";
            this.tabControlStats.SelectedIndex = 0;
            this.tabControlStats.Size = new System.Drawing.Size(865, 602);
            this.tabControlStats.TabIndex = 0;
            // 
            // tabStatus
            // 
            this.tabStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabStatus.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
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
            // progressBar2
            // 
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(518, 28);
            this.progressBar2.MarqueeAnimationSpeed = 10;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(317, 23);
            this.progressBar2.TabIndex = 1;
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
            // tabSpecial
            // 
            this.tabSpecial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSpecial.Location = new System.Drawing.Point(4, 22);
            this.tabSpecial.Name = "tabSpecial";
            this.tabSpecial.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecial.Size = new System.Drawing.Size(857, 576);
            this.tabSpecial.TabIndex = 1;
            this.tabSpecial.Text = "S.P.E.C.I.A.L";
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage.Controls.Add(this.tabControlItems);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Size = new System.Drawing.Size(868, 608);
            this.tabPage.TabIndex = 17;
            this.tabPage.Tag = "Tab_Skills";
            this.tabPage.Text = "Items";
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
            // tabControlItems
            // 
            this.tabControlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlItems.Controls.Add(this.tabWeapons);
            this.tabControlItems.Controls.Add(this.tabApparel);
            this.tabControlItems.Controls.Add(this.tabAid);
            this.tabControlItems.Controls.Add(this.tabMisc);
            this.tabControlItems.Controls.Add(this.tabAmmo);
            this.tabControlItems.Location = new System.Drawing.Point(0, 0);
            this.tabControlItems.Name = "tabControlItems";
            this.tabControlItems.SelectedIndex = 0;
            this.tabControlItems.Size = new System.Drawing.Size(865, 605);
            this.tabControlItems.TabIndex = 0;
            // 
            // tabWeapons
            // 
            this.tabWeapons.Location = new System.Drawing.Point(4, 22);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapons.Size = new System.Drawing.Size(857, 576);
            this.tabWeapons.TabIndex = 0;
            this.tabWeapons.Text = "Weapons";
            this.tabWeapons.UseVisualStyleBackColor = true;
            // 
            // tabApparel
            // 
            this.tabApparel.Location = new System.Drawing.Point(4, 22);
            this.tabApparel.Name = "tabApparel";
            this.tabApparel.Padding = new System.Windows.Forms.Padding(3);
            this.tabApparel.Size = new System.Drawing.Size(857, 579);
            this.tabApparel.TabIndex = 1;
            this.tabApparel.Text = "Apparel";
            this.tabApparel.UseVisualStyleBackColor = true;
            // 
            // tabAid
            // 
            this.tabAid.Location = new System.Drawing.Point(4, 22);
            this.tabAid.Name = "tabAid";
            this.tabAid.Padding = new System.Windows.Forms.Padding(3);
            this.tabAid.Size = new System.Drawing.Size(864, 582);
            this.tabAid.TabIndex = 2;
            this.tabAid.Text = "Aid";
            this.tabAid.UseVisualStyleBackColor = true;
            // 
            // tabMisc
            // 
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(864, 582);
            this.tabMisc.TabIndex = 3;
            this.tabMisc.Text = "Misc";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // tabAmmo
            // 
            this.tabAmmo.Location = new System.Drawing.Point(4, 22);
            this.tabAmmo.Name = "tabAmmo";
            this.tabAmmo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmmo.Size = new System.Drawing.Size(864, 582);
            this.tabAmmo.TabIndex = 4;
            this.tabAmmo.Text = "Ammo";
            this.tabAmmo.UseVisualStyleBackColor = true;
            // 
            // tabSkills
            // 
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(857, 576);
            this.tabSkills.TabIndex = 2;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabPerks
            // 
            this.tabPerks.Location = new System.Drawing.Point(4, 22);
            this.tabPerks.Name = "tabPerks";
            this.tabPerks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerks.Size = new System.Drawing.Size(857, 576);
            this.tabPerks.TabIndex = 3;
            this.tabPerks.Text = "Perks";
            this.tabPerks.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(857, 576);
            this.tabGeneral.TabIndex = 4;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            this.tabGeneral.Click += new System.EventHandler(this.tabGeneral_Click);
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
            this.tabControlStats.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabControlItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabOtherInfo;
        private System.Windows.Forms.TabControl tabCharacterTabs;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControlStats;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.TabPage tabSpecial;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabPerks;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabControl tabControlItems;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.TabPage tabApparel;
        private System.Windows.Forms.TabPage tabAid;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.TabPage tabAmmo;
    }
}