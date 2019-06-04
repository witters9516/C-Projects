namespace M1PP2_Witter
{
    partial class lowSalesDescLabel
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
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.totalSalesDescLabel = new System.Windows.Forms.Label();
            this.totalSalesListBox = new System.Windows.Forms.ListBox();
            this.CalcTotalSalesButton = new System.Windows.Forms.Button();
            this.averageSalesLabel = new System.Windows.Forms.Label();
            this.aveSalesDescLabel = new System.Windows.Forms.Label();
            this.highestSalesLabel = new System.Windows.Forms.Label();
            this.highSalesDescLabel = new System.Windows.Forms.Label();
            this.lowestSalesLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(229, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 37);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesLabel.Location = new System.Drawing.Point(308, 12);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(121, 23);
            this.totalSalesLabel.TabIndex = 8;
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSalesDescLabel
            // 
            this.totalSalesDescLabel.AutoSize = true;
            this.totalSalesDescLabel.Location = new System.Drawing.Point(226, 17);
            this.totalSalesDescLabel.Name = "totalSalesDescLabel";
            this.totalSalesDescLabel.Size = new System.Drawing.Size(63, 13);
            this.totalSalesDescLabel.TabIndex = 7;
            this.totalSalesDescLabel.Text = "Total Sales:";
            // 
            // totalSalesListBox
            // 
            this.totalSalesListBox.FormattingEnabled = true;
            this.totalSalesListBox.Location = new System.Drawing.Point(12, 12);
            this.totalSalesListBox.Name = "totalSalesListBox";
            this.totalSalesListBox.Size = new System.Drawing.Size(203, 173);
            this.totalSalesListBox.TabIndex = 6;
            // 
            // CalcTotalSalesButton
            // 
            this.CalcTotalSalesButton.Location = new System.Drawing.Point(120, 201);
            this.CalcTotalSalesButton.Name = "CalcTotalSalesButton";
            this.CalcTotalSalesButton.Size = new System.Drawing.Size(95, 37);
            this.CalcTotalSalesButton.TabIndex = 5;
            this.CalcTotalSalesButton.Text = "Calculate Total Sales";
            this.CalcTotalSalesButton.UseVisualStyleBackColor = true;
            this.CalcTotalSalesButton.Click += new System.EventHandler(this.CalcTotalSalesButton_Click);
            // 
            // averageSalesLabel
            // 
            this.averageSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageSalesLabel.Location = new System.Drawing.Point(308, 62);
            this.averageSalesLabel.Name = "averageSalesLabel";
            this.averageSalesLabel.Size = new System.Drawing.Size(121, 23);
            this.averageSalesLabel.TabIndex = 11;
            this.averageSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aveSalesDescLabel
            // 
            this.aveSalesDescLabel.AutoSize = true;
            this.aveSalesDescLabel.Location = new System.Drawing.Point(226, 67);
            this.aveSalesDescLabel.Name = "aveSalesDescLabel";
            this.aveSalesDescLabel.Size = new System.Drawing.Size(79, 13);
            this.aveSalesDescLabel.TabIndex = 10;
            this.aveSalesDescLabel.Text = "Average Sales:";
            // 
            // highestSalesLabel
            // 
            this.highestSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highestSalesLabel.Location = new System.Drawing.Point(308, 115);
            this.highestSalesLabel.Name = "highestSalesLabel";
            this.highestSalesLabel.Size = new System.Drawing.Size(121, 23);
            this.highestSalesLabel.TabIndex = 13;
            this.highestSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highSalesDescLabel
            // 
            this.highSalesDescLabel.AutoSize = true;
            this.highSalesDescLabel.Location = new System.Drawing.Point(226, 120);
            this.highSalesDescLabel.Name = "highSalesDescLabel";
            this.highSalesDescLabel.Size = new System.Drawing.Size(70, 13);
            this.highSalesDescLabel.TabIndex = 12;
            this.highSalesDescLabel.Text = "Highest Sale:";
            // 
            // lowestSalesLabel
            // 
            this.lowestSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestSalesLabel.Location = new System.Drawing.Point(308, 162);
            this.lowestSalesLabel.Name = "lowestSalesLabel";
            this.lowestSalesLabel.Size = new System.Drawing.Size(121, 23);
            this.lowestSalesLabel.TabIndex = 15;
            this.lowestSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lowest Sale:";
            // 
            // lowSalesDescLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 248);
            this.Controls.Add(this.lowestSalesLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.highestSalesLabel);
            this.Controls.Add(this.highSalesDescLabel);
            this.Controls.Add(this.averageSalesLabel);
            this.Controls.Add(this.aveSalesDescLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.totalSalesDescLabel);
            this.Controls.Add(this.totalSalesListBox);
            this.Controls.Add(this.CalcTotalSalesButton);
            this.Name = "lowSalesDescLabel";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label totalSalesDescLabel;
        private System.Windows.Forms.ListBox totalSalesListBox;
        private System.Windows.Forms.Button CalcTotalSalesButton;
        private System.Windows.Forms.Label averageSalesLabel;
        private System.Windows.Forms.Label aveSalesDescLabel;
        private System.Windows.Forms.Label highestSalesLabel;
        private System.Windows.Forms.Label highSalesDescLabel;
        private System.Windows.Forms.Label lowestSalesLabel;
        private System.Windows.Forms.Label label6;
    }
}

