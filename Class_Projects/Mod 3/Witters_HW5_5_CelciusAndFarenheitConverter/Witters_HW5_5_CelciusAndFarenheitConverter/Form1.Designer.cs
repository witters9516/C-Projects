namespace Witters_HW5_5_CelciusAndFarenheitConverter
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
            this.label2 = new System.Windows.Forms.Label();
            this.convertedTempLabel = new System.Windows.Forms.Label();
            this.convertCelciusToFarenheitButton = new System.Windows.Forms.Button();
            this.convertFarenheitToCelciusLabel = new System.Windows.Forms.Button();
            this.tempTextbox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(60, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(151, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter a temperature to convert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature:";
            // 
            // convertedTempLabel
            // 
            this.convertedTempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedTempLabel.Location = new System.Drawing.Point(55, 123);
            this.convertedTempLabel.Name = "convertedTempLabel";
            this.convertedTempLabel.Size = new System.Drawing.Size(156, 23);
            this.convertedTempLabel.TabIndex = 2;
            this.convertedTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertCelciusToFarenheitButton
            // 
            this.convertCelciusToFarenheitButton.Location = new System.Drawing.Point(15, 75);
            this.convertCelciusToFarenheitButton.Name = "convertCelciusToFarenheitButton";
            this.convertCelciusToFarenheitButton.Size = new System.Drawing.Size(75, 35);
            this.convertCelciusToFarenheitButton.TabIndex = 3;
            this.convertCelciusToFarenheitButton.Text = "Celcius to Farenheit";
            this.convertCelciusToFarenheitButton.UseVisualStyleBackColor = true;
            this.convertCelciusToFarenheitButton.Click += new System.EventHandler(this.convertCelciusToFarenheitButton_Click);
            // 
            // convertFarenheitToCelciusLabel
            // 
            this.convertFarenheitToCelciusLabel.Location = new System.Drawing.Point(96, 75);
            this.convertFarenheitToCelciusLabel.Name = "convertFarenheitToCelciusLabel";
            this.convertFarenheitToCelciusLabel.Size = new System.Drawing.Size(75, 35);
            this.convertFarenheitToCelciusLabel.TabIndex = 4;
            this.convertFarenheitToCelciusLabel.Text = "Farenheit to Celcius";
            this.convertFarenheitToCelciusLabel.UseVisualStyleBackColor = true;
            this.convertFarenheitToCelciusLabel.Click += new System.EventHandler(this.convertFarenheitToCelciusLabel_Click);
            // 
            // tempTextbox
            // 
            this.tempTextbox.Location = new System.Drawing.Point(152, 36);
            this.tempTextbox.Name = "tempTextbox";
            this.tempTextbox.Size = new System.Drawing.Size(100, 20);
            this.tempTextbox.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 75);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tempTextbox);
            this.Controls.Add(this.convertFarenheitToCelciusLabel);
            this.Controls.Add(this.convertCelciusToFarenheitButton);
            this.Controls.Add(this.convertedTempLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label convertedTempLabel;
        private System.Windows.Forms.Button convertCelciusToFarenheitButton;
        private System.Windows.Forms.Button convertFarenheitToCelciusLabel;
        private System.Windows.Forms.TextBox tempTextbox;
        private System.Windows.Forms.Button exitButton;
    }
}

