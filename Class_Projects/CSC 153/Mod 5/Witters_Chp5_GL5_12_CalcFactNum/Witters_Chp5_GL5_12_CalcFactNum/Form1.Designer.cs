namespace Witters_Chp5_GL5_12_CalcFactNum
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
            this.displayFactorialLabel = new System.Windows.Forms.Label();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.OpenFileDialogListBox = new System.Windows.Forms.ListBox();
            this.openDiaBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factorial Number:";
            // 
            // displayFactorialLabel
            // 
            this.displayFactorialLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayFactorialLabel.Location = new System.Drawing.Point(16, 78);
            this.displayFactorialLabel.Name = "displayFactorialLabel";
            this.displayFactorialLabel.Size = new System.Drawing.Size(242, 29);
            this.displayFactorialLabel.TabIndex = 1;
            this.displayFactorialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(158, 10);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(100, 20);
            this.numberTextbox.TabIndex = 2;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(16, 36);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 36);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 36);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OpenFileDialogListBox
            // 
            this.OpenFileDialogListBox.FormattingEnabled = true;
            this.OpenFileDialogListBox.Location = new System.Drawing.Point(16, 111);
            this.OpenFileDialogListBox.Name = "OpenFileDialogListBox";
            this.OpenFileDialogListBox.Size = new System.Drawing.Size(242, 95);
            this.OpenFileDialogListBox.TabIndex = 5;
            // 
            // openDiaBoxButton
            // 
            this.openDiaBoxButton.Location = new System.Drawing.Point(100, 36);
            this.openDiaBoxButton.Name = "openDiaBoxButton";
            this.openDiaBoxButton.Size = new System.Drawing.Size(75, 36);
            this.openDiaBoxButton.TabIndex = 6;
            this.openDiaBoxButton.Text = "Open DialogBox";
            this.openDiaBoxButton.UseVisualStyleBackColor = true;
            this.openDiaBoxButton.Click += new System.EventHandler(this.openDiaBoxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 283);
            this.Controls.Add(this.openDiaBoxButton);
            this.Controls.Add(this.OpenFileDialogListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.numberTextbox);
            this.Controls.Add(this.displayFactorialLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculating the Factorial of a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayFactorialLabel;
        private System.Windows.Forms.TextBox numberTextbox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox OpenFileDialogListBox;
        private System.Windows.Forms.Button openDiaBoxButton;
    }
}

