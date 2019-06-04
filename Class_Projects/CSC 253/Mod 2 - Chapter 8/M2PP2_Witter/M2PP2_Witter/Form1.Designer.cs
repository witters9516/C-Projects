namespace M2PP2_Witter
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
            this.exitButton = new System.Windows.Forms.Button();
            this.getWordCountButton = new System.Windows.Forms.Button();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.wordCountDescLabel = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.stringDescLabel = new System.Windows.Forms.Label();
            this.averageCharDescLabel = new System.Windows.Forms.Label();
            this.averageCharCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(138, 105);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getWordCountButton
            // 
            this.getWordCountButton.Location = new System.Drawing.Point(57, 105);
            this.getWordCountButton.Name = "getWordCountButton";
            this.getWordCountButton.Size = new System.Drawing.Size(75, 37);
            this.getWordCountButton.TabIndex = 10;
            this.getWordCountButton.Text = "Get Word Count";
            this.getWordCountButton.UseVisualStyleBackColor = true;
            this.getWordCountButton.Click += new System.EventHandler(this.getWordCountButton_Click);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(127, 12);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(167, 20);
            this.stringTextBox.TabIndex = 9;
            // 
            // wordCountDescLabel
            // 
            this.wordCountDescLabel.AutoSize = true;
            this.wordCountDescLabel.Location = new System.Drawing.Point(7, 50);
            this.wordCountDescLabel.Name = "wordCountDescLabel";
            this.wordCountDescLabel.Size = new System.Drawing.Size(67, 13);
            this.wordCountDescLabel.TabIndex = 8;
            this.wordCountDescLabel.Text = "Word Count:";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordCountLabel.Location = new System.Drawing.Point(126, 44);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(168, 24);
            this.wordCountLabel.TabIndex = 7;
            this.wordCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stringDescLabel
            // 
            this.stringDescLabel.AutoSize = true;
            this.stringDescLabel.Location = new System.Drawing.Point(7, 15);
            this.stringDescLabel.Name = "stringDescLabel";
            this.stringDescLabel.Size = new System.Drawing.Size(80, 13);
            this.stringDescLabel.TabIndex = 6;
            this.stringDescLabel.Text = "String to Count:";
            // 
            // averageCharDescLabel
            // 
            this.averageCharDescLabel.AutoSize = true;
            this.averageCharDescLabel.Location = new System.Drawing.Point(7, 84);
            this.averageCharDescLabel.Name = "averageCharDescLabel";
            this.averageCharDescLabel.Size = new System.Drawing.Size(104, 13);
            this.averageCharDescLabel.TabIndex = 13;
            this.averageCharDescLabel.Text = "Average Characters:";
            // 
            // averageCharCountLabel
            // 
            this.averageCharCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageCharCountLabel.Location = new System.Drawing.Point(126, 78);
            this.averageCharCountLabel.Name = "averageCharCountLabel";
            this.averageCharCountLabel.Size = new System.Drawing.Size(168, 24);
            this.averageCharCountLabel.TabIndex = 12;
            this.averageCharCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 152);
            this.Controls.Add(this.averageCharDescLabel);
            this.Controls.Add(this.averageCharCountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getWordCountButton);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.wordCountDescLabel);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.stringDescLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getWordCountButton;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label wordCountDescLabel;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label stringDescLabel;
        private System.Windows.Forms.Label averageCharDescLabel;
        private System.Windows.Forms.Label averageCharCountLabel;
    }
}

