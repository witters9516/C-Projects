namespace Witters_HW4_1_NameFormatter
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.preffedTitleNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.middleNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.preferredTitleTextbox = new System.Windows.Forms.TextBox();
            this.FullWTitleButton = new System.Windows.Forms.Button();
            this.FullWOTitleButton = new System.Windows.Forms.Button();
            this.firstAndLastButton = new System.Windows.Forms.Button();
            this.lastFirstMiddlePreferredTitleButton = new System.Windows.Forms.Button();
            this.lastFirstMiddleButton = new System.Windows.Forms.Button();
            this.lastFirstButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(277, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter the following information to see the name displayed.";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(12, 63);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(72, 13);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 89);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // preffedTitleNameLabel
            // 
            this.preffedTitleNameLabel.AutoSize = true;
            this.preffedTitleNameLabel.Location = new System.Drawing.Point(12, 115);
            this.preffedTitleNameLabel.Name = "preffedTitleNameLabel";
            this.preffedTitleNameLabel.Size = new System.Drawing.Size(76, 13);
            this.preffedTitleNameLabel.TabIndex = 4;
            this.preffedTitleNameLabel.Text = "Preferred Title:";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(152, 34);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextbox.TabIndex = 5;
            // 
            // middleNameTextbox
            // 
            this.middleNameTextbox.Location = new System.Drawing.Point(152, 60);
            this.middleNameTextbox.Name = "middleNameTextbox";
            this.middleNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextbox.TabIndex = 6;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(152, 86);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextbox.TabIndex = 7;
            // 
            // preferredTitleTextbox
            // 
            this.preferredTitleTextbox.Location = new System.Drawing.Point(152, 112);
            this.preferredTitleTextbox.Name = "preferredTitleTextbox";
            this.preferredTitleTextbox.Size = new System.Drawing.Size(100, 20);
            this.preferredTitleTextbox.TabIndex = 8;
            // 
            // FullWTitleButton
            // 
            this.FullWTitleButton.Location = new System.Drawing.Point(15, 182);
            this.FullWTitleButton.Name = "FullWTitleButton";
            this.FullWTitleButton.Size = new System.Drawing.Size(75, 34);
            this.FullWTitleButton.TabIndex = 9;
            this.FullWTitleButton.Text = "Full Name With Title";
            this.FullWTitleButton.UseVisualStyleBackColor = true;
            this.FullWTitleButton.Click += new System.EventHandler(this.FullWTitleButton_Click);
            // 
            // FullWOTitleButton
            // 
            this.FullWOTitleButton.Location = new System.Drawing.Point(96, 182);
            this.FullWOTitleButton.Name = "FullWOTitleButton";
            this.FullWOTitleButton.Size = new System.Drawing.Size(75, 34);
            this.FullWOTitleButton.TabIndex = 10;
            this.FullWOTitleButton.Text = "Full Name Without Title";
            this.FullWOTitleButton.UseVisualStyleBackColor = true;
            this.FullWOTitleButton.Click += new System.EventHandler(this.FullWOTitleButton_Click);
            // 
            // firstAndLastButton
            // 
            this.firstAndLastButton.Location = new System.Drawing.Point(177, 182);
            this.firstAndLastButton.Name = "firstAndLastButton";
            this.firstAndLastButton.Size = new System.Drawing.Size(75, 34);
            this.firstAndLastButton.TabIndex = 11;
            this.firstAndLastButton.Text = "First and Last Name";
            this.firstAndLastButton.UseVisualStyleBackColor = true;
            this.firstAndLastButton.Click += new System.EventHandler(this.firstAndLastButton_Click);
            // 
            // lastFirstMiddlePreferredTitleButton
            // 
            this.lastFirstMiddlePreferredTitleButton.Location = new System.Drawing.Point(15, 222);
            this.lastFirstMiddlePreferredTitleButton.Name = "lastFirstMiddlePreferredTitleButton";
            this.lastFirstMiddlePreferredTitleButton.Size = new System.Drawing.Size(75, 66);
            this.lastFirstMiddlePreferredTitleButton.TabIndex = 12;
            this.lastFirstMiddlePreferredTitleButton.Text = "Last, First and Middle, Preferred Title";
            this.lastFirstMiddlePreferredTitleButton.UseVisualStyleBackColor = true;
            this.lastFirstMiddlePreferredTitleButton.Click += new System.EventHandler(this.lastFirstMiddlePreferredTitleButton_Click);
            // 
            // lastFirstMiddleButton
            // 
            this.lastFirstMiddleButton.Location = new System.Drawing.Point(96, 222);
            this.lastFirstMiddleButton.Name = "lastFirstMiddleButton";
            this.lastFirstMiddleButton.Size = new System.Drawing.Size(75, 34);
            this.lastFirstMiddleButton.TabIndex = 13;
            this.lastFirstMiddleButton.Text = "Last, First and Middle";
            this.lastFirstMiddleButton.UseVisualStyleBackColor = true;
            this.lastFirstMiddleButton.Click += new System.EventHandler(this.lastFirstMiddleButton_Click);
            // 
            // lastFirstButton
            // 
            this.lastFirstButton.Location = new System.Drawing.Point(177, 222);
            this.lastFirstButton.Name = "lastFirstButton";
            this.lastFirstButton.Size = new System.Drawing.Size(75, 34);
            this.lastFirstButton.TabIndex = 14;
            this.lastFirstButton.Text = "Last, First Name";
            this.lastFirstButton.UseVisualStyleBackColor = true;
            this.lastFirstButton.Click += new System.EventHandler(this.lastFirstButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(96, 262);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 26);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Location = new System.Drawing.Point(15, 147);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(237, 23);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 300);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lastFirstButton);
            this.Controls.Add(this.lastFirstMiddleButton);
            this.Controls.Add(this.lastFirstMiddlePreferredTitleButton);
            this.Controls.Add(this.firstAndLastButton);
            this.Controls.Add(this.FullWOTitleButton);
            this.Controls.Add(this.FullWTitleButton);
            this.Controls.Add(this.preferredTitleTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.middleNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.preffedTitleNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Name Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label preffedTitleNameLabel;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox middleNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox preferredTitleTextbox;
        private System.Windows.Forms.Button FullWTitleButton;
        private System.Windows.Forms.Button FullWOTitleButton;
        private System.Windows.Forms.Button firstAndLastButton;
        private System.Windows.Forms.Button lastFirstMiddlePreferredTitleButton;
        private System.Windows.Forms.Button lastFirstMiddleButton;
        private System.Windows.Forms.Button lastFirstButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nameLabel;
    }
}

