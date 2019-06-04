namespace M3Lab_Witter
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
            this.calculateRevenueButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.classATextbox = new System.Windows.Forms.TextBox();
            this.classBTextbox = new System.Windows.Forms.TextBox();
            this.classCTextbox = new System.Windows.Forms.TextBox();
            this.borderLabel1 = new System.Windows.Forms.Label();
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.classALabel1 = new System.Windows.Forms.Label();
            this.classBLabel1 = new System.Windows.Forms.Label();
            this.classCLabel1 = new System.Windows.Forms.Label();
            this.borderLabel2 = new System.Windows.Forms.Label();
            this.classALabel2 = new System.Windows.Forms.Label();
            this.classBLabel2 = new System.Windows.Forms.Label();
            this.classCLabel2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.classAEmptyLabel = new System.Windows.Forms.Label();
            this.classBEmptyLabel = new System.Windows.Forms.Label();
            this.classCEmptyLabel = new System.Windows.Forms.Label();
            this.totalEmptyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateRevenueButton
            // 
            this.calculateRevenueButton.Location = new System.Drawing.Point(91, 166);
            this.calculateRevenueButton.Name = "calculateRevenueButton";
            this.calculateRevenueButton.Size = new System.Drawing.Size(75, 34);
            this.calculateRevenueButton.TabIndex = 0;
            this.calculateRevenueButton.Text = "Calculate Revenue";
            this.calculateRevenueButton.UseVisualStyleBackColor = true;
            this.calculateRevenueButton.Click += new System.EventHandler(this.calculateRevenueButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(172, 166);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 34);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(253, 166);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // classATextbox
            // 
            this.classATextbox.Location = new System.Drawing.Point(93, 76);
            this.classATextbox.Name = "classATextbox";
            this.classATextbox.Size = new System.Drawing.Size(100, 20);
            this.classATextbox.TabIndex = 3;
            // 
            // classBTextbox
            // 
            this.classBTextbox.Location = new System.Drawing.Point(93, 102);
            this.classBTextbox.Name = "classBTextbox";
            this.classBTextbox.Size = new System.Drawing.Size(100, 20);
            this.classBTextbox.TabIndex = 4;
            // 
            // classCTextbox
            // 
            this.classCTextbox.Location = new System.Drawing.Point(93, 127);
            this.classCTextbox.Name = "classCTextbox";
            this.classCTextbox.Size = new System.Drawing.Size(100, 20);
            this.classCTextbox.TabIndex = 5;
            // 
            // borderLabel1
            // 
            this.borderLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borderLabel1.Location = new System.Drawing.Point(12, 9);
            this.borderLabel1.Name = "borderLabel1";
            this.borderLabel1.Size = new System.Drawing.Size(192, 154);
            this.borderLabel1.TabIndex = 6;
            this.borderLabel1.Text = "Tickets Sold";
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.Location = new System.Drawing.Point(27, 36);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(166, 27);
            this.instructionLabel1.TabIndex = 7;
            this.instructionLabel1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // classALabel1
            // 
            this.classALabel1.AutoSize = true;
            this.classALabel1.Location = new System.Drawing.Point(38, 79);
            this.classALabel1.Name = "classALabel1";
            this.classALabel1.Size = new System.Drawing.Size(45, 13);
            this.classALabel1.TabIndex = 8;
            this.classALabel1.Text = "Class A:";
            // 
            // classBLabel1
            // 
            this.classBLabel1.AutoSize = true;
            this.classBLabel1.Location = new System.Drawing.Point(38, 105);
            this.classBLabel1.Name = "classBLabel1";
            this.classBLabel1.Size = new System.Drawing.Size(45, 13);
            this.classBLabel1.TabIndex = 9;
            this.classBLabel1.Text = "Class B:";
            // 
            // classCLabel1
            // 
            this.classCLabel1.AutoSize = true;
            this.classCLabel1.Location = new System.Drawing.Point(38, 130);
            this.classCLabel1.Name = "classCLabel1";
            this.classCLabel1.Size = new System.Drawing.Size(45, 13);
            this.classCLabel1.TabIndex = 10;
            this.classCLabel1.Text = "Class C:";
            // 
            // borderLabel2
            // 
            this.borderLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borderLabel2.Location = new System.Drawing.Point(210, 10);
            this.borderLabel2.Name = "borderLabel2";
            this.borderLabel2.Size = new System.Drawing.Size(179, 153);
            this.borderLabel2.TabIndex = 11;
            this.borderLabel2.Text = "Revenue Generated";
            // 
            // classALabel2
            // 
            this.classALabel2.AutoSize = true;
            this.classALabel2.Location = new System.Drawing.Point(222, 36);
            this.classALabel2.Name = "classALabel2";
            this.classALabel2.Size = new System.Drawing.Size(45, 13);
            this.classALabel2.TabIndex = 12;
            this.classALabel2.Text = "Class A:";
            // 
            // classBLabel2
            // 
            this.classBLabel2.AutoSize = true;
            this.classBLabel2.Location = new System.Drawing.Point(222, 64);
            this.classBLabel2.Name = "classBLabel2";
            this.classBLabel2.Size = new System.Drawing.Size(45, 13);
            this.classBLabel2.TabIndex = 13;
            this.classBLabel2.Text = "Class B:";
            // 
            // classCLabel2
            // 
            this.classCLabel2.AutoSize = true;
            this.classCLabel2.Location = new System.Drawing.Point(222, 92);
            this.classCLabel2.Name = "classCLabel2";
            this.classCLabel2.Size = new System.Drawing.Size(45, 13);
            this.classCLabel2.TabIndex = 14;
            this.classCLabel2.Text = "Class C:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(222, 127);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total:";
            // 
            // classAEmptyLabel
            // 
            this.classAEmptyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classAEmptyLabel.Location = new System.Drawing.Point(273, 33);
            this.classAEmptyLabel.Name = "classAEmptyLabel";
            this.classAEmptyLabel.Size = new System.Drawing.Size(106, 19);
            this.classAEmptyLabel.TabIndex = 16;
            this.classAEmptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classBEmptyLabel
            // 
            this.classBEmptyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBEmptyLabel.Location = new System.Drawing.Point(273, 61);
            this.classBEmptyLabel.Name = "classBEmptyLabel";
            this.classBEmptyLabel.Size = new System.Drawing.Size(106, 19);
            this.classBEmptyLabel.TabIndex = 17;
            this.classBEmptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCEmptyLabel
            // 
            this.classCEmptyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCEmptyLabel.Location = new System.Drawing.Point(273, 89);
            this.classCEmptyLabel.Name = "classCEmptyLabel";
            this.classCEmptyLabel.Size = new System.Drawing.Size(106, 19);
            this.classCEmptyLabel.TabIndex = 18;
            this.classCEmptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalEmptyLabel
            // 
            this.totalEmptyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalEmptyLabel.Location = new System.Drawing.Point(273, 124);
            this.totalEmptyLabel.Name = "totalEmptyLabel";
            this.totalEmptyLabel.Size = new System.Drawing.Size(106, 19);
            this.totalEmptyLabel.TabIndex = 19;
            this.totalEmptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 209);
            this.Controls.Add(this.totalEmptyLabel);
            this.Controls.Add(this.classCEmptyLabel);
            this.Controls.Add(this.classBEmptyLabel);
            this.Controls.Add(this.classAEmptyLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.classCLabel2);
            this.Controls.Add(this.classBLabel2);
            this.Controls.Add(this.classALabel2);
            this.Controls.Add(this.borderLabel2);
            this.Controls.Add(this.classCLabel1);
            this.Controls.Add(this.classBLabel1);
            this.Controls.Add(this.classALabel1);
            this.Controls.Add(this.instructionLabel1);
            this.Controls.Add(this.classCTextbox);
            this.Controls.Add(this.classBTextbox);
            this.Controls.Add(this.classATextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateRevenueButton);
            this.Controls.Add(this.borderLabel1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateRevenueButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox classATextbox;
        private System.Windows.Forms.TextBox classBTextbox;
        private System.Windows.Forms.TextBox classCTextbox;
        private System.Windows.Forms.Label borderLabel1;
        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.Label classALabel1;
        private System.Windows.Forms.Label classBLabel1;
        private System.Windows.Forms.Label classCLabel1;
        private System.Windows.Forms.Label borderLabel2;
        private System.Windows.Forms.Label classALabel2;
        private System.Windows.Forms.Label classBLabel2;
        private System.Windows.Forms.Label classCLabel2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label classAEmptyLabel;
        private System.Windows.Forms.Label classBEmptyLabel;
        private System.Windows.Forms.Label classCEmptyLabel;
        private System.Windows.Forms.Label totalEmptyLabel;
    }
}

