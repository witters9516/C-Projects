namespace M1PP1_Witter
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
            this.CalcTotalSalesButton = new System.Windows.Forms.Button();
            this.totalSalesListBox = new System.Windows.Forms.ListBox();
            this.totalSalesDescLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcTotalSalesButton
            // 
            this.CalcTotalSalesButton.Location = new System.Drawing.Point(15, 231);
            this.CalcTotalSalesButton.Name = "CalcTotalSalesButton";
            this.CalcTotalSalesButton.Size = new System.Drawing.Size(95, 37);
            this.CalcTotalSalesButton.TabIndex = 0;
            this.CalcTotalSalesButton.Text = "Calculate Total Sales";
            this.CalcTotalSalesButton.UseVisualStyleBackColor = true;
            this.CalcTotalSalesButton.Click += new System.EventHandler(this.CalcTotalSalesButton_Click);
            // 
            // totalSalesListBox
            // 
            this.totalSalesListBox.FormattingEnabled = true;
            this.totalSalesListBox.Location = new System.Drawing.Point(12, 12);
            this.totalSalesListBox.Name = "totalSalesListBox";
            this.totalSalesListBox.Size = new System.Drawing.Size(203, 173);
            this.totalSalesListBox.TabIndex = 1;
            // 
            // totalSalesDescLabel
            // 
            this.totalSalesDescLabel.AutoSize = true;
            this.totalSalesDescLabel.Location = new System.Drawing.Point(12, 199);
            this.totalSalesDescLabel.Name = "totalSalesDescLabel";
            this.totalSalesDescLabel.Size = new System.Drawing.Size(63, 13);
            this.totalSalesDescLabel.TabIndex = 2;
            this.totalSalesDescLabel.Text = "Total Sales:";
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesLabel.Location = new System.Drawing.Point(94, 194);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(121, 23);
            this.totalSalesLabel.TabIndex = 3;
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(116, 231);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 37);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 279);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.totalSalesDescLabel);
            this.Controls.Add(this.totalSalesListBox);
            this.Controls.Add(this.CalcTotalSalesButton);
            this.Name = "Form1";
            this.Text = "Total Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcTotalSalesButton;
        private System.Windows.Forms.ListBox totalSalesListBox;
        private System.Windows.Forms.Label totalSalesDescLabel;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

