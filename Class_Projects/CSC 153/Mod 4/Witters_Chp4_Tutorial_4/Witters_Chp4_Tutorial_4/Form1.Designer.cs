namespace Witters_Chp4_Tutorial_4
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
            this.exitButton = new System.Windows.Forms.Button();
            this.enterMilesDrivenLabel = new System.Windows.Forms.Label();
            this.enterGasGallonsLabel = new System.Windows.Forms.Label();
            this.yourCarsMPGLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(23, 105);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calaculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(104, 105);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterMilesDrivenLabel
            // 
            this.enterMilesDrivenLabel.AutoSize = true;
            this.enterMilesDrivenLabel.Location = new System.Drawing.Point(13, 9);
            this.enterMilesDrivenLabel.Name = "enterMilesDrivenLabel";
            this.enterMilesDrivenLabel.Size = new System.Drawing.Size(161, 13);
            this.enterMilesDrivenLabel.TabIndex = 2;
            this.enterMilesDrivenLabel.Text = "Enter the number of miles driven:";
            // 
            // enterGasGallonsLabel
            // 
            this.enterGasGallonsLabel.AutoSize = true;
            this.enterGasGallonsLabel.Location = new System.Drawing.Point(13, 35);
            this.enterGasGallonsLabel.Name = "enterGasGallonsLabel";
            this.enterGasGallonsLabel.Size = new System.Drawing.Size(147, 13);
            this.enterGasGallonsLabel.TabIndex = 3;
            this.enterGasGallonsLabel.Text = "Enter the gallons of gas used:";
            // 
            // yourCarsMPGLabel
            // 
            this.yourCarsMPGLabel.AutoSize = true;
            this.yourCarsMPGLabel.Location = new System.Drawing.Point(13, 67);
            this.yourCarsMPGLabel.Name = "yourCarsMPGLabel";
            this.yourCarsMPGLabel.Size = new System.Drawing.Size(85, 13);
            this.yourCarsMPGLabel.TabIndex = 4;
            this.yourCarsMPGLabel.Text = "Your Car\'s MPG:";
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(180, 61);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(100, 24);
            this.mpgLabel.TabIndex = 5;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(180, 6);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesTextBox.TabIndex = 6;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(180, 32);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 150);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.yourCarsMPGLabel);
            this.Controls.Add(this.enterGasGallonsLabel);
            this.Controls.Add(this.enterMilesDrivenLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label enterMilesDrivenLabel;
        private System.Windows.Forms.Label enterGasGallonsLabel;
        private System.Windows.Forms.Label yourCarsMPGLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
    }
}

