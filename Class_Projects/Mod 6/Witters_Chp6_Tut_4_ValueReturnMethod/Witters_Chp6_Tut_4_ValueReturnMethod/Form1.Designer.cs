namespace Witters_Chp6_Tut_4_ValueReturnMethod
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.cupsLabel = new System.Windows.Forms.Label();
            this.fluidOuncesLabel = new System.Windows.Forms.Label();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.cupsTextbox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(225, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Cups to Fluid Ounces Converter";
            // 
            // cupsLabel
            // 
            this.cupsLabel.AutoSize = true;
            this.cupsLabel.Location = new System.Drawing.Point(13, 37);
            this.cupsLabel.Name = "cupsLabel";
            this.cupsLabel.Size = new System.Drawing.Size(34, 13);
            this.cupsLabel.TabIndex = 1;
            this.cupsLabel.Text = "Cups:";
            // 
            // fluidOuncesLabel
            // 
            this.fluidOuncesLabel.AutoSize = true;
            this.fluidOuncesLabel.Location = new System.Drawing.Point(12, 73);
            this.fluidOuncesLabel.Name = "fluidOuncesLabel";
            this.fluidOuncesLabel.Size = new System.Drawing.Size(72, 13);
            this.fluidOuncesLabel.TabIndex = 2;
            this.fluidOuncesLabel.Text = "Fluid Ounces:";
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Location = new System.Drawing.Point(105, 65);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(100, 29);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cupsTextbox
            // 
            this.cupsTextbox.Location = new System.Drawing.Point(105, 34);
            this.cupsTextbox.Name = "cupsTextbox";
            this.cupsTextbox.Size = new System.Drawing.Size(100, 20);
            this.cupsTextbox.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(16, 107);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(89, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(121, 107);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 139);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.cupsTextbox);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.fluidOuncesLabel);
            this.Controls.Add(this.cupsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Cups To Ounces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label cupsLabel;
        private System.Windows.Forms.Label fluidOuncesLabel;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.TextBox cupsTextbox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

