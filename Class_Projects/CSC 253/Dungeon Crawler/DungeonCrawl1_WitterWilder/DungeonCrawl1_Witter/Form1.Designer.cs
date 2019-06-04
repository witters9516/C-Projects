namespace DungeonCrawl1_Witter
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arraysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.potionListBox = new System.Windows.Forms.ListBox();
            this.weaponListBox = new System.Windows.Forms.ListBox();
            this.treasureListBox = new System.Windows.Forms.ListBox();
            this.roomPanel = new System.Windows.Forms.Panel();
            this.roomArrayLabel = new System.Windows.Forms.Label();
            this.potionPanel = new System.Windows.Forms.Panel();
            this.potionLabel = new System.Windows.Forms.Label();
            this.weaponPanel = new System.Windows.Forms.Panel();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.treasurePanel = new System.Windows.Forms.Panel();
            this.treasureLabel = new System.Windows.Forms.Label();
            this.mobPanel = new System.Windows.Forms.Panel();
            this.mobLabel = new System.Windows.Forms.Label();
            this.mobListBox = new System.Windows.Forms.ListBox();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.room5PictureBox = new System.Windows.Forms.PictureBox();
            this.room4PictureBox = new System.Windows.Forms.PictureBox();
            this.room3PictureBox = new System.Windows.Forms.PictureBox();
            this.room2PictureBox = new System.Windows.Forms.PictureBox();
            this.room1PictureBox = new System.Windows.Forms.PictureBox();
            this.northButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.currentRoomDescLabel = new System.Windows.Forms.Label();
            this.currentRoomLabel = new System.Windows.Forms.Label();
            this.mapLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.roomPanel.SuspendLayout();
            this.potionPanel.SuspendLayout();
            this.weaponPanel.SuspendLayout();
            this.treasurePanel.SuspendLayout();
            this.mobPanel.SuspendLayout();
            this.itemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arraysToolStripMenuItem,
            this.listsToolStripMenuItem,
            this.playerInformationToolStripMenuItem,
            this.enemyInformationToolStripMenuItem,
            this.roomInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arraysToolStripMenuItem
            // 
            this.arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            this.arraysToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.arraysToolStripMenuItem.Text = "Arrays";
            this.arraysToolStripMenuItem.Click += new System.EventHandler(this.arraysToolStripMenuItem_Click);
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.listsToolStripMenuItem.Text = "Lists";
            this.listsToolStripMenuItem.Click += new System.EventHandler(this.listsToolStripMenuItem_Click);
            // 
            // playerInformationToolStripMenuItem
            // 
            this.playerInformationToolStripMenuItem.Name = "playerInformationToolStripMenuItem";
            this.playerInformationToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.playerInformationToolStripMenuItem.Text = "Player Information";
            this.playerInformationToolStripMenuItem.Click += new System.EventHandler(this.playerInformationToolStripMenuItem_Click);
            // 
            // enemyInformationToolStripMenuItem
            // 
            this.enemyInformationToolStripMenuItem.Name = "enemyInformationToolStripMenuItem";
            this.enemyInformationToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.enemyInformationToolStripMenuItem.Text = "Enemy Information";
            this.enemyInformationToolStripMenuItem.Click += new System.EventHandler(this.enemyInformationToolStripMenuItem_Click);
            // 
            // roomInformationToolStripMenuItem
            // 
            this.roomInformationToolStripMenuItem.Name = "roomInformationToolStripMenuItem";
            this.roomInformationToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.roomInformationToolStripMenuItem.Text = "Room Information";
            this.roomInformationToolStripMenuItem.Click += new System.EventHandler(this.roomInformationToolStripMenuItem_Click);
            // 
            // roomListBox
            // 
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.Location = new System.Drawing.Point(13, 23);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(124, 82);
            this.roomListBox.TabIndex = 1;
            // 
            // potionListBox
            // 
            this.potionListBox.FormattingEnabled = true;
            this.potionListBox.Location = new System.Drawing.Point(13, 26);
            this.potionListBox.Name = "potionListBox";
            this.potionListBox.Size = new System.Drawing.Size(124, 82);
            this.potionListBox.TabIndex = 2;
            // 
            // weaponListBox
            // 
            this.weaponListBox.FormattingEnabled = true;
            this.weaponListBox.Location = new System.Drawing.Point(13, 23);
            this.weaponListBox.Name = "weaponListBox";
            this.weaponListBox.Size = new System.Drawing.Size(124, 82);
            this.weaponListBox.TabIndex = 3;
            // 
            // treasureListBox
            // 
            this.treasureListBox.FormattingEnabled = true;
            this.treasureListBox.Location = new System.Drawing.Point(13, 26);
            this.treasureListBox.Name = "treasureListBox";
            this.treasureListBox.Size = new System.Drawing.Size(124, 82);
            this.treasureListBox.TabIndex = 4;
            // 
            // roomPanel
            // 
            this.roomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPanel.Controls.Add(this.roomArrayLabel);
            this.roomPanel.Controls.Add(this.roomListBox);
            this.roomPanel.Location = new System.Drawing.Point(12, 27);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(154, 120);
            this.roomPanel.TabIndex = 5;
            // 
            // roomArrayLabel
            // 
            this.roomArrayLabel.AutoSize = true;
            this.roomArrayLabel.Location = new System.Drawing.Point(10, 7);
            this.roomArrayLabel.Name = "roomArrayLabel";
            this.roomArrayLabel.Size = new System.Drawing.Size(65, 13);
            this.roomArrayLabel.TabIndex = 2;
            this.roomArrayLabel.Text = "Room Array:";
            // 
            // potionPanel
            // 
            this.potionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.potionPanel.Controls.Add(this.potionLabel);
            this.potionPanel.Controls.Add(this.potionListBox);
            this.potionPanel.Location = new System.Drawing.Point(12, 153);
            this.potionPanel.Name = "potionPanel";
            this.potionPanel.Size = new System.Drawing.Size(154, 125);
            this.potionPanel.TabIndex = 6;
            // 
            // potionLabel
            // 
            this.potionLabel.AutoSize = true;
            this.potionLabel.Location = new System.Drawing.Point(10, 10);
            this.potionLabel.Name = "potionLabel";
            this.potionLabel.Size = new System.Drawing.Size(67, 13);
            this.potionLabel.TabIndex = 4;
            this.potionLabel.Text = "Potion Array:";
            // 
            // weaponPanel
            // 
            this.weaponPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponPanel.Controls.Add(this.weaponLabel);
            this.weaponPanel.Controls.Add(this.weaponListBox);
            this.weaponPanel.Location = new System.Drawing.Point(172, 27);
            this.weaponPanel.Name = "weaponPanel";
            this.weaponPanel.Size = new System.Drawing.Size(154, 120);
            this.weaponPanel.TabIndex = 6;
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(10, 7);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(78, 13);
            this.weaponLabel.TabIndex = 3;
            this.weaponLabel.Text = "Weapon Array:";
            // 
            // treasurePanel
            // 
            this.treasurePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treasurePanel.Controls.Add(this.treasureLabel);
            this.treasurePanel.Controls.Add(this.treasureListBox);
            this.treasurePanel.Location = new System.Drawing.Point(172, 153);
            this.treasurePanel.Name = "treasurePanel";
            this.treasurePanel.Size = new System.Drawing.Size(154, 125);
            this.treasurePanel.TabIndex = 7;
            // 
            // treasureLabel
            // 
            this.treasureLabel.AutoSize = true;
            this.treasureLabel.Location = new System.Drawing.Point(10, 10);
            this.treasureLabel.Name = "treasureLabel";
            this.treasureLabel.Size = new System.Drawing.Size(79, 13);
            this.treasureLabel.TabIndex = 5;
            this.treasureLabel.Text = "Treasure Array:";
            // 
            // mobPanel
            // 
            this.mobPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobPanel.Controls.Add(this.mobLabel);
            this.mobPanel.Controls.Add(this.mobListBox);
            this.mobPanel.Location = new System.Drawing.Point(12, 27);
            this.mobPanel.Name = "mobPanel";
            this.mobPanel.Size = new System.Drawing.Size(154, 120);
            this.mobPanel.TabIndex = 8;
            this.mobPanel.Visible = false;
            // 
            // mobLabel
            // 
            this.mobLabel.AutoSize = true;
            this.mobLabel.Location = new System.Drawing.Point(11, 17);
            this.mobLabel.Name = "mobLabel";
            this.mobLabel.Size = new System.Drawing.Size(50, 13);
            this.mobLabel.TabIndex = 10;
            this.mobLabel.Text = "Mob List:";
            // 
            // mobListBox
            // 
            this.mobListBox.FormattingEnabled = true;
            this.mobListBox.Location = new System.Drawing.Point(14, 33);
            this.mobListBox.Name = "mobListBox";
            this.mobListBox.Size = new System.Drawing.Size(123, 82);
            this.mobListBox.TabIndex = 9;
            // 
            // itemPanel
            // 
            this.itemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanel.Controls.Add(this.itemLabel);
            this.itemPanel.Controls.Add(this.itemListBox);
            this.itemPanel.Location = new System.Drawing.Point(172, 27);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(154, 120);
            this.itemPanel.TabIndex = 11;
            this.itemPanel.Visible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(11, 17);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(49, 13);
            this.itemLabel.TabIndex = 10;
            this.itemLabel.Text = "Item List:";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(14, 33);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(123, 82);
            this.itemListBox.TabIndex = 9;
            // 
            // room5PictureBox
            // 
            this.room5PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room5PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room5PictureBox.Location = new System.Drawing.Point(343, 132);
            this.room5PictureBox.Name = "room5PictureBox";
            this.room5PictureBox.Size = new System.Drawing.Size(28, 28);
            this.room5PictureBox.TabIndex = 12;
            this.room5PictureBox.TabStop = false;
            // 
            // room4PictureBox
            // 
            this.room4PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room4PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room4PictureBox.Location = new System.Drawing.Point(343, 166);
            this.room4PictureBox.Name = "room4PictureBox";
            this.room4PictureBox.Size = new System.Drawing.Size(28, 28);
            this.room4PictureBox.TabIndex = 13;
            this.room4PictureBox.TabStop = false;
            // 
            // room3PictureBox
            // 
            this.room3PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room3PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room3PictureBox.Location = new System.Drawing.Point(343, 200);
            this.room3PictureBox.Name = "room3PictureBox";
            this.room3PictureBox.Size = new System.Drawing.Size(28, 28);
            this.room3PictureBox.TabIndex = 14;
            this.room3PictureBox.TabStop = false;
            // 
            // room2PictureBox
            // 
            this.room2PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room2PictureBox.Location = new System.Drawing.Point(343, 234);
            this.room2PictureBox.Name = "room2PictureBox";
            this.room2PictureBox.Size = new System.Drawing.Size(28, 28);
            this.room2PictureBox.TabIndex = 15;
            this.room2PictureBox.TabStop = false;
            // 
            // room1PictureBox
            // 
            this.room1PictureBox.BackColor = System.Drawing.Color.Gray;
            this.room1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room1PictureBox.Location = new System.Drawing.Point(343, 268);
            this.room1PictureBox.Name = "room1PictureBox";
            this.room1PictureBox.Size = new System.Drawing.Size(28, 28);
            this.room1PictureBox.TabIndex = 16;
            this.room1PictureBox.TabStop = false;
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(443, 103);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(45, 23);
            this.northButton.TabIndex = 17;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(443, 132);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(45, 23);
            this.southButton.TabIndex = 18;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // currentRoomDescLabel
            // 
            this.currentRoomDescLabel.AutoSize = true;
            this.currentRoomDescLabel.Location = new System.Drawing.Point(331, 73);
            this.currentRoomDescLabel.Name = "currentRoomDescLabel";
            this.currentRoomDescLabel.Size = new System.Drawing.Size(75, 13);
            this.currentRoomDescLabel.TabIndex = 19;
            this.currentRoomDescLabel.Text = "Current Room:";
            // 
            // currentRoomLabel
            // 
            this.currentRoomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentRoomLabel.Location = new System.Drawing.Point(409, 69);
            this.currentRoomLabel.Name = "currentRoomLabel";
            this.currentRoomLabel.Size = new System.Drawing.Size(127, 21);
            this.currentRoomLabel.TabIndex = 20;
            this.currentRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(340, 113);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(31, 13);
            this.mapLabel.TabIndex = 21;
            this.mapLabel.Text = "Map:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 305);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.currentRoomLabel);
            this.Controls.Add(this.currentRoomDescLabel);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.room1PictureBox);
            this.Controls.Add(this.room2PictureBox);
            this.Controls.Add(this.room3PictureBox);
            this.Controls.Add(this.room4PictureBox);
            this.Controls.Add(this.room5PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.roomPanel);
            this.Controls.Add(this.potionPanel);
            this.Controls.Add(this.weaponPanel);
            this.Controls.Add(this.treasurePanel);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.mobPanel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Dungeon Crawl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.roomPanel.ResumeLayout(false);
            this.roomPanel.PerformLayout();
            this.potionPanel.ResumeLayout(false);
            this.potionPanel.PerformLayout();
            this.weaponPanel.ResumeLayout(false);
            this.weaponPanel.PerformLayout();
            this.treasurePanel.ResumeLayout(false);
            this.treasurePanel.PerformLayout();
            this.mobPanel.ResumeLayout(false);
            this.mobPanel.PerformLayout();
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arraysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.ListBox potionListBox;
        private System.Windows.Forms.ListBox weaponListBox;
        private System.Windows.Forms.ListBox treasureListBox;
        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.Label roomArrayLabel;
        private System.Windows.Forms.Panel potionPanel;
        private System.Windows.Forms.Panel weaponPanel;
        private System.Windows.Forms.Panel treasurePanel;
        private System.Windows.Forms.Label potionLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label treasureLabel;
        private System.Windows.Forms.Panel mobPanel;
        private System.Windows.Forms.ListBox mobListBox;
        private System.Windows.Forms.Label mobLabel;
        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.PictureBox room5PictureBox;
        private System.Windows.Forms.PictureBox room4PictureBox;
        private System.Windows.Forms.PictureBox room3PictureBox;
        private System.Windows.Forms.PictureBox room2PictureBox;
        private System.Windows.Forms.PictureBox room1PictureBox;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Label currentRoomDescLabel;
        private System.Windows.Forms.Label currentRoomLabel;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.ToolStripMenuItem playerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomInformationToolStripMenuItem;
    }
}

