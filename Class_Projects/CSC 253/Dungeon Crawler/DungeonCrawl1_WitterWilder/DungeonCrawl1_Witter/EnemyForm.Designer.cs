namespace DungeonCrawl1_Witter
{
    partial class EnemyForm
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
            this.eInfoLabel = new System.Windows.Forms.Panel();
            this.eListBox = new System.Windows.Forms.ListBox();
            this.enemyInfoDescLabel = new System.Windows.Forms.Label();
            this.eNameDescLabel = new System.Windows.Forms.Label();
            this.eDescDescLabel = new System.Windows.Forms.Label();
            this.eHPDescLabel = new System.Windows.Forms.Label();
            this.eMPDescLabel = new System.Windows.Forms.Label();
            this.eNameLabel = new System.Windows.Forms.Label();
            this.eDescLabel = new System.Windows.Forms.Label();
            this.eHPLabel = new System.Windows.Forms.Label();
            this.eMPLabel = new System.Windows.Forms.Label();
            this.eDEFLabel = new System.Windows.Forms.Label();
            this.eATKLabel = new System.Windows.Forms.Label();
            this.eDEFDescLabel = new System.Windows.Forms.Label();
            this.eATKDescLabel = new System.Windows.Forms.Label();
            this.eEXPLabel = new System.Windows.Forms.Label();
            this.eSPDLabel = new System.Windows.Forms.Label();
            this.eEXPDescLabel = new System.Windows.Forms.Label();
            this.eSPDDescLabel = new System.Windows.Forms.Label();
            this.eMAGDEFLabel = new System.Windows.Forms.Label();
            this.eMAGLabel = new System.Windows.Forms.Label();
            this.eMAGDEFDescLabel = new System.Windows.Forms.Label();
            this.eMAGDescLabel = new System.Windows.Forms.Label();
            this.eInfoLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // eInfoLabel
            // 
            this.eInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eInfoLabel.Controls.Add(this.eEXPLabel);
            this.eInfoLabel.Controls.Add(this.eSPDLabel);
            this.eInfoLabel.Controls.Add(this.eEXPDescLabel);
            this.eInfoLabel.Controls.Add(this.eSPDDescLabel);
            this.eInfoLabel.Controls.Add(this.eMAGDEFLabel);
            this.eInfoLabel.Controls.Add(this.eMAGLabel);
            this.eInfoLabel.Controls.Add(this.eMAGDEFDescLabel);
            this.eInfoLabel.Controls.Add(this.eMAGDescLabel);
            this.eInfoLabel.Controls.Add(this.eDEFLabel);
            this.eInfoLabel.Controls.Add(this.eATKLabel);
            this.eInfoLabel.Controls.Add(this.eDEFDescLabel);
            this.eInfoLabel.Controls.Add(this.eATKDescLabel);
            this.eInfoLabel.Controls.Add(this.eMPLabel);
            this.eInfoLabel.Controls.Add(this.eHPLabel);
            this.eInfoLabel.Controls.Add(this.eDescLabel);
            this.eInfoLabel.Controls.Add(this.eNameLabel);
            this.eInfoLabel.Controls.Add(this.eMPDescLabel);
            this.eInfoLabel.Controls.Add(this.eHPDescLabel);
            this.eInfoLabel.Controls.Add(this.eDescDescLabel);
            this.eInfoLabel.Controls.Add(this.eNameDescLabel);
            this.eInfoLabel.Controls.Add(this.enemyInfoDescLabel);
            this.eInfoLabel.Location = new System.Drawing.Point(234, 12);
            this.eInfoLabel.Name = "eInfoLabel";
            this.eInfoLabel.Size = new System.Drawing.Size(392, 252);
            this.eInfoLabel.TabIndex = 0;
            // 
            // eListBox
            // 
            this.eListBox.FormattingEnabled = true;
            this.eListBox.Location = new System.Drawing.Point(12, 12);
            this.eListBox.Name = "eListBox";
            this.eListBox.Size = new System.Drawing.Size(204, 251);
            this.eListBox.TabIndex = 1;
            this.eListBox.SelectedIndexChanged += new System.EventHandler(this.eListBox_SelectedIndexChanged);
            // 
            // enemyInfoDescLabel
            // 
            this.enemyInfoDescLabel.AutoSize = true;
            this.enemyInfoDescLabel.Location = new System.Drawing.Point(12, 12);
            this.enemyInfoDescLabel.Name = "enemyInfoDescLabel";
            this.enemyInfoDescLabel.Size = new System.Drawing.Size(63, 13);
            this.enemyInfoDescLabel.TabIndex = 0;
            this.enemyInfoDescLabel.Text = "Enemy Info:";
            // 
            // eNameDescLabel
            // 
            this.eNameDescLabel.AutoSize = true;
            this.eNameDescLabel.Location = new System.Drawing.Point(23, 36);
            this.eNameDescLabel.Name = "eNameDescLabel";
            this.eNameDescLabel.Size = new System.Drawing.Size(73, 13);
            this.eNameDescLabel.TabIndex = 1;
            this.eNameDescLabel.Text = "Enemy Name:";
            // 
            // eDescDescLabel
            // 
            this.eDescDescLabel.AutoSize = true;
            this.eDescDescLabel.Location = new System.Drawing.Point(22, 79);
            this.eDescDescLabel.Name = "eDescDescLabel";
            this.eDescDescLabel.Size = new System.Drawing.Size(98, 13);
            this.eDescDescLabel.TabIndex = 2;
            this.eDescDescLabel.Text = "Enemy Description:";
            // 
            // eHPDescLabel
            // 
            this.eHPDescLabel.AutoSize = true;
            this.eHPDescLabel.Location = new System.Drawing.Point(22, 123);
            this.eHPDescLabel.Name = "eHPDescLabel";
            this.eHPDescLabel.Size = new System.Drawing.Size(60, 13);
            this.eHPDescLabel.TabIndex = 3;
            this.eHPDescLabel.Text = "Enemy HP:";
            // 
            // eMPDescLabel
            // 
            this.eMPDescLabel.AutoSize = true;
            this.eMPDescLabel.Location = new System.Drawing.Point(23, 152);
            this.eMPDescLabel.Name = "eMPDescLabel";
            this.eMPDescLabel.Size = new System.Drawing.Size(61, 13);
            this.eMPDescLabel.TabIndex = 4;
            this.eMPDescLabel.Text = "Enemy MP:";
            // 
            // eNameLabel
            // 
            this.eNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eNameLabel.Location = new System.Drawing.Point(126, 31);
            this.eNameLabel.Name = "eNameLabel";
            this.eNameLabel.Size = new System.Drawing.Size(250, 23);
            this.eNameLabel.TabIndex = 5;
            this.eNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eDescLabel
            // 
            this.eDescLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eDescLabel.Location = new System.Drawing.Point(126, 59);
            this.eDescLabel.Name = "eDescLabel";
            this.eDescLabel.Size = new System.Drawing.Size(250, 53);
            this.eDescLabel.TabIndex = 6;
            this.eDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eHPLabel
            // 
            this.eHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eHPLabel.Location = new System.Drawing.Point(126, 123);
            this.eHPLabel.Name = "eHPLabel";
            this.eHPLabel.Size = new System.Drawing.Size(48, 23);
            this.eHPLabel.TabIndex = 7;
            this.eHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eMPLabel
            // 
            this.eMPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eMPLabel.Location = new System.Drawing.Point(126, 152);
            this.eMPLabel.Name = "eMPLabel";
            this.eMPLabel.Size = new System.Drawing.Size(48, 23);
            this.eMPLabel.TabIndex = 8;
            this.eMPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eDEFLabel
            // 
            this.eDEFLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eDEFLabel.Location = new System.Drawing.Point(126, 210);
            this.eDEFLabel.Name = "eDEFLabel";
            this.eDEFLabel.Size = new System.Drawing.Size(48, 23);
            this.eDEFLabel.TabIndex = 12;
            this.eDEFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eATKLabel
            // 
            this.eATKLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eATKLabel.Location = new System.Drawing.Point(126, 181);
            this.eATKLabel.Name = "eATKLabel";
            this.eATKLabel.Size = new System.Drawing.Size(48, 23);
            this.eATKLabel.TabIndex = 11;
            this.eATKLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eDEFDescLabel
            // 
            this.eDEFDescLabel.AutoSize = true;
            this.eDEFDescLabel.Location = new System.Drawing.Point(23, 210);
            this.eDEFDescLabel.Name = "eDEFDescLabel";
            this.eDEFDescLabel.Size = new System.Drawing.Size(66, 13);
            this.eDEFDescLabel.TabIndex = 10;
            this.eDEFDescLabel.Text = "Enemy DEF:";
            // 
            // eATKDescLabel
            // 
            this.eATKDescLabel.AutoSize = true;
            this.eATKDescLabel.Location = new System.Drawing.Point(22, 181);
            this.eATKDescLabel.Name = "eATKDescLabel";
            this.eATKDescLabel.Size = new System.Drawing.Size(66, 13);
            this.eATKDescLabel.TabIndex = 9;
            this.eATKDescLabel.Text = "Enemy ATK:";
            // 
            // eEXPLabel
            // 
            this.eEXPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eEXPLabel.Location = new System.Drawing.Point(328, 210);
            this.eEXPLabel.Name = "eEXPLabel";
            this.eEXPLabel.Size = new System.Drawing.Size(48, 23);
            this.eEXPLabel.TabIndex = 20;
            this.eEXPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eSPDLabel
            // 
            this.eSPDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eSPDLabel.Location = new System.Drawing.Point(328, 181);
            this.eSPDLabel.Name = "eSPDLabel";
            this.eSPDLabel.Size = new System.Drawing.Size(48, 23);
            this.eSPDLabel.TabIndex = 19;
            this.eSPDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eEXPDescLabel
            // 
            this.eEXPDescLabel.AutoSize = true;
            this.eEXPDescLabel.Location = new System.Drawing.Point(198, 215);
            this.eEXPDescLabel.Name = "eEXPDescLabel";
            this.eEXPDescLabel.Size = new System.Drawing.Size(97, 13);
            this.eEXPDescLabel.TabIndex = 18;
            this.eEXPDescLabel.Text = "Enemy EXP Given:";
            // 
            // eSPDDescLabel
            // 
            this.eSPDDescLabel.AutoSize = true;
            this.eSPDDescLabel.Location = new System.Drawing.Point(197, 186);
            this.eSPDDescLabel.Name = "eSPDDescLabel";
            this.eSPDDescLabel.Size = new System.Drawing.Size(67, 13);
            this.eSPDDescLabel.TabIndex = 17;
            this.eSPDDescLabel.Text = "Enemy SPD:";
            // 
            // eMAGDEFLabel
            // 
            this.eMAGDEFLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eMAGDEFLabel.Location = new System.Drawing.Point(328, 152);
            this.eMAGDEFLabel.Name = "eMAGDEFLabel";
            this.eMAGDEFLabel.Size = new System.Drawing.Size(48, 23);
            this.eMAGDEFLabel.TabIndex = 16;
            this.eMAGDEFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eMAGLabel
            // 
            this.eMAGLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eMAGLabel.Location = new System.Drawing.Point(328, 123);
            this.eMAGLabel.Name = "eMAGLabel";
            this.eMAGLabel.Size = new System.Drawing.Size(48, 23);
            this.eMAGLabel.TabIndex = 15;
            this.eMAGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eMAGDEFDescLabel
            // 
            this.eMAGDEFDescLabel.AutoSize = true;
            this.eMAGDEFDescLabel.Location = new System.Drawing.Point(198, 157);
            this.eMAGDEFDescLabel.Name = "eMAGDEFDescLabel";
            this.eMAGDEFDescLabel.Size = new System.Drawing.Size(93, 13);
            this.eMAGDEFDescLabel.TabIndex = 14;
            this.eMAGDEFDescLabel.Text = "Enemy MAG DEF:";
            // 
            // eMAGDescLabel
            // 
            this.eMAGDescLabel.AutoSize = true;
            this.eMAGDescLabel.Location = new System.Drawing.Point(197, 128);
            this.eMAGDescLabel.Name = "eMAGDescLabel";
            this.eMAGDescLabel.Size = new System.Drawing.Size(69, 13);
            this.eMAGDescLabel.TabIndex = 13;
            this.eMAGDescLabel.Text = "Enemy MAG:";
            // 
            // EnemyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 276);
            this.Controls.Add(this.eListBox);
            this.Controls.Add(this.eInfoLabel);
            this.Name = "EnemyForm";
            this.Text = "EnemyForm";
            this.Load += new System.EventHandler(this.EnemyForm_Load);
            this.eInfoLabel.ResumeLayout(false);
            this.eInfoLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel eInfoLabel;
        private System.Windows.Forms.Label eEXPLabel;
        private System.Windows.Forms.Label eSPDLabel;
        private System.Windows.Forms.Label eEXPDescLabel;
        private System.Windows.Forms.Label eSPDDescLabel;
        private System.Windows.Forms.Label eMAGDEFLabel;
        private System.Windows.Forms.Label eMAGLabel;
        private System.Windows.Forms.Label eMAGDEFDescLabel;
        private System.Windows.Forms.Label eMAGDescLabel;
        private System.Windows.Forms.Label eDEFLabel;
        private System.Windows.Forms.Label eATKLabel;
        private System.Windows.Forms.Label eDEFDescLabel;
        private System.Windows.Forms.Label eATKDescLabel;
        private System.Windows.Forms.Label eMPLabel;
        private System.Windows.Forms.Label eHPLabel;
        private System.Windows.Forms.Label eDescLabel;
        private System.Windows.Forms.Label eNameLabel;
        private System.Windows.Forms.Label eMPDescLabel;
        private System.Windows.Forms.Label eHPDescLabel;
        private System.Windows.Forms.Label eDescDescLabel;
        private System.Windows.Forms.Label eNameDescLabel;
        private System.Windows.Forms.Label enemyInfoDescLabel;
        private System.Windows.Forms.ListBox eListBox;
    }
}