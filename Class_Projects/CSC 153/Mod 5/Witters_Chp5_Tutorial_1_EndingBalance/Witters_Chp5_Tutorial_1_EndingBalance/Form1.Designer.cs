namespace Witters_Chp5_Tutorial_1_EndingBalance
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
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.startBalanceLabel = new System.Windows.Forms.Label();
            this.numOfMonthsLabel = new System.Windows.Forms.Label();
            this.endBalLabel = new System.Windows.Forms.Label();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.detailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(228, 20);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(100, 20);
            this.startingBalTextBox.TabIndex = 0;
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(228, 46);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthsTextBox.TabIndex = 1;
            // 
            // startBalanceLabel
            // 
            this.startBalanceLabel.AutoSize = true;
            this.startBalanceLabel.Location = new System.Drawing.Point(13, 23);
            this.startBalanceLabel.Name = "startBalanceLabel";
            this.startBalanceLabel.Size = new System.Drawing.Size(88, 13);
            this.startBalanceLabel.TabIndex = 2;
            this.startBalanceLabel.Text = "Starting Balance:";
            // 
            // numOfMonthsLabel
            // 
            this.numOfMonthsLabel.AutoSize = true;
            this.numOfMonthsLabel.Location = new System.Drawing.Point(13, 49);
            this.numOfMonthsLabel.Name = "numOfMonthsLabel";
            this.numOfMonthsLabel.Size = new System.Drawing.Size(97, 13);
            this.numOfMonthsLabel.TabIndex = 3;
            this.numOfMonthsLabel.Text = "Number of Months:";
            // 
            // endBalLabel
            // 
            this.endBalLabel.AutoSize = true;
            this.endBalLabel.Location = new System.Drawing.Point(25, 355);
            this.endBalLabel.Name = "endBalLabel";
            this.endBalLabel.Size = new System.Drawing.Size(85, 13);
            this.endBalLabel.TabIndex = 4;
            this.endBalLabel.Text = "Ending Balance:";
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalanceLabel.Location = new System.Drawing.Point(154, 351);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(100, 20);
            this.endingBalanceLabel.TabIndex = 5;
            this.endingBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(38, 391);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 391);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(200, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // detailListBox
            // 
            this.detailListBox.FormattingEnabled = true;
            this.detailListBox.Location = new System.Drawing.Point(16, 86);
            this.detailListBox.Name = "detailListBox";
            this.detailListBox.Size = new System.Drawing.Size(312, 251);
            this.detailListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 441);
            this.Controls.Add(this.detailListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.endBalLabel);
            this.Controls.Add(this.numOfMonthsLabel);
            this.Controls.Add(this.startBalanceLabel);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.startingBalTextBox);
            this.Name = "Form1";
            this.Text = "Ending Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label startBalanceLabel;
        private System.Windows.Forms.Label numOfMonthsLabel;
        private System.Windows.Forms.Label endBalLabel;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox detailListBox;
    }
}

