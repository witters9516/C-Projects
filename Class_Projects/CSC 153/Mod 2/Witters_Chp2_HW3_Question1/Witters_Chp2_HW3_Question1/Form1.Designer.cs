namespace Witters_Chp2_HW3_Question1
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
            this.label1 = new System.Windows.Forms.Label();
            this.sinisterButton = new System.Windows.Forms.Button();
            this.dexterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.translatedWordLabel = new System.Windows.Forms.Label();
            this.latinLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click any of the buttons to see the word translated to english.";
            // 
            // sinisterButton
            // 
            this.sinisterButton.Location = new System.Drawing.Point(16, 71);
            this.sinisterButton.Name = "sinisterButton";
            this.sinisterButton.Size = new System.Drawing.Size(75, 23);
            this.sinisterButton.TabIndex = 1;
            this.sinisterButton.Text = "Sinister";
            this.sinisterButton.UseVisualStyleBackColor = true;
            this.sinisterButton.Click += new System.EventHandler(this.sinisterButton_Click);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(99, 71);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(75, 23);
            this.dexterButton.TabIndex = 2;
            this.dexterButton.Text = "Dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(180, 71);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 3;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // translatedWordLabel
            // 
            this.translatedWordLabel.Location = new System.Drawing.Point(96, 137);
            this.translatedWordLabel.Name = "translatedWordLabel";
            this.translatedWordLabel.Size = new System.Drawing.Size(100, 23);
            this.translatedWordLabel.TabIndex = 4;
            this.translatedWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latinLabel
            // 
            this.latinLabel.AutoSize = true;
            this.latinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.latinLabel.Location = new System.Drawing.Point(119, 41);
            this.latinLabel.Name = "latinLabel";
            this.latinLabel.Size = new System.Drawing.Size(39, 17);
            this.latinLabel.TabIndex = 5;
            this.latinLabel.Text = "Latin";
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.englishLabel.Location = new System.Drawing.Point(119, 107);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(54, 17);
            this.englishLabel.TabIndex = 6;
            this.englishLabel.Text = "English";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 171);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.latinLabel);
            this.Controls.Add(this.translatedWordLabel);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.sinisterButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sinisterButton;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Label translatedWordLabel;
        private System.Windows.Forms.Label latinLabel;
        private System.Windows.Forms.Label englishLabel;
    }
}

