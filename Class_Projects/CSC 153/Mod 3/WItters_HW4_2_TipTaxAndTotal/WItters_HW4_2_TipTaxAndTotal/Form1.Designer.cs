namespace WItters_HW4_2_TipTaxAndTotal
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.billAmountLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.billPriceLabel2 = new System.Windows.Forms.Label();
            this.billPriceTextbox = new System.Windows.Forms.TextBox();
            this.calculateBillButton = new System.Windows.Forms.Button();
            this.tipLabel = new System.Windows.Forms.Label();
            this.billPrintLabel = new System.Windows.Forms.Label();
            this.taxPrintLabel = new System.Windows.Forms.Label();
            this.tipPrintLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(13, 13);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(286, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter the price of your meal to recieve the sales tax and tip.";
            // 
            // billAmountLabel
            // 
            this.billAmountLabel.AutoSize = true;
            this.billAmountLabel.Location = new System.Drawing.Point(13, 41);
            this.billAmountLabel.Name = "billAmountLabel";
            this.billAmountLabel.Size = new System.Drawing.Size(50, 13);
            this.billAmountLabel.TabIndex = 1;
            this.billAmountLabel.Text = "Bill Price:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(12, 127);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(57, 13);
            this.salesTaxLabel.TabIndex = 2;
            this.salesTaxLabel.Text = "Sales Tax:";
            // 
            // billPriceLabel2
            // 
            this.billPriceLabel2.AutoSize = true;
            this.billPriceLabel2.Location = new System.Drawing.Point(12, 98);
            this.billPriceLabel2.Name = "billPriceLabel2";
            this.billPriceLabel2.Size = new System.Drawing.Size(50, 13);
            this.billPriceLabel2.TabIndex = 3;
            this.billPriceLabel2.Text = "Bill Price:";
            // 
            // billPriceTextbox
            // 
            this.billPriceTextbox.Location = new System.Drawing.Point(168, 41);
            this.billPriceTextbox.Name = "billPriceTextbox";
            this.billPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.billPriceTextbox.TabIndex = 4;
            // 
            // calculateBillButton
            // 
            this.calculateBillButton.Location = new System.Drawing.Point(75, 67);
            this.calculateBillButton.Name = "calculateBillButton";
            this.calculateBillButton.Size = new System.Drawing.Size(75, 23);
            this.calculateBillButton.TabIndex = 5;
            this.calculateBillButton.Text = "Calculate Bill";
            this.calculateBillButton.UseVisualStyleBackColor = true;
            this.calculateBillButton.Click += new System.EventHandler(this.calculateBillButton_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(13, 154);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(25, 13);
            this.tipLabel.TabIndex = 6;
            this.tipLabel.Text = "Tip:";
            // 
            // billPrintLabel
            // 
            this.billPrintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billPrintLabel.Location = new System.Drawing.Point(168, 93);
            this.billPrintLabel.Name = "billPrintLabel";
            this.billPrintLabel.Size = new System.Drawing.Size(100, 23);
            this.billPrintLabel.TabIndex = 7;
            this.billPrintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxPrintLabel
            // 
            this.taxPrintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxPrintLabel.Location = new System.Drawing.Point(168, 122);
            this.taxPrintLabel.Name = "taxPrintLabel";
            this.taxPrintLabel.Size = new System.Drawing.Size(100, 23);
            this.taxPrintLabel.TabIndex = 8;
            this.taxPrintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipPrintLabel
            // 
            this.tipPrintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipPrintLabel.Location = new System.Drawing.Point(168, 149);
            this.tipPrintLabel.Name = "tipPrintLabel";
            this.tipPrintLabel.Size = new System.Drawing.Size(100, 23);
            this.tipPrintLabel.TabIndex = 9;
            this.tipPrintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(156, 67);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 180);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tipPrintLabel);
            this.Controls.Add(this.taxPrintLabel);
            this.Controls.Add(this.billPrintLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.calculateBillButton);
            this.Controls.Add(this.billPriceTextbox);
            this.Controls.Add(this.billPriceLabel2);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.billAmountLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Tip, Tax, and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label billAmountLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label billPriceLabel2;
        private System.Windows.Forms.TextBox billPriceTextbox;
        private System.Windows.Forms.Button calculateBillButton;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label billPrintLabel;
        private System.Windows.Forms.Label taxPrintLabel;
        private System.Windows.Forms.Label tipPrintLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

