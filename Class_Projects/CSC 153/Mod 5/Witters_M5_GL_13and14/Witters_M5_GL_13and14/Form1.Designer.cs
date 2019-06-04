namespace Witters_M5_GL_13and14
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
            this.WriteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.RNListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.RNtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSumRNLabel = new System.Windows.Forms.Label();
            this.totalRNLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(24, 238);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(75, 38);
            this.WriteButton.TabIndex = 0;
            this.WriteButton.Text = "Write To File";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(186, 238);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(105, 238);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 38);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Read from File";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // RNListBox
            // 
            this.RNListBox.FormattingEnabled = true;
            this.RNListBox.Location = new System.Drawing.Point(16, 36);
            this.RNListBox.Name = "RNListBox";
            this.RNListBox.Size = new System.Drawing.Size(256, 134);
            this.RNListBox.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many numbers are being written?";
            // 
            // RNtextBox
            // 
            this.RNtextBox.Location = new System.Drawing.Point(206, 10);
            this.RNtextBox.Name = "RNtextBox";
            this.RNtextBox.Size = new System.Drawing.Size(66, 20);
            this.RNtextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total of all random numbers:";
            // 
            // totalSumRNLabel
            // 
            this.totalSumRNLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSumRNLabel.Location = new System.Drawing.Point(187, 178);
            this.totalSumRNLabel.Name = "totalSumRNLabel";
            this.totalSumRNLabel.Size = new System.Drawing.Size(85, 22);
            this.totalSumRNLabel.TabIndex = 7;
            this.totalSumRNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalRNLabel
            // 
            this.totalRNLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRNLabel.Location = new System.Drawing.Point(187, 207);
            this.totalRNLabel.Name = "totalRNLabel";
            this.totalRNLabel.Size = new System.Drawing.Size(85, 22);
            this.totalRNLabel.TabIndex = 9;
            this.totalRNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total number of random numbers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 287);
            this.Controls.Add(this.totalRNLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalSumRNLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RNtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RNListBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.WriteButton);
            this.Name = "Form1";
            this.Text = "RNG Save And Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListBox RNListBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RNtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalSumRNLabel;
        private System.Windows.Forms.Label totalRNLabel;
        private System.Windows.Forms.Label label5;
    }
}

