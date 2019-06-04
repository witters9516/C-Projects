namespace DungeonCrawl1_Witter
{
    partial class PlayerForm
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
            this.loadInfoButton = new System.Windows.Forms.Button();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.pPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pRaceLabel = new System.Windows.Forms.Label();
            this.pClassLabel = new System.Windows.Forms.Label();
            this.pPasswordLabel = new System.Windows.Forms.Label();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.pRaceDescLabel = new System.Windows.Forms.Label();
            this.pClassDescLabel = new System.Windows.Forms.Label();
            this.pPasswordDescLabel = new System.Windows.Forms.Label();
            this.pNameDescLabel = new System.Windows.Forms.Label();
            this.playerClassPanel = new System.Windows.Forms.Panel();
            this.warriorRadioButton = new System.Windows.Forms.RadioButton();
            this.mageRadioButton = new System.Windows.Forms.RadioButton();
            this.jediRadioButton = new System.Windows.Forms.RadioButton();
            this.playerRacePanel = new System.Windows.Forms.Panel();
            this.humanRadioButton = new System.Windows.Forms.RadioButton();
            this.elfRadioButton = new System.Windows.Forms.RadioButton();
            this.dwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.playerNameCheckTextBox = new System.Windows.Forms.TextBox();
            this.playerPasswordCheckTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerLoadedInfoPanel = new System.Windows.Forms.Panel();
            this.playerDisplayedInfoLabel = new System.Windows.Forms.Label();
            this.playerClassPanel.SuspendLayout();
            this.playerRacePanel.SuspendLayout();
            this.playerLoadedInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadInfoButton
            // 
            this.loadInfoButton.Location = new System.Drawing.Point(319, 235);
            this.loadInfoButton.Name = "loadInfoButton";
            this.loadInfoButton.Size = new System.Drawing.Size(75, 39);
            this.loadInfoButton.TabIndex = 63;
            this.loadInfoButton.Text = "Load Information";
            this.loadInfoButton.UseVisualStyleBackColor = true;
            this.loadInfoButton.Click += new System.EventHandler(this.loadInfoButton_Click);
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(36, 164);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(75, 39);
            this.saveInfoButton.TabIndex = 62;
            this.saveInfoButton.Text = "Save Information";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // pPasswordTextBox
            // 
            this.pPasswordTextBox.Location = new System.Drawing.Point(119, 33);
            this.pPasswordTextBox.Name = "pPasswordTextBox";
            this.pPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.pPasswordTextBox.TabIndex = 61;
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.Location = new System.Drawing.Point(119, 6);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pNameTextBox.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Player Race:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Player Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Player Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Player Name:";
            // 
            // pRaceLabel
            // 
            this.pRaceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRaceLabel.Location = new System.Drawing.Point(95, 122);
            this.pRaceLabel.Name = "pRaceLabel";
            this.pRaceLabel.Size = new System.Drawing.Size(118, 23);
            this.pRaceLabel.TabIndex = 55;
            this.pRaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pClassLabel
            // 
            this.pClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pClassLabel.Location = new System.Drawing.Point(95, 93);
            this.pClassLabel.Name = "pClassLabel";
            this.pClassLabel.Size = new System.Drawing.Size(118, 23);
            this.pClassLabel.TabIndex = 54;
            this.pClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPasswordLabel
            // 
            this.pPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPasswordLabel.Location = new System.Drawing.Point(95, 64);
            this.pPasswordLabel.Name = "pPasswordLabel";
            this.pPasswordLabel.Size = new System.Drawing.Size(118, 23);
            this.pPasswordLabel.TabIndex = 53;
            this.pPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pNameLabel
            // 
            this.pNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNameLabel.Location = new System.Drawing.Point(95, 37);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(118, 23);
            this.pNameLabel.TabIndex = 52;
            this.pNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pRaceDescLabel
            // 
            this.pRaceDescLabel.AutoSize = true;
            this.pRaceDescLabel.Location = new System.Drawing.Point(6, 127);
            this.pRaceDescLabel.Name = "pRaceDescLabel";
            this.pRaceDescLabel.Size = new System.Drawing.Size(68, 13);
            this.pRaceDescLabel.TabIndex = 51;
            this.pRaceDescLabel.Text = "Player Race:";
            // 
            // pClassDescLabel
            // 
            this.pClassDescLabel.AutoSize = true;
            this.pClassDescLabel.Location = new System.Drawing.Point(6, 98);
            this.pClassDescLabel.Name = "pClassDescLabel";
            this.pClassDescLabel.Size = new System.Drawing.Size(67, 13);
            this.pClassDescLabel.TabIndex = 50;
            this.pClassDescLabel.Text = "Player Class:";
            // 
            // pPasswordDescLabel
            // 
            this.pPasswordDescLabel.AutoSize = true;
            this.pPasswordDescLabel.Location = new System.Drawing.Point(6, 69);
            this.pPasswordDescLabel.Name = "pPasswordDescLabel";
            this.pPasswordDescLabel.Size = new System.Drawing.Size(88, 13);
            this.pPasswordDescLabel.TabIndex = 49;
            this.pPasswordDescLabel.Text = "Player Password:";
            // 
            // pNameDescLabel
            // 
            this.pNameDescLabel.AutoSize = true;
            this.pNameDescLabel.Location = new System.Drawing.Point(6, 42);
            this.pNameDescLabel.Name = "pNameDescLabel";
            this.pNameDescLabel.Size = new System.Drawing.Size(70, 13);
            this.pNameDescLabel.TabIndex = 48;
            this.pNameDescLabel.Text = "Player Name:";
            // 
            // playerClassPanel
            // 
            this.playerClassPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerClassPanel.Controls.Add(this.warriorRadioButton);
            this.playerClassPanel.Controls.Add(this.mageRadioButton);
            this.playerClassPanel.Controls.Add(this.jediRadioButton);
            this.playerClassPanel.Location = new System.Drawing.Point(9, 58);
            this.playerClassPanel.Name = "playerClassPanel";
            this.playerClassPanel.Size = new System.Drawing.Size(102, 100);
            this.playerClassPanel.TabIndex = 64;
            // 
            // warriorRadioButton
            // 
            this.warriorRadioButton.AutoSize = true;
            this.warriorRadioButton.Location = new System.Drawing.Point(11, 25);
            this.warriorRadioButton.Name = "warriorRadioButton";
            this.warriorRadioButton.Size = new System.Drawing.Size(59, 17);
            this.warriorRadioButton.TabIndex = 40;
            this.warriorRadioButton.Text = "Warrior";
            this.warriorRadioButton.UseVisualStyleBackColor = true;
            // 
            // mageRadioButton
            // 
            this.mageRadioButton.AutoSize = true;
            this.mageRadioButton.Location = new System.Drawing.Point(11, 48);
            this.mageRadioButton.Name = "mageRadioButton";
            this.mageRadioButton.Size = new System.Drawing.Size(52, 17);
            this.mageRadioButton.TabIndex = 41;
            this.mageRadioButton.Text = "Mage";
            this.mageRadioButton.UseVisualStyleBackColor = true;
            // 
            // jediRadioButton
            // 
            this.jediRadioButton.AutoSize = true;
            this.jediRadioButton.Location = new System.Drawing.Point(11, 71);
            this.jediRadioButton.Name = "jediRadioButton";
            this.jediRadioButton.Size = new System.Drawing.Size(44, 17);
            this.jediRadioButton.TabIndex = 42;
            this.jediRadioButton.Text = "Jedi";
            this.jediRadioButton.UseVisualStyleBackColor = true;
            // 
            // playerRacePanel
            // 
            this.playerRacePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerRacePanel.Controls.Add(this.humanRadioButton);
            this.playerRacePanel.Controls.Add(this.elfRadioButton);
            this.playerRacePanel.Controls.Add(this.dwarfRadioButton);
            this.playerRacePanel.Location = new System.Drawing.Point(117, 58);
            this.playerRacePanel.Name = "playerRacePanel";
            this.playerRacePanel.Size = new System.Drawing.Size(102, 100);
            this.playerRacePanel.TabIndex = 65;
            // 
            // humanRadioButton
            // 
            this.humanRadioButton.AutoSize = true;
            this.humanRadioButton.Location = new System.Drawing.Point(18, 71);
            this.humanRadioButton.Name = "humanRadioButton";
            this.humanRadioButton.Size = new System.Drawing.Size(59, 17);
            this.humanRadioButton.TabIndex = 45;
            this.humanRadioButton.Text = "Human";
            this.humanRadioButton.UseVisualStyleBackColor = true;
            // 
            // elfRadioButton
            // 
            this.elfRadioButton.AutoSize = true;
            this.elfRadioButton.Location = new System.Drawing.Point(18, 25);
            this.elfRadioButton.Name = "elfRadioButton";
            this.elfRadioButton.Size = new System.Drawing.Size(37, 17);
            this.elfRadioButton.TabIndex = 43;
            this.elfRadioButton.Text = "Elf";
            this.elfRadioButton.UseVisualStyleBackColor = true;
            // 
            // dwarfRadioButton
            // 
            this.dwarfRadioButton.AutoSize = true;
            this.dwarfRadioButton.Location = new System.Drawing.Point(18, 48);
            this.dwarfRadioButton.Name = "dwarfRadioButton";
            this.dwarfRadioButton.Size = new System.Drawing.Size(53, 17);
            this.dwarfRadioButton.TabIndex = 44;
            this.dwarfRadioButton.Text = "Dwarf";
            this.dwarfRadioButton.UseVisualStyleBackColor = true;
            // 
            // playerNameCheckTextBox
            // 
            this.playerNameCheckTextBox.Location = new System.Drawing.Point(340, 6);
            this.playerNameCheckTextBox.Name = "playerNameCheckTextBox";
            this.playerNameCheckTextBox.Size = new System.Drawing.Size(118, 20);
            this.playerNameCheckTextBox.TabIndex = 66;
            // 
            // playerPasswordCheckTextBox
            // 
            this.playerPasswordCheckTextBox.Location = new System.Drawing.Point(340, 32);
            this.playerPasswordCheckTextBox.Name = "playerPasswordCheckTextBox";
            this.playerPasswordCheckTextBox.Size = new System.Drawing.Size(118, 20);
            this.playerPasswordCheckTextBox.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Player Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Player Password:";
            // 
            // playerLoadedInfoPanel
            // 
            this.playerLoadedInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLoadedInfoPanel.Controls.Add(this.playerDisplayedInfoLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pNameLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pNameDescLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pPasswordDescLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pClassDescLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pRaceDescLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pPasswordLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pClassLabel);
            this.playerLoadedInfoPanel.Controls.Add(this.pRaceLabel);
            this.playerLoadedInfoPanel.Location = new System.Drawing.Point(245, 64);
            this.playerLoadedInfoPanel.Name = "playerLoadedInfoPanel";
            this.playerLoadedInfoPanel.Size = new System.Drawing.Size(228, 165);
            this.playerLoadedInfoPanel.TabIndex = 70;
            // 
            // playerDisplayedInfoLabel
            // 
            this.playerDisplayedInfoLabel.AutoSize = true;
            this.playerDisplayedInfoLabel.Location = new System.Drawing.Point(6, 10);
            this.playerDisplayedInfoLabel.Name = "playerDisplayedInfoLabel";
            this.playerDisplayedInfoLabel.Size = new System.Drawing.Size(133, 13);
            this.playerDisplayedInfoLabel.TabIndex = 71;
            this.playerDisplayedInfoLabel.Text = "Player Loaded Information:";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 286);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerPasswordCheckTextBox);
            this.Controls.Add(this.playerNameCheckTextBox);
            this.Controls.Add(this.loadInfoButton);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.pPasswordTextBox);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerClassPanel);
            this.Controls.Add(this.playerRacePanel);
            this.Controls.Add(this.playerLoadedInfoPanel);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.playerClassPanel.ResumeLayout(false);
            this.playerClassPanel.PerformLayout();
            this.playerRacePanel.ResumeLayout(false);
            this.playerRacePanel.PerformLayout();
            this.playerLoadedInfoPanel.ResumeLayout(false);
            this.playerLoadedInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadInfoButton;
        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.TextBox pPasswordTextBox;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pRaceLabel;
        private System.Windows.Forms.Label pClassLabel;
        private System.Windows.Forms.Label pPasswordLabel;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Label pRaceDescLabel;
        private System.Windows.Forms.Label pClassDescLabel;
        private System.Windows.Forms.Label pPasswordDescLabel;
        private System.Windows.Forms.Label pNameDescLabel;
        private System.Windows.Forms.Panel playerClassPanel;
        private System.Windows.Forms.RadioButton warriorRadioButton;
        private System.Windows.Forms.RadioButton mageRadioButton;
        private System.Windows.Forms.RadioButton jediRadioButton;
        private System.Windows.Forms.Panel playerRacePanel;
        private System.Windows.Forms.RadioButton humanRadioButton;
        private System.Windows.Forms.RadioButton elfRadioButton;
        private System.Windows.Forms.RadioButton dwarfRadioButton;
        private System.Windows.Forms.TextBox playerNameCheckTextBox;
        private System.Windows.Forms.TextBox playerPasswordCheckTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel playerLoadedInfoPanel;
        private System.Windows.Forms.Label playerDisplayedInfoLabel;
    }
}