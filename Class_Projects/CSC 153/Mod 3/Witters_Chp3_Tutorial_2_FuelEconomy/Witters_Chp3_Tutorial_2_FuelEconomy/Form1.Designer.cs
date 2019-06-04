namespace Witters_Chp3_Tutorial_2_FuelEconomy
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
            this.milePromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.milesTextbox = new System.Windows.Forms.TextBox();
            this.gallonsTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // milePromptLabel
            // 
            this.milePromptLabel.AutoSize = true;
            this.milePromptLabel.Location = new System.Drawing.Point(13, 15);
            this.milePromptLabel.Name = "milePromptLabel";
            this.milePromptLabel.Size = new System.Drawing.Size(161, 13);
            this.milePromptLabel.TabIndex = 0;
            this.milePromptLabel.Text = "Enter the number of miles driven:";
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(27, 41);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(147, 13);
            this.gallonsPromptLabel.TabIndex = 1;
            this.gallonsPromptLabel.Text = "Enter the gallons of gas used:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(90, 75);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Your car\'s MPG:";
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(180, 71);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(100, 21);
            this.mpgLabel.TabIndex = 3;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(49, 107);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(130, 107);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // milesTextbox
            // 
            this.milesTextbox.Location = new System.Drawing.Point(180, 12);
            this.milesTextbox.Name = "milesTextbox";
            this.milesTextbox.Size = new System.Drawing.Size(100, 20);
            this.milesTextbox.TabIndex = 6;
            // 
            // gallonsTextbox
            // 
            this.gallonsTextbox.Location = new System.Drawing.Point(180, 38);
            this.gallonsTextbox.Name = "gallonsTextbox";
            this.gallonsTextbox.Size = new System.Drawing.Size(100, 20);
            this.gallonsTextbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.gallonsTextbox);
            this.Controls.Add(this.milesTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milePromptLabel);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milePromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox milesTextbox;
        private System.Windows.Forms.TextBox gallonsTextbox;
    }
}

