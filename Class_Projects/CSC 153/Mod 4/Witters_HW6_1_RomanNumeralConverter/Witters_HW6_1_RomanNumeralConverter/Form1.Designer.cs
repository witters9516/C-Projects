namespace Witters_HW6_1_RomanNumeralConverter
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.numberSelectedTextBox = new System.Windows.Forms.TextBox();
            this.findRomNumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.romanNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(13, 13);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(285, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter a number between 1 and 10 to get it\'s roman numeral";
            // 
            // numberSelectedTextBox
            // 
            this.numberSelectedTextBox.Location = new System.Drawing.Point(33, 39);
            this.numberSelectedTextBox.Name = "numberSelectedTextBox";
            this.numberSelectedTextBox.Size = new System.Drawing.Size(234, 20);
            this.numberSelectedTextBox.TabIndex = 2;
            // 
            // findRomNumButton
            // 
            this.findRomNumButton.Location = new System.Drawing.Point(33, 115);
            this.findRomNumButton.Name = "findRomNumButton";
            this.findRomNumButton.Size = new System.Drawing.Size(75, 34);
            this.findRomNumButton.TabIndex = 3;
            this.findRomNumButton.Text = "Find Roman Numeral";
            this.findRomNumButton.UseVisualStyleBackColor = true;
            this.findRomNumButton.Click += new System.EventHandler(this.findRomNumButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(192, 115);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // romanNumLabel
            // 
            this.romanNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.romanNumLabel.Location = new System.Drawing.Point(33, 75);
            this.romanNumLabel.Name = "romanNumLabel";
            this.romanNumLabel.Size = new System.Drawing.Size(234, 23);
            this.romanNumLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 157);
            this.Controls.Add(this.romanNumLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findRomNumButton);
            this.Controls.Add(this.numberSelectedTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox numberSelectedTextBox;
        private System.Windows.Forms.Button findRomNumButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label romanNumLabel;
    }
}

