namespace classWorkFinalProject
{
    partial class GameGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.battleLog = new System.Windows.Forms.TextBox();
            this.battleLogLabel = new System.Windows.Forms.Label();
            this.actionsGB = new System.Windows.Forms.GroupBox();
            this.specialBtn = new System.Windows.Forms.Button();
            this.defendBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.heroNameLbl1 = new System.Windows.Forms.Label();
            this.heroNameLbl2 = new System.Windows.Forms.Label();
            this.heroNameLbl3 = new System.Windows.Forms.Label();
            this.statsGB = new System.Windows.Forms.GroupBox();
            this.heroSPLbl3 = new System.Windows.Forms.Label();
            this.heroSPLbl2 = new System.Windows.Forms.Label();
            this.heroSPLbl1 = new System.Windows.Forms.Label();
            this.heroHPLbl3 = new System.Windows.Forms.Label();
            this.heroHPLbl2 = new System.Windows.Forms.Label();
            this.heroHPLbl1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heroPB1 = new System.Windows.Forms.PictureBox();
            this.heroPB2 = new System.Windows.Forms.PictureBox();
            this.heroPB3 = new System.Windows.Forms.PictureBox();
            this.gameBackgroundPnl = new System.Windows.Forms.Panel();
            this.enemyPB3 = new System.Windows.Forms.PictureBox();
            this.enemyPB2 = new System.Windows.Forms.PictureBox();
            this.enemyPB1 = new System.Windows.Forms.PictureBox();
            this.actionsGB.SuspendLayout();
            this.statsGB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB3)).BeginInit();
            this.gameBackgroundPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB1)).BeginInit();
            this.SuspendLayout();
            // 
            // battleLog
            // 
            this.battleLog.Enabled = false;
            this.battleLog.Location = new System.Drawing.Point(949, 718);
            this.battleLog.Multiline = true;
            this.battleLog.Name = "battleLog";
            this.battleLog.ReadOnly = true;
            this.battleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battleLog.Size = new System.Drawing.Size(622, 256);
            this.battleLog.TabIndex = 1;
            // 
            // battleLogLabel
            // 
            this.battleLogLabel.AutoSize = true;
            this.battleLogLabel.Location = new System.Drawing.Point(949, 679);
            this.battleLogLabel.Name = "battleLogLabel";
            this.battleLogLabel.Size = new System.Drawing.Size(100, 25);
            this.battleLogLabel.TabIndex = 2;
            this.battleLogLabel.Text = "Battle Log: ";
            // 
            // actionsGB
            // 
            this.actionsGB.Controls.Add(this.specialBtn);
            this.actionsGB.Controls.Add(this.defendBtn);
            this.actionsGB.Controls.Add(this.attackBtn);
            this.actionsGB.Location = new System.Drawing.Point(73, 679);
            this.actionsGB.Name = "actionsGB";
            this.actionsGB.Size = new System.Drawing.Size(370, 295);
            this.actionsGB.TabIndex = 3;
            this.actionsGB.TabStop = false;
            this.actionsGB.Text = "Actions: ";
            // 
            // specialBtn
            // 
            this.specialBtn.Location = new System.Drawing.Point(30, 223);
            this.specialBtn.Name = "specialBtn";
            this.specialBtn.Size = new System.Drawing.Size(312, 52);
            this.specialBtn.TabIndex = 2;
            this.specialBtn.Text = "Special";
            this.specialBtn.UseVisualStyleBackColor = true;
            // 
            // defendBtn
            // 
            this.defendBtn.Location = new System.Drawing.Point(30, 136);
            this.defendBtn.Name = "defendBtn";
            this.defendBtn.Size = new System.Drawing.Size(312, 52);
            this.defendBtn.TabIndex = 1;
            this.defendBtn.Text = "Defend";
            this.defendBtn.UseVisualStyleBackColor = true;
            // 
            // attackBtn
            // 
            this.attackBtn.Location = new System.Drawing.Point(30, 52);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(312, 52);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            // 
            // heroNameLbl1
            // 
            this.heroNameLbl1.AutoSize = true;
            this.heroNameLbl1.Location = new System.Drawing.Point(22, 39);
            this.heroNameLbl1.Name = "heroNameLbl1";
            this.heroNameLbl1.Size = new System.Drawing.Size(70, 25);
            this.heroNameLbl1.TabIndex = 4;
            this.heroNameLbl1.Text = "Warrior";
            // 
            // heroNameLbl2
            // 
            this.heroNameLbl2.AutoSize = true;
            this.heroNameLbl2.Location = new System.Drawing.Point(22, 111);
            this.heroNameLbl2.Name = "heroNameLbl2";
            this.heroNameLbl2.Size = new System.Drawing.Size(57, 25);
            this.heroNameLbl2.TabIndex = 5;
            this.heroNameLbl2.Text = "Mage";
            // 
            // heroNameLbl3
            // 
            this.heroNameLbl3.AutoSize = true;
            this.heroNameLbl3.Location = new System.Drawing.Point(25, 183);
            this.heroNameLbl3.Name = "heroNameLbl3";
            this.heroNameLbl3.Size = new System.Drawing.Size(54, 25);
            this.heroNameLbl3.TabIndex = 6;
            this.heroNameLbl3.Text = "Cleric";
            // 
            // statsGB
            // 
            this.statsGB.Controls.Add(this.heroSPLbl3);
            this.statsGB.Controls.Add(this.heroSPLbl2);
            this.statsGB.Controls.Add(this.heroSPLbl1);
            this.statsGB.Controls.Add(this.heroHPLbl3);
            this.statsGB.Controls.Add(this.heroHPLbl2);
            this.statsGB.Controls.Add(this.heroHPLbl1);
            this.statsGB.Controls.Add(this.heroNameLbl1);
            this.statsGB.Controls.Add(this.heroNameLbl3);
            this.statsGB.Controls.Add(this.heroNameLbl2);
            this.statsGB.Location = new System.Drawing.Point(449, 679);
            this.statsGB.Name = "statsGB";
            this.statsGB.Size = new System.Drawing.Size(482, 295);
            this.statsGB.TabIndex = 7;
            this.statsGB.TabStop = false;
            this.statsGB.Text = "Stats:";
            // 
            // heroSPLbl3
            // 
            this.heroSPLbl3.AutoSize = true;
            this.heroSPLbl3.Location = new System.Drawing.Point(134, 208);
            this.heroSPLbl3.Name = "heroSPLbl3";
            this.heroSPLbl3.Size = new System.Drawing.Size(118, 25);
            this.heroSPLbl3.TabIndex = 12;
            this.heroSPLbl3.Text = "SP: (100/100)";
            // 
            // heroSPLbl2
            // 
            this.heroSPLbl2.AutoSize = true;
            this.heroSPLbl2.Location = new System.Drawing.Point(131, 136);
            this.heroSPLbl2.Name = "heroSPLbl2";
            this.heroSPLbl2.Size = new System.Drawing.Size(118, 25);
            this.heroSPLbl2.TabIndex = 11;
            this.heroSPLbl2.Text = "SP: (100/100)";
            // 
            // heroSPLbl1
            // 
            this.heroSPLbl1.AutoSize = true;
            this.heroSPLbl1.Location = new System.Drawing.Point(131, 64);
            this.heroSPLbl1.Name = "heroSPLbl1";
            this.heroSPLbl1.Size = new System.Drawing.Size(118, 25);
            this.heroSPLbl1.TabIndex = 10;
            this.heroSPLbl1.Text = "SP: (100/100)";
            // 
            // heroHPLbl3
            // 
            this.heroHPLbl3.AutoSize = true;
            this.heroHPLbl3.Location = new System.Drawing.Point(134, 183);
            this.heroHPLbl3.Name = "heroHPLbl3";
            this.heroHPLbl3.Size = new System.Drawing.Size(121, 25);
            this.heroHPLbl3.TabIndex = 9;
            this.heroHPLbl3.Text = "HP: (100/100)";
            // 
            // heroHPLbl2
            // 
            this.heroHPLbl2.AutoSize = true;
            this.heroHPLbl2.Location = new System.Drawing.Point(131, 111);
            this.heroHPLbl2.Name = "heroHPLbl2";
            this.heroHPLbl2.Size = new System.Drawing.Size(121, 25);
            this.heroHPLbl2.TabIndex = 8;
            this.heroHPLbl2.Text = "HP: (100/100)";
            // 
            // heroHPLbl1
            // 
            this.heroHPLbl1.AutoSize = true;
            this.heroHPLbl1.Location = new System.Drawing.Point(131, 39);
            this.heroHPLbl1.Name = "heroHPLbl1";
            this.heroHPLbl1.Size = new System.Drawing.Size(121, 25);
            this.heroHPLbl1.TabIndex = 7;
            this.heroHPLbl1.Text = "HP: (100/100)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1615, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoresToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // heroPB1
            // 
            this.heroPB1.BackColor = System.Drawing.Color.Transparent;
            this.heroPB1.Image = global::classWorkFinalProject.Properties.Resources.Fighter;
            this.heroPB1.Location = new System.Drawing.Point(90, 78);
            this.heroPB1.Name = "heroPB1";
            this.heroPB1.Size = new System.Drawing.Size(173, 170);
            this.heroPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heroPB1.TabIndex = 9;
            this.heroPB1.TabStop = false;
            this.heroPB1.Tag = "1";
            // 
            // heroPB2
            // 
            this.heroPB2.BackColor = System.Drawing.Color.Transparent;
            this.heroPB2.Image = global::classWorkFinalProject.Properties.Resources.Mage;
            this.heroPB2.Location = new System.Drawing.Point(317, 213);
            this.heroPB2.Name = "heroPB2";
            this.heroPB2.Size = new System.Drawing.Size(173, 170);
            this.heroPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heroPB2.TabIndex = 10;
            this.heroPB2.TabStop = false;
            this.heroPB2.Tag = "2";
            // 
            // heroPB3
            // 
            this.heroPB3.BackColor = System.Drawing.Color.Transparent;
            this.heroPB3.Image = global::classWorkFinalProject.Properties.Resources.Cleric;
            this.heroPB3.Location = new System.Drawing.Point(81, 381);
            this.heroPB3.Name = "heroPB3";
            this.heroPB3.Size = new System.Drawing.Size(173, 170);
            this.heroPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heroPB3.TabIndex = 11;
            this.heroPB3.TabStop = false;
            this.heroPB3.Tag = "3";
            // 
            // gameBackgroundPnl
            // 
            this.gameBackgroundPnl.BackgroundImage = global::classWorkFinalProject.Properties.Resources._6bf83e1e_c778_45cd_9bd3_4ffc0d4638e4_scaled;
            this.gameBackgroundPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBackgroundPnl.Controls.Add(this.enemyPB3);
            this.gameBackgroundPnl.Controls.Add(this.enemyPB2);
            this.gameBackgroundPnl.Controls.Add(this.enemyPB1);
            this.gameBackgroundPnl.Controls.Add(this.heroPB1);
            this.gameBackgroundPnl.Controls.Add(this.heroPB3);
            this.gameBackgroundPnl.Controls.Add(this.heroPB2);
            this.gameBackgroundPnl.Location = new System.Drawing.Point(73, 48);
            this.gameBackgroundPnl.Name = "gameBackgroundPnl";
            this.gameBackgroundPnl.Size = new System.Drawing.Size(1498, 625);
            this.gameBackgroundPnl.TabIndex = 12;
            // 
            // enemyPB3
            // 
            this.enemyPB3.BackColor = System.Drawing.Color.Transparent;
            this.enemyPB3.Image = global::classWorkFinalProject.Properties.Resources.Bandit;
            this.enemyPB3.Location = new System.Drawing.Point(1242, 381);
            this.enemyPB3.Name = "enemyPB3";
            this.enemyPB3.Size = new System.Drawing.Size(173, 170);
            this.enemyPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPB3.TabIndex = 14;
            this.enemyPB3.TabStop = false;
            this.enemyPB3.Tag = "3";
            // 
            // enemyPB2
            // 
            this.enemyPB2.BackColor = System.Drawing.Color.Transparent;
            this.enemyPB2.Image = global::classWorkFinalProject.Properties.Resources.Bandit;
            this.enemyPB2.Location = new System.Drawing.Point(1001, 213);
            this.enemyPB2.Name = "enemyPB2";
            this.enemyPB2.Size = new System.Drawing.Size(173, 170);
            this.enemyPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPB2.TabIndex = 13;
            this.enemyPB2.TabStop = false;
            this.enemyPB2.Tag = "2";
            // 
            // enemyPB1
            // 
            this.enemyPB1.BackColor = System.Drawing.Color.Transparent;
            this.enemyPB1.Image = global::classWorkFinalProject.Properties.Resources.Bandit;
            this.enemyPB1.Location = new System.Drawing.Point(1242, 78);
            this.enemyPB1.Name = "enemyPB1";
            this.enemyPB1.Size = new System.Drawing.Size(173, 170);
            this.enemyPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPB1.TabIndex = 12;
            this.enemyPB1.TabStop = false;
            this.enemyPB1.Tag = "1";
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 998);
            this.Controls.Add(this.gameBackgroundPnl);
            this.Controls.Add(this.statsGB);
            this.Controls.Add(this.actionsGB);
            this.Controls.Add(this.battleLogLabel);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameGUI";
            this.Text = "The RPG that shall bring balance to my grade, or destroy it";
            this.actionsGB.ResumeLayout(false);
            this.statsGB.ResumeLayout(false);
            this.statsGB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB3)).EndInit();
            this.gameBackgroundPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox battleLog;
        private Label battleLogLabel;
        private GroupBox actionsGB;
        private Button specialBtn;
        private Button defendBtn;
        private Button attackBtn;
        private Label heroNameLbl1;
        private Label heroNameLbl2;
        private Label heroNameLbl3;
        private GroupBox statsGB;
        private Label heroSPLbl3;
        private Label heroSPLbl2;
        private Label heroSPLbl1;
        private Label heroHPLbl3;
        private Label heroHPLbl2;
        private Label heroHPLbl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem highScoresToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem instructionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox heroPB1;
        private PictureBox heroPB2;
        private PictureBox heroPB3;
        private Panel gameBackgroundPnl;
        private PictureBox enemyPB3;
        private PictureBox enemyPB2;
        private PictureBox enemyPB1;
    }
}