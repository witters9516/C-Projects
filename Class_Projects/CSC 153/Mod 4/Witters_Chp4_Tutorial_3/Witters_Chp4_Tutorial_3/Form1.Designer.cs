namespace Witters_Chp4_Tutorial_3
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
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.annualSalaryLabel = new System.Windows.Forms.Label();
            this.yearsAtJobLabel = new System.Windows.Forms.Label();
            this.loanDecisionLabel = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(16, 134);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(84, 35);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check Qualifications";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(106, 134);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 35);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 134);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // annualSalaryLabel
            // 
            this.annualSalaryLabel.AutoSize = true;
            this.annualSalaryLabel.Location = new System.Drawing.Point(13, 16);
            this.annualSalaryLabel.Name = "annualSalaryLabel";
            this.annualSalaryLabel.Size = new System.Drawing.Size(75, 13);
            this.annualSalaryLabel.TabIndex = 3;
            this.annualSalaryLabel.Text = "Annual Salary:";
            // 
            // yearsAtJobLabel
            // 
            this.yearsAtJobLabel.AutoSize = true;
            this.yearsAtJobLabel.Location = new System.Drawing.Point(13, 42);
            this.yearsAtJobLabel.Name = "yearsAtJobLabel";
            this.yearsAtJobLabel.Size = new System.Drawing.Size(102, 13);
            this.yearsAtJobLabel.TabIndex = 4;
            this.yearsAtJobLabel.Text = "Years at current job:";
            // 
            // loanDecisionLabel
            // 
            this.loanDecisionLabel.AutoSize = true;
            this.loanDecisionLabel.Location = new System.Drawing.Point(13, 72);
            this.loanDecisionLabel.Name = "loanDecisionLabel";
            this.loanDecisionLabel.Size = new System.Drawing.Size(78, 13);
            this.loanDecisionLabel.TabIndex = 5;
            this.loanDecisionLabel.Text = "Loan Decision:";
            // 
            // decisionLabel
            // 
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLabel.Location = new System.Drawing.Point(16, 95);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(256, 32);
            this.decisionLabel.TabIndex = 6;
            this.decisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(172, 12);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 7;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(172, 39);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 175);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.loanDecisionLabel);
            this.Controls.Add(this.yearsAtJobLabel);
            this.Controls.Add(this.annualSalaryLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label annualSalaryLabel;
        private System.Windows.Forms.Label yearsAtJobLabel;
        private System.Windows.Forms.Label loanDecisionLabel;
        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
    }
}

