namespace Witters_HW7_6_BookClubPoints
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
            this.booksPurchLabel = new System.Windows.Forms.Label();
            this.booksPurchTextBox = new System.Windows.Forms.TextBox();
            this.pointsEarnedLabel = new System.Windows.Forms.Label();
            this.pointesEarnedLabel = new System.Windows.Forms.Label();
            this.calcPointsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksPurchLabel
            // 
            this.booksPurchLabel.AutoSize = true;
            this.booksPurchLabel.Location = new System.Drawing.Point(13, 13);
            this.booksPurchLabel.Name = "booksPurchLabel";
            this.booksPurchLabel.Size = new System.Drawing.Size(93, 13);
            this.booksPurchLabel.TabIndex = 0;
            this.booksPurchLabel.Text = "Books purchased:";
            // 
            // booksPurchTextBox
            // 
            this.booksPurchTextBox.Location = new System.Drawing.Point(112, 10);
            this.booksPurchTextBox.Name = "booksPurchTextBox";
            this.booksPurchTextBox.Size = new System.Drawing.Size(100, 20);
            this.booksPurchTextBox.TabIndex = 1;
            // 
            // pointsEarnedLabel
            // 
            this.pointsEarnedLabel.AutoSize = true;
            this.pointsEarnedLabel.Location = new System.Drawing.Point(13, 51);
            this.pointsEarnedLabel.Name = "pointsEarnedLabel";
            this.pointsEarnedLabel.Size = new System.Drawing.Size(76, 13);
            this.pointsEarnedLabel.TabIndex = 2;
            this.pointsEarnedLabel.Text = "Points Earned:";
            // 
            // pointesEarnedLabel
            // 
            this.pointesEarnedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointesEarnedLabel.Location = new System.Drawing.Point(112, 42);
            this.pointesEarnedLabel.Name = "pointesEarnedLabel";
            this.pointesEarnedLabel.Size = new System.Drawing.Size(100, 30);
            this.pointesEarnedLabel.TabIndex = 3;
            this.pointesEarnedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcPointsButton
            // 
            this.calcPointsButton.Location = new System.Drawing.Point(12, 84);
            this.calcPointsButton.Name = "calcPointsButton";
            this.calcPointsButton.Size = new System.Drawing.Size(75, 34);
            this.calcPointsButton.TabIndex = 4;
            this.calcPointsButton.Text = "Calculate Points";
            this.calcPointsButton.UseVisualStyleBackColor = true;
            this.calcPointsButton.Click += new System.EventHandler(this.calcPointsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(112, 84);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = " Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcPointsButton);
            this.Controls.Add(this.pointesEarnedLabel);
            this.Controls.Add(this.pointsEarnedLabel);
            this.Controls.Add(this.booksPurchTextBox);
            this.Controls.Add(this.booksPurchLabel);
            this.Name = "Form1";
            this.Text = "Book Club Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label booksPurchLabel;
        private System.Windows.Forms.TextBox booksPurchTextBox;
        private System.Windows.Forms.Label pointsEarnedLabel;
        private System.Windows.Forms.Label pointesEarnedLabel;
        private System.Windows.Forms.Button calcPointsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

