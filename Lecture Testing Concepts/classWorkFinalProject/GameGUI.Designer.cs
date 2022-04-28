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
            this.WarriorLbl = new System.Windows.Forms.Label();
            this.MageLbl = new System.Windows.Forms.Label();
            this.ClericLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clericSPLbl = new System.Windows.Forms.Label();
            this.mageSPLbl = new System.Windows.Forms.Label();
            this.warriorSPLbl = new System.Windows.Forms.Label();
            this.clericHPLbl = new System.Windows.Forms.Label();
            this.mageHPLbl = new System.Windows.Forms.Label();
            this.warriorHPLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerPB1 = new System.Windows.Forms.PictureBox();
            this.playerPB2 = new System.Windows.Forms.PictureBox();
            this.playerPB3 = new System.Windows.Forms.PictureBox();
            this.gameBackgroundPnl = new System.Windows.Forms.Panel();
            this.enemyPB3 = new System.Windows.Forms.PictureBox();
            this.enemyPB2 = new System.Windows.Forms.PictureBox();
            this.enemyPB1 = new System.Windows.Forms.PictureBox();
            this.actionsGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB3)).BeginInit();
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
            // WarriorLbl
            // 
            this.WarriorLbl.AutoSize = true;
            this.WarriorLbl.Location = new System.Drawing.Point(25, 66);
            this.WarriorLbl.Name = "WarriorLbl";
            this.WarriorLbl.Size = new System.Drawing.Size(70, 25);
            this.WarriorLbl.TabIndex = 4;
            this.WarriorLbl.Text = "Warrior";
            // 
            // MageLbl
            // 
            this.MageLbl.AutoSize = true;
            this.MageLbl.Location = new System.Drawing.Point(25, 150);
            this.MageLbl.Name = "MageLbl";
            this.MageLbl.Size = new System.Drawing.Size(57, 25);
            this.MageLbl.TabIndex = 5;
            this.MageLbl.Text = "Mage";
            // 
            // ClericLbl
            // 
            this.ClericLbl.AutoSize = true;
            this.ClericLbl.Location = new System.Drawing.Point(25, 237);
            this.ClericLbl.Name = "ClericLbl";
            this.ClericLbl.Size = new System.Drawing.Size(54, 25);
            this.ClericLbl.TabIndex = 6;
            this.ClericLbl.Text = "Cleric";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clericSPLbl);
            this.groupBox1.Controls.Add(this.mageSPLbl);
            this.groupBox1.Controls.Add(this.warriorSPLbl);
            this.groupBox1.Controls.Add(this.clericHPLbl);
            this.groupBox1.Controls.Add(this.mageHPLbl);
            this.groupBox1.Controls.Add(this.warriorHPLbl);
            this.groupBox1.Controls.Add(this.WarriorLbl);
            this.groupBox1.Controls.Add(this.ClericLbl);
            this.groupBox1.Controls.Add(this.MageLbl);
            this.groupBox1.Location = new System.Drawing.Point(449, 679);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 295);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // clericSPLbl
            // 
            this.clericSPLbl.AutoSize = true;
            this.clericSPLbl.Location = new System.Drawing.Point(134, 262);
            this.clericSPLbl.Name = "clericSPLbl";
            this.clericSPLbl.Size = new System.Drawing.Size(118, 25);
            this.clericSPLbl.TabIndex = 12;
            this.clericSPLbl.Text = "SP: (100/100)";
            // 
            // mageSPLbl
            // 
            this.mageSPLbl.AutoSize = true;
            this.mageSPLbl.Location = new System.Drawing.Point(134, 175);
            this.mageSPLbl.Name = "mageSPLbl";
            this.mageSPLbl.Size = new System.Drawing.Size(118, 25);
            this.mageSPLbl.TabIndex = 11;
            this.mageSPLbl.Text = "SP: (100/100)";
            // 
            // warriorSPLbl
            // 
            this.warriorSPLbl.AutoSize = true;
            this.warriorSPLbl.Location = new System.Drawing.Point(134, 91);
            this.warriorSPLbl.Name = "warriorSPLbl";
            this.warriorSPLbl.Size = new System.Drawing.Size(118, 25);
            this.warriorSPLbl.TabIndex = 10;
            this.warriorSPLbl.Text = "SP: (100/100)";
            // 
            // clericHPLbl
            // 
            this.clericHPLbl.AutoSize = true;
            this.clericHPLbl.Location = new System.Drawing.Point(134, 237);
            this.clericHPLbl.Name = "clericHPLbl";
            this.clericHPLbl.Size = new System.Drawing.Size(121, 25);
            this.clericHPLbl.TabIndex = 9;
            this.clericHPLbl.Text = "HP: (100/100)";
            // 
            // mageHPLbl
            // 
            this.mageHPLbl.AutoSize = true;
            this.mageHPLbl.Location = new System.Drawing.Point(134, 150);
            this.mageHPLbl.Name = "mageHPLbl";
            this.mageHPLbl.Size = new System.Drawing.Size(121, 25);
            this.mageHPLbl.TabIndex = 8;
            this.mageHPLbl.Text = "HP: (100/100)";
            // 
            // warriorHPLbl
            // 
            this.warriorHPLbl.AutoSize = true;
            this.warriorHPLbl.Location = new System.Drawing.Point(134, 66);
            this.warriorHPLbl.Name = "warriorHPLbl";
            this.warriorHPLbl.Size = new System.Drawing.Size(121, 25);
            this.warriorHPLbl.TabIndex = 7;
            this.warriorHPLbl.Text = "HP: (100/100)";
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
            // playerPB1
            // 
            this.playerPB1.BackColor = System.Drawing.Color.Transparent;
            this.playerPB1.Image = global::classWorkFinalProject.Properties.Resources.Fighter;
            this.playerPB1.Location = new System.Drawing.Point(90, 78);
            this.playerPB1.Name = "playerPB1";
            this.playerPB1.Size = new System.Drawing.Size(173, 170);
            this.playerPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPB1.TabIndex = 9;
            this.playerPB1.TabStop = false;
            this.playerPB1.Tag = "1";
            // 
            // playerPB2
            // 
            this.playerPB2.BackColor = System.Drawing.Color.Transparent;
            this.playerPB2.Image = global::classWorkFinalProject.Properties.Resources.Mage;
            this.playerPB2.Location = new System.Drawing.Point(317, 213);
            this.playerPB2.Name = "playerPB2";
            this.playerPB2.Size = new System.Drawing.Size(173, 170);
            this.playerPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPB2.TabIndex = 10;
            this.playerPB2.TabStop = false;
            this.playerPB2.Tag = "2";
            // 
            // playerPB3
            // 
            this.playerPB3.BackColor = System.Drawing.Color.Transparent;
            this.playerPB3.Image = global::classWorkFinalProject.Properties.Resources.Cleric;
            this.playerPB3.Location = new System.Drawing.Point(81, 381);
            this.playerPB3.Name = "playerPB3";
            this.playerPB3.Size = new System.Drawing.Size(173, 170);
            this.playerPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPB3.TabIndex = 11;
            this.playerPB3.TabStop = false;
            this.playerPB3.Tag = "3";
            // 
            // gameBackgroundPnl
            // 
            this.gameBackgroundPnl.BackgroundImage = global::classWorkFinalProject.Properties.Resources._6bf83e1e_c778_45cd_9bd3_4ffc0d4638e4_scaled;
            this.gameBackgroundPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBackgroundPnl.Controls.Add(this.enemyPB3);
            this.gameBackgroundPnl.Controls.Add(this.enemyPB2);
            this.gameBackgroundPnl.Controls.Add(this.enemyPB1);
            this.gameBackgroundPnl.Controls.Add(this.playerPB1);
            this.gameBackgroundPnl.Controls.Add(this.playerPB3);
            this.gameBackgroundPnl.Controls.Add(this.playerPB2);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionsGB);
            this.Controls.Add(this.battleLogLabel);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameGUI";
            this.Text = "The RPG that shall bring balance to my grade, or destroy it";
            this.actionsGB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB3)).EndInit();
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
        private Label WarriorLbl;
        private Label MageLbl;
        private Label ClericLbl;
        private GroupBox groupBox1;
        private Label clericSPLbl;
        private Label mageSPLbl;
        private Label warriorSPLbl;
        private Label clericHPLbl;
        private Label mageHPLbl;
        private Label warriorHPLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem highScoresToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem instructionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox playerPB1;
        private PictureBox playerPB2;
        private PictureBox playerPB3;
        private Panel gameBackgroundPnl;
        private PictureBox enemyPB3;
        private PictureBox enemyPB2;
        private PictureBox enemyPB1;
    }
}