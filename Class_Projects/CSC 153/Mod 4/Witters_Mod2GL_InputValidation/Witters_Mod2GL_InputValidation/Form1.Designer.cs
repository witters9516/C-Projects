namespace Witters_Mod2GL_InputValidation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DOBYearTextbox = new System.Windows.Forms.TextBox();
            this.DOBMonthTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.DOBDayTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Year (yyyy):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Month (mm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Day (dd):";
            // 
            // DOBYearTextbox
            // 
            this.DOBYearTextbox.Location = new System.Drawing.Point(261, 82);
            this.DOBYearTextbox.MaxLength = 4;
            this.DOBYearTextbox.Name = "DOBYearTextbox";
            this.DOBYearTextbox.Size = new System.Drawing.Size(43, 20);
            this.DOBYearTextbox.TabIndex = 24;
            // 
            // DOBMonthTextbox
            // 
            this.DOBMonthTextbox.Location = new System.Drawing.Point(164, 82);
            this.DOBMonthTextbox.MaxLength = 2;
            this.DOBMonthTextbox.Name = "DOBMonthTextbox";
            this.DOBMonthTextbox.Size = new System.Drawing.Size(32, 20);
            this.DOBMonthTextbox.TabIndex = 23;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(169, 140);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(88, 140);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(63, 109);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox.TabIndex = 20;
            // 
            // DOBDayTextbox
            // 
            this.DOBDayTextbox.Location = new System.Drawing.Point(65, 82);
            this.DOBDayTextbox.MaxLength = 2;
            this.DOBDayTextbox.Name = "DOBDayTextbox";
            this.DOBDayTextbox.Size = new System.Drawing.Size(32, 20);
            this.DOBDayTextbox.TabIndex = 19;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(51, 33);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 18;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 112);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "E-mail";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(10, 62);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(66, 13);
            this.birthdayLabel.TabIndex = 16;
            this.birthdayLabel.Text = "Date of Birth";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(10, 7);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(317, 13);
            this.instructionLabel.TabIndex = 14;
            this.instructionLabel.Text = "Please update your information to continue creating your account.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOBYearTextbox);
            this.Controls.Add(this.DOBMonthTextbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.DOBDayTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DOBYearTextbox;
        private System.Windows.Forms.TextBox DOBMonthTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox DOBDayTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label instructionLabel;
    }
}

