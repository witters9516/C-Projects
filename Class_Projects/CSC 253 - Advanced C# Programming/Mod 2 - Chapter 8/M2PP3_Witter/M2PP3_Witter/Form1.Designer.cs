namespace M2PP3_Witter
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
            this.changeStringButton = new System.Windows.Forms.Button();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.newSentenceDescLabel = new System.Windows.Forms.Label();
            this.capitilizedSentenceLabel = new System.Windows.Forms.Label();
            this.stringDescLabel = new System.Windows.Forms.Label();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(143, 99);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeStringButton
            // 
            this.changeStringButton.Location = new System.Drawing.Point(62, 99);
            this.changeStringButton.Name = "changeStringButton";
            this.changeStringButton.Size = new System.Drawing.Size(75, 37);
            this.changeStringButton.TabIndex = 18;
            this.changeStringButton.Text = "Change String";
            this.changeStringButton.UseVisualStyleBackColor = true;
            this.changeStringButton.Click += new System.EventHandler(this.changeStringButton_Click);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(132, 6);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(167, 20);
            this.stringTextBox.TabIndex = 17;
            // 
            // newSentenceDescLabel
            // 
            this.newSentenceDescLabel.AutoSize = true;
            this.newSentenceDescLabel.Location = new System.Drawing.Point(12, 44);
            this.newSentenceDescLabel.Name = "newSentenceDescLabel";
            this.newSentenceDescLabel.Size = new System.Drawing.Size(110, 13);
            this.newSentenceDescLabel.TabIndex = 16;
            this.newSentenceDescLabel.Text = "Capatilized Sentence:";
            // 
            // capitilizedSentenceLabel
            // 
            this.capitilizedSentenceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capitilizedSentenceLabel.Location = new System.Drawing.Point(131, 38);
            this.capitilizedSentenceLabel.Name = "capitilizedSentenceLabel";
            this.capitilizedSentenceLabel.Size = new System.Drawing.Size(168, 24);
            this.capitilizedSentenceLabel.TabIndex = 15;
            this.capitilizedSentenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stringDescLabel
            // 
            this.stringDescLabel.AutoSize = true;
            this.stringDescLabel.Location = new System.Drawing.Point(12, 9);
            this.stringDescLabel.Name = "stringDescLabel";
            this.stringDescLabel.Size = new System.Drawing.Size(89, 13);
            this.stringDescLabel.TabIndex = 14;
            this.stringDescLabel.Text = "String to Change:";
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.Location = new System.Drawing.Point(15, 153);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(284, 238);
            this.wordListBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 408);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.changeStringButton);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.newSentenceDescLabel);
            this.Controls.Add(this.capitilizedSentenceLabel);
            this.Controls.Add(this.stringDescLabel);
            this.Name = "Form1";
            this.Text = "Sentence Capatilizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeStringButton;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label newSentenceDescLabel;
        private System.Windows.Forms.Label capitilizedSentenceLabel;
        private System.Windows.Forms.Label stringDescLabel;
        private System.Windows.Forms.ListBox wordListBox;
    }
}

