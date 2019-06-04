namespace M3PP1_Witter
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
            this.input1Label = new System.Windows.Forms.Label();
            this.input2Label = new System.Windows.Forms.Label();
            this.input3Label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.createPetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.output3Label = new System.Windows.Forms.Label();
            this.output2Label = new System.Windows.Forms.Label();
            this.output1Label = new System.Windows.Forms.Label();
            this.petAgeLabel = new System.Windows.Forms.Label();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1Label
            // 
            this.input1Label.AutoSize = true;
            this.input1Label.Location = new System.Drawing.Point(13, 13);
            this.input1Label.Name = "input1Label";
            this.input1Label.Size = new System.Drawing.Size(57, 13);
            this.input1Label.TabIndex = 0;
            this.input1Label.Text = "Pet Name:";
            // 
            // input2Label
            // 
            this.input2Label.AutoSize = true;
            this.input2Label.Location = new System.Drawing.Point(13, 39);
            this.input2Label.Name = "input2Label";
            this.input2Label.Size = new System.Drawing.Size(53, 13);
            this.input2Label.TabIndex = 1;
            this.input2Label.Text = "Pet Type:";
            // 
            // input3Label
            // 
            this.input3Label.AutoSize = true;
            this.input3Label.Location = new System.Drawing.Point(13, 65);
            this.input3Label.Name = "input3Label";
            this.input3Label.Size = new System.Drawing.Size(48, 13);
            this.input3Label.TabIndex = 2;
            this.input3Label.Text = "Pet Age:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(86, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(86, 36);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(86, 62);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // createPetButton
            // 
            this.createPetButton.Location = new System.Drawing.Point(16, 93);
            this.createPetButton.Name = "createPetButton";
            this.createPetButton.Size = new System.Drawing.Size(75, 23);
            this.createPetButton.TabIndex = 6;
            this.createPetButton.Text = "Create Pet";
            this.createPetButton.UseVisualStyleBackColor = true;
            this.createPetButton.Click += new System.EventHandler(this.createPetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(111, 93);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // output3Label
            // 
            this.output3Label.AutoSize = true;
            this.output3Label.Location = new System.Drawing.Point(13, 205);
            this.output3Label.Name = "output3Label";
            this.output3Label.Size = new System.Drawing.Size(48, 13);
            this.output3Label.TabIndex = 10;
            this.output3Label.Text = "Pet Age:";
            // 
            // output2Label
            // 
            this.output2Label.AutoSize = true;
            this.output2Label.Location = new System.Drawing.Point(13, 169);
            this.output2Label.Name = "output2Label";
            this.output2Label.Size = new System.Drawing.Size(53, 13);
            this.output2Label.TabIndex = 9;
            this.output2Label.Text = "Pet Type:";
            // 
            // output1Label
            // 
            this.output1Label.AutoSize = true;
            this.output1Label.Location = new System.Drawing.Point(13, 136);
            this.output1Label.Name = "output1Label";
            this.output1Label.Size = new System.Drawing.Size(57, 13);
            this.output1Label.TabIndex = 8;
            this.output1Label.Text = "Pet Name:";
            // 
            // petAgeLabel
            // 
            this.petAgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petAgeLabel.Location = new System.Drawing.Point(78, 198);
            this.petAgeLabel.Name = "petAgeLabel";
            this.petAgeLabel.Size = new System.Drawing.Size(108, 26);
            this.petAgeLabel.TabIndex = 13;
            this.petAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTypeLabel.Location = new System.Drawing.Point(78, 162);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(108, 26);
            this.petTypeLabel.TabIndex = 12;
            this.petTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petNameLabel
            // 
            this.petNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petNameLabel.Location = new System.Drawing.Point(78, 129);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(108, 26);
            this.petNameLabel.TabIndex = 11;
            this.petNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 240);
            this.Controls.Add(this.petAgeLabel);
            this.Controls.Add(this.petTypeLabel);
            this.Controls.Add(this.petNameLabel);
            this.Controls.Add(this.output3Label);
            this.Controls.Add(this.output2Label);
            this.Controls.Add(this.output1Label);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createPetButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.input3Label);
            this.Controls.Add(this.input2Label);
            this.Controls.Add(this.input1Label);
            this.Name = "Form1";
            this.Text = "Pet Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input1Label;
        private System.Windows.Forms.Label input2Label;
        private System.Windows.Forms.Label input3Label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button createPetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label output3Label;
        private System.Windows.Forms.Label output2Label;
        private System.Windows.Forms.Label output1Label;
        private System.Windows.Forms.Label petAgeLabel;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label petNameLabel;
    }
}

