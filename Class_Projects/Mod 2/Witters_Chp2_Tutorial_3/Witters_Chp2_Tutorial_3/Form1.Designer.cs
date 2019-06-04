namespace Witters_Chp2_Tutorial_3
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
            this.translationLabel = new System.Windows.Forms.Label();
            this.Italian = new System.Windows.Forms.Button();
            this.Spanish = new System.Windows.Forms.Button();
            this.German = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(24, 18);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(229, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select a language and I will say Good Morning.";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.translationLabel.Location = new System.Drawing.Point(16, 47);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(237, 23);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Italian
            // 
            this.Italian.Location = new System.Drawing.Point(16, 94);
            this.Italian.Name = "Italian";
            this.Italian.Size = new System.Drawing.Size(75, 23);
            this.Italian.TabIndex = 2;
            this.Italian.Text = "Italian";
            this.Italian.UseVisualStyleBackColor = true;
            this.Italian.Click += new System.EventHandler(this.Italian_Click);
            // 
            // Spanish
            // 
            this.Spanish.Location = new System.Drawing.Point(97, 94);
            this.Spanish.Name = "Spanish";
            this.Spanish.Size = new System.Drawing.Size(75, 23);
            this.Spanish.TabIndex = 3;
            this.Spanish.Text = "Spanish";
            this.Spanish.UseVisualStyleBackColor = true;
            this.Spanish.Click += new System.EventHandler(this.Spanish_Click);
            // 
            // German
            // 
            this.German.Location = new System.Drawing.Point(178, 94);
            this.German.Name = "German";
            this.German.Size = new System.Drawing.Size(75, 23);
            this.German.TabIndex = 4;
            this.German.Text = "German";
            this.German.UseVisualStyleBackColor = true;
            this.German.Click += new System.EventHandler(this.German_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.German);
            this.Controls.Add(this.Spanish);
            this.Controls.Add(this.Italian);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button Italian;
        private System.Windows.Forms.Button Spanish;
        private System.Windows.Forms.Button German;
    }
}

