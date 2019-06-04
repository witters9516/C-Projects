namespace Witters_HW7_9_ChangeToDollars
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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quarterLabel = new System.Windows.Forms.Label();
            this.dimeLabel = new System.Windows.Forms.Label();
            this.nickelLabel = new System.Windows.Forms.Label();
            this.pennyLabel = new System.Windows.Forms.Label();
            this.quarterTextBox = new System.Windows.Forms.TextBox();
            this.dimeTextBox = new System.Windows.Forms.TextBox();
            this.nickelTextBox = new System.Windows.Forms.TextBox();
            this.pennyTextBox = new System.Windows.Forms.TextBox();
            this.totalChangeCollectedLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(6, 25);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(223, 13);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Try to make exactly $1 by clicking the buttons";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quarterLabel);
            this.groupBox1.Controls.Add(this.dimeLabel);
            this.groupBox1.Controls.Add(this.nickelLabel);
            this.groupBox1.Controls.Add(this.pennyLabel);
            this.groupBox1.Controls.Add(this.quarterTextBox);
            this.groupBox1.Controls.Add(this.dimeTextBox);
            this.groupBox1.Controls.Add(this.nickelTextBox);
            this.groupBox1.Controls.Add(this.pennyTextBox);
            this.groupBox1.Controls.Add(this.totalChangeCollectedLabel);
            this.groupBox1.Controls.Add(this.InstructionLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change to Dollar Game";
            // 
            // quarterLabel
            // 
            this.quarterLabel.AutoSize = true;
            this.quarterLabel.Location = new System.Drawing.Point(16, 135);
            this.quarterLabel.Name = "quarterLabel";
            this.quarterLabel.Size = new System.Drawing.Size(47, 13);
            this.quarterLabel.TabIndex = 13;
            this.quarterLabel.Text = "Quarters";
            // 
            // dimeLabel
            // 
            this.dimeLabel.AutoSize = true;
            this.dimeLabel.Location = new System.Drawing.Point(16, 109);
            this.dimeLabel.Name = "dimeLabel";
            this.dimeLabel.Size = new System.Drawing.Size(36, 13);
            this.dimeLabel.TabIndex = 12;
            this.dimeLabel.Text = "Dimes";
            // 
            // nickelLabel
            // 
            this.nickelLabel.AutoSize = true;
            this.nickelLabel.Location = new System.Drawing.Point(16, 83);
            this.nickelLabel.Name = "nickelLabel";
            this.nickelLabel.Size = new System.Drawing.Size(42, 13);
            this.nickelLabel.TabIndex = 11;
            this.nickelLabel.Text = "Nickels";
            // 
            // pennyLabel
            // 
            this.pennyLabel.AutoSize = true;
            this.pennyLabel.Location = new System.Drawing.Point(16, 56);
            this.pennyLabel.Name = "pennyLabel";
            this.pennyLabel.Size = new System.Drawing.Size(45, 13);
            this.pennyLabel.TabIndex = 10;
            this.pennyLabel.Text = "Pennies";
            // 
            // quarterTextBox
            // 
            this.quarterTextBox.Location = new System.Drawing.Point(115, 132);
            this.quarterTextBox.Name = "quarterTextBox";
            this.quarterTextBox.Size = new System.Drawing.Size(100, 20);
            this.quarterTextBox.TabIndex = 9;
            // 
            // dimeTextBox
            // 
            this.dimeTextBox.Location = new System.Drawing.Point(115, 106);
            this.dimeTextBox.Name = "dimeTextBox";
            this.dimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dimeTextBox.TabIndex = 8;
            // 
            // nickelTextBox
            // 
            this.nickelTextBox.Location = new System.Drawing.Point(115, 80);
            this.nickelTextBox.Name = "nickelTextBox";
            this.nickelTextBox.Size = new System.Drawing.Size(100, 20);
            this.nickelTextBox.TabIndex = 7;
            // 
            // pennyTextBox
            // 
            this.pennyTextBox.Location = new System.Drawing.Point(115, 53);
            this.pennyTextBox.Name = "pennyTextBox";
            this.pennyTextBox.Size = new System.Drawing.Size(100, 20);
            this.pennyTextBox.TabIndex = 6;
            // 
            // totalChangeCollectedLabel
            // 
            this.totalChangeCollectedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChangeCollectedLabel.Location = new System.Drawing.Point(7, 160);
            this.totalChangeCollectedLabel.Name = "totalChangeCollectedLabel";
            this.totalChangeCollectedLabel.Size = new System.Drawing.Size(223, 25);
            this.totalChangeCollectedLabel.TabIndex = 5;
            this.totalChangeCollectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(168, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(95, 211);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(70, 35);
            this.playAgainButton.TabIndex = 7;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(21, 211);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(70, 35);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 253);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Change To Dollars Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalChangeCollectedLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label quarterLabel;
        private System.Windows.Forms.Label dimeLabel;
        private System.Windows.Forms.Label nickelLabel;
        private System.Windows.Forms.Label pennyLabel;
        private System.Windows.Forms.TextBox quarterTextBox;
        private System.Windows.Forms.TextBox dimeTextBox;
        private System.Windows.Forms.TextBox nickelTextBox;
        private System.Windows.Forms.TextBox pennyTextBox;
        private System.Windows.Forms.Button totalButton;
    }
}

