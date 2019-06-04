namespace M2PP1_Witter
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
            this.stringDescLabel = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.wordCountDescLabel = new System.Windows.Forms.Label();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.getWordCountButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stringDescLabel
            // 
            this.stringDescLabel.AutoSize = true;
            this.stringDescLabel.Location = new System.Drawing.Point(11, 13);
            this.stringDescLabel.Name = "stringDescLabel";
            this.stringDescLabel.Size = new System.Drawing.Size(80, 13);
            this.stringDescLabel.TabIndex = 0;
            this.stringDescLabel.Text = "String to Count:";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordCountLabel.Location = new System.Drawing.Point(98, 42);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(168, 24);
            this.wordCountLabel.TabIndex = 1;
            this.wordCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordCountDescLabel
            // 
            this.wordCountDescLabel.AutoSize = true;
            this.wordCountDescLabel.Location = new System.Drawing.Point(11, 48);
            this.wordCountDescLabel.Name = "wordCountDescLabel";
            this.wordCountDescLabel.Size = new System.Drawing.Size(67, 13);
            this.wordCountDescLabel.TabIndex = 2;
            this.wordCountDescLabel.Text = "Word Count:";
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(99, 10);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(167, 20);
            this.stringTextBox.TabIndex = 3;
            // 
            // getWordCountButton
            // 
            this.getWordCountButton.Location = new System.Drawing.Point(50, 79);
            this.getWordCountButton.Name = "getWordCountButton";
            this.getWordCountButton.Size = new System.Drawing.Size(75, 37);
            this.getWordCountButton.TabIndex = 4;
            this.getWordCountButton.Text = "Get Word Count";
            this.getWordCountButton.UseVisualStyleBackColor = true;
            this.getWordCountButton.Click += new System.EventHandler(this.getWordCountButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(131, 79);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getWordCountButton);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.wordCountDescLabel);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.stringDescLabel);
            this.Name = "Form1";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringDescLabel;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label wordCountDescLabel;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Button getWordCountButton;
        private System.Windows.Forms.Button exitButton;
    }
}

