namespace Witters_Chp4_Turtorial_2
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateLabel = new System.Windows.Forms.Label();
            this.grossPayLabelheader = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(24, 108);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Gross Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(105, 108);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 35);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(186, 108);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(21, 16);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(79, 13);
            this.hoursWorkedLabel.TabIndex = 3;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            // 
            // hourlyPayRateLabel
            // 
            this.hourlyPayRateLabel.AutoSize = true;
            this.hourlyPayRateLabel.Location = new System.Drawing.Point(21, 42);
            this.hourlyPayRateLabel.Name = "hourlyPayRateLabel";
            this.hourlyPayRateLabel.Size = new System.Drawing.Size(87, 13);
            this.hourlyPayRateLabel.TabIndex = 4;
            this.hourlyPayRateLabel.Text = "Hourly Pay Rate:";
            // 
            // grossPayLabelheader
            // 
            this.grossPayLabelheader.AutoSize = true;
            this.grossPayLabelheader.Location = new System.Drawing.Point(21, 74);
            this.grossPayLabelheader.Name = "grossPayLabelheader";
            this.grossPayLabelheader.Size = new System.Drawing.Size(58, 13);
            this.grossPayLabelheader.TabIndex = 5;
            this.grossPayLabelheader.Text = "Gross Pay:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Location = new System.Drawing.Point(150, 69);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(100, 22);
            this.grossPayLabel.TabIndex = 6;
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(150, 13);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedTextBox.TabIndex = 7;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(150, 39);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourlyPayRateTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.grossPayLabelheader);
            this.Controls.Add(this.hourlyPayRateLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Payroll With Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label hourlyPayRateLabel;
        private System.Windows.Forms.Label grossPayLabelheader;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
    }
}

