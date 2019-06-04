namespace Witters_Chp6_Tut_5_PayAndBonus
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
            this.totalGrossPayLabel = new System.Windows.Forms.Label();
            this.grossPayTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.bonusAmountLabel = new System.Windows.Forms.Label();
            this.retirementContributionLabel = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // totalGrossPayLabel
            // 
            this.totalGrossPayLabel.AutoSize = true;
            this.totalGrossPayLabel.Location = new System.Drawing.Point(22, 13);
            this.totalGrossPayLabel.Name = "totalGrossPayLabel";
            this.totalGrossPayLabel.Size = new System.Drawing.Size(85, 13);
            this.totalGrossPayLabel.TabIndex = 0;
            this.totalGrossPayLabel.Text = "Total Gross Pay:";
            // 
            // grossPayTextbox
            // 
            this.grossPayTextbox.Location = new System.Drawing.Point(168, 10);
            this.grossPayTextbox.Name = "grossPayTextbox";
            this.grossPayTextbox.Size = new System.Drawing.Size(100, 20);
            this.grossPayTextbox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(57, 97);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 34);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Contribution";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(138, 97);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bonusAmountLabel
            // 
            this.bonusAmountLabel.AutoSize = true;
            this.bonusAmountLabel.Location = new System.Drawing.Point(22, 39);
            this.bonusAmountLabel.Name = "bonusAmountLabel";
            this.bonusAmountLabel.Size = new System.Drawing.Size(79, 13);
            this.bonusAmountLabel.TabIndex = 4;
            this.bonusAmountLabel.Text = "Bonus Amount:";
            // 
            // retirementContributionLabel
            // 
            this.retirementContributionLabel.AutoSize = true;
            this.retirementContributionLabel.Location = new System.Drawing.Point(22, 67);
            this.retirementContributionLabel.Name = "retirementContributionLabel";
            this.retirementContributionLabel.Size = new System.Drawing.Size(120, 13);
            this.retirementContributionLabel.TabIndex = 5;
            this.retirementContributionLabel.Text = "Retirement Contribution:";
            // 
            // contributionLabel
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Location = new System.Drawing.Point(168, 63);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(100, 21);
            this.contributionLabel.TabIndex = 6;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(168, 36);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.bonusTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.retirementContributionLabel);
            this.Controls.Add(this.bonusAmountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayTextbox);
            this.Controls.Add(this.totalGrossPayLabel);
            this.Name = "Form1";
            this.Text = "Pay and Bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalGrossPayLabel;
        private System.Windows.Forms.TextBox grossPayTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label bonusAmountLabel;
        private System.Windows.Forms.Label retirementContributionLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.TextBox bonusTextBox;
    }
}

