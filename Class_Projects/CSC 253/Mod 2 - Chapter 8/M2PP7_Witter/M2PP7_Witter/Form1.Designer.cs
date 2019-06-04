namespace M2PP7_Witter
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
            this.translateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.descLabel = new System.Windows.Forms.Label();
            this.descLabel2 = new System.Windows.Forms.Label();
            this.pigLatinLabel = new System.Windows.Forms.Label();
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(123, 79);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 0;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(204, 79);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(13, 13);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(44, 13);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "English:";
            // 
            // descLabel2
            // 
            this.descLabel2.AutoSize = true;
            this.descLabel2.Location = new System.Drawing.Point(13, 45);
            this.descLabel2.Name = "descLabel2";
            this.descLabel2.Size = new System.Drawing.Size(51, 13);
            this.descLabel2.TabIndex = 3;
            this.descLabel2.Text = "Pig Latin:";
            // 
            // pigLatinLabel
            // 
            this.pigLatinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pigLatinLabel.Location = new System.Drawing.Point(90, 39);
            this.pigLatinLabel.Name = "pigLatinLabel";
            this.pigLatinLabel.Size = new System.Drawing.Size(320, 24);
            this.pigLatinLabel.TabIndex = 4;
            this.pigLatinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // englishTextBox
            // 
            this.englishTextBox.Location = new System.Drawing.Point(90, 10);
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.Size = new System.Drawing.Size(320, 20);
            this.englishTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 113);
            this.Controls.Add(this.englishTextBox);
            this.Controls.Add(this.pigLatinLabel);
            this.Controls.Add(this.descLabel2);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.translateButton);
            this.Name = "Form1";
            this.Text = "Pig Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label descLabel2;
        private System.Windows.Forms.Label pigLatinLabel;
        private System.Windows.Forms.TextBox englishTextBox;
    }
}

