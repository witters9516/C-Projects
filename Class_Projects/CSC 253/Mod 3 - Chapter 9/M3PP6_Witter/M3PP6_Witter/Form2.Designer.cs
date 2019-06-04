namespace M3PP6_Witter
{
    partial class Form2
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
            this.display1Label = new System.Windows.Forms.Label();
            this.display2Label = new System.Windows.Forms.Label();
            this.display3Label = new System.Windows.Forms.Label();
            this.dormChargesLabel = new System.Windows.Forms.Label();
            this.mealChargeLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display1Label
            // 
            this.display1Label.AutoSize = true;
            this.display1Label.Location = new System.Drawing.Point(12, 18);
            this.display1Label.Name = "display1Label";
            this.display1Label.Size = new System.Drawing.Size(72, 13);
            this.display1Label.TabIndex = 0;
            this.display1Label.Text = "Dorm Charge:";
            // 
            // display2Label
            // 
            this.display2Label.AutoSize = true;
            this.display2Label.Location = new System.Drawing.Point(12, 53);
            this.display2Label.Name = "display2Label";
            this.display2Label.Size = new System.Drawing.Size(94, 13);
            this.display2Label.TabIndex = 1;
            this.display2Label.Text = "Meal Plan Charge:";
            // 
            // display3Label
            // 
            this.display3Label.AutoSize = true;
            this.display3Label.Location = new System.Drawing.Point(12, 86);
            this.display3Label.Name = "display3Label";
            this.display3Label.Size = new System.Drawing.Size(76, 13);
            this.display3Label.TabIndex = 2;
            this.display3Label.Text = "Total Charges:";
            // 
            // dormChargesLabel
            // 
            this.dormChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dormChargesLabel.Location = new System.Drawing.Point(132, 12);
            this.dormChargesLabel.Name = "dormChargesLabel";
            this.dormChargesLabel.Size = new System.Drawing.Size(130, 25);
            this.dormChargesLabel.TabIndex = 3;
            this.dormChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealChargeLabel
            // 
            this.mealChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealChargeLabel.Location = new System.Drawing.Point(132, 47);
            this.mealChargeLabel.Name = "mealChargeLabel";
            this.mealChargeLabel.Size = new System.Drawing.Size(130, 25);
            this.mealChargeLabel.TabIndex = 4;
            this.mealChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargesLabel.Location = new System.Drawing.Point(132, 80);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(130, 25);
            this.totalChargesLabel.TabIndex = 5;
            this.totalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.totalChargesLabel);
            this.Controls.Add(this.mealChargeLabel);
            this.Controls.Add(this.dormChargesLabel);
            this.Controls.Add(this.display3Label);
            this.Controls.Add(this.display2Label);
            this.Controls.Add(this.display1Label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display1Label;
        private System.Windows.Forms.Label display2Label;
        private System.Windows.Forms.Label display3Label;
        private System.Windows.Forms.Label dormChargesLabel;
        private System.Windows.Forms.Label mealChargeLabel;
        private System.Windows.Forms.Label totalChargesLabel;
    }
}