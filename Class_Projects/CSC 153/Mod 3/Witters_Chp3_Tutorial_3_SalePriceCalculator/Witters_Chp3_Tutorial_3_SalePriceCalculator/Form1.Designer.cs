namespace Witters_Chp3_Tutorial_3_SalePriceCalculator
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
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.originalPriceTextbox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.AutoSize = true;
            this.originalPricePromptLabel.Location = new System.Drawing.Point(22, 13);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(144, 13);
            this.originalPricePromptLabel.TabIndex = 0;
            this.originalPricePromptLabel.Text = "Enter the item\'s original price:";
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(13, 40);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(153, 13);
            this.discPercentagePromptLabel.TabIndex = 1;
            this.discPercentagePromptLabel.Text = "Enter the discount percentage:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(109, 78);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Sale price:";
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Location = new System.Drawing.Point(172, 73);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(100, 23);
            this.salePriceLabel.TabIndex = 3;
            this.salePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // originalPriceTextbox
            // 
            this.originalPriceTextbox.Location = new System.Drawing.Point(172, 10);
            this.originalPriceTextbox.Name = "originalPriceTextbox";
            this.originalPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.originalPriceTextbox.TabIndex = 4;
            // 
            // discountPercentageTextbox
            // 
            this.discountPercentageTextbox.Location = new System.Drawing.Point(172, 37);
            this.discountPercentageTextbox.Name = "discountPercentageTextbox";
            this.discountPercentageTextbox.Size = new System.Drawing.Size(100, 20);
            this.discountPercentageTextbox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(48, 107);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 41);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Sale Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(129, 107);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 41);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.discountPercentageTextbox);
            this.Controls.Add(this.originalPriceTextbox);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalPricePromptLabel;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.TextBox originalPriceTextbox;
        private System.Windows.Forms.TextBox discountPercentageTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

