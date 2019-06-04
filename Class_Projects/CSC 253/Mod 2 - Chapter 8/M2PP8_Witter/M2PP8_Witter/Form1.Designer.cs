namespace M2PP8_Witter
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
            this.descLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.findSumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sumDescLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(13, 13);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(264, 13);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Please input integers in the TextBox below: 2,5,12,256";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(42, 43);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(211, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // findSumButton
            // 
            this.findSumButton.Location = new System.Drawing.Point(42, 69);
            this.findSumButton.Name = "findSumButton";
            this.findSumButton.Size = new System.Drawing.Size(105, 23);
            this.findSumButton.TabIndex = 2;
            this.findSumButton.Text = "Find Sum";
            this.findSumButton.UseVisualStyleBackColor = true;
            this.findSumButton.Click += new System.EventHandler(this.findSumButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(153, 69);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sumDescLabel
            // 
            this.sumDescLabel.AutoSize = true;
            this.sumDescLabel.Location = new System.Drawing.Point(39, 114);
            this.sumDescLabel.Name = "sumDescLabel";
            this.sumDescLabel.Size = new System.Drawing.Size(31, 13);
            this.sumDescLabel.TabIndex = 4;
            this.sumDescLabel.Text = "Sum:";
            // 
            // sumLabel
            // 
            this.sumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumLabel.Location = new System.Drawing.Point(79, 108);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(174, 25);
            this.sumLabel.TabIndex = 5;
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 149);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sumDescLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findSumButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.descLabel);
            this.Name = "Form1";
            this.Text = "Sum of Numbers in a String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button findSumButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label sumDescLabel;
        private System.Windows.Forms.Label sumLabel;
    }
}

