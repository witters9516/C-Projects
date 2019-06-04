namespace M3PP6_Witter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1TopicLabel = new System.Windows.Forms.Label();
            this.allenHallRadioButton = new System.Windows.Forms.RadioButton();
            this.pikeHallRadioButton = new System.Windows.Forms.RadioButton();
            this.farthingHallRadioButton = new System.Windows.Forms.RadioButton();
            this.universitySuitesRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.unlimitedPerWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.fourteenPerWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.sevenPerWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2TopicLabel = new System.Windows.Forms.Label();
            this.calculateChargesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.universitySuitesRadioButton);
            this.panel1.Controls.Add(this.farthingHallRadioButton);
            this.panel1.Controls.Add(this.pikeHallRadioButton);
            this.panel1.Controls.Add(this.allenHallRadioButton);
            this.panel1.Controls.Add(this.panel1TopicLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 131);
            this.panel1.TabIndex = 0;
            // 
            // panel1TopicLabel
            // 
            this.panel1TopicLabel.AutoSize = true;
            this.panel1TopicLabel.Location = new System.Drawing.Point(3, 9);
            this.panel1TopicLabel.Name = "panel1TopicLabel";
            this.panel1TopicLabel.Size = new System.Drawing.Size(83, 13);
            this.panel1TopicLabel.TabIndex = 0;
            this.panel1TopicLabel.Text = "Dormitory Plans:";
            // 
            // allenHallRadioButton
            // 
            this.allenHallRadioButton.AutoSize = true;
            this.allenHallRadioButton.Location = new System.Drawing.Point(27, 30);
            this.allenHallRadioButton.Name = "allenHallRadioButton";
            this.allenHallRadioButton.Size = new System.Drawing.Size(111, 17);
            this.allenHallRadioButton.TabIndex = 1;
            this.allenHallRadioButton.TabStop = true;
            this.allenHallRadioButton.Text = "Allen Hall - $1,500";
            this.allenHallRadioButton.UseVisualStyleBackColor = true;
            this.allenHallRadioButton.CheckedChanged += new System.EventHandler(this.allenHallRadioButton_CheckedChanged);
            // 
            // pikeHallRadioButton
            // 
            this.pikeHallRadioButton.AutoSize = true;
            this.pikeHallRadioButton.Location = new System.Drawing.Point(27, 53);
            this.pikeHallRadioButton.Name = "pikeHallRadioButton";
            this.pikeHallRadioButton.Size = new System.Drawing.Size(109, 17);
            this.pikeHallRadioButton.TabIndex = 2;
            this.pikeHallRadioButton.TabStop = true;
            this.pikeHallRadioButton.Text = "Pike Hall - $1,600";
            this.pikeHallRadioButton.UseVisualStyleBackColor = true;
            this.pikeHallRadioButton.CheckedChanged += new System.EventHandler(this.pikeHallRadioButton_CheckedChanged);
            // 
            // farthingHallRadioButton
            // 
            this.farthingHallRadioButton.AutoSize = true;
            this.farthingHallRadioButton.Location = new System.Drawing.Point(27, 76);
            this.farthingHallRadioButton.Name = "farthingHallRadioButton";
            this.farthingHallRadioButton.Size = new System.Drawing.Size(126, 17);
            this.farthingHallRadioButton.TabIndex = 3;
            this.farthingHallRadioButton.TabStop = true;
            this.farthingHallRadioButton.Text = "Farthing Hall - $1,800";
            this.farthingHallRadioButton.UseVisualStyleBackColor = true;
            this.farthingHallRadioButton.CheckedChanged += new System.EventHandler(this.farthingHallRadioButton_CheckedChanged);
            // 
            // universitySuitesRadioButton
            // 
            this.universitySuitesRadioButton.AutoSize = true;
            this.universitySuitesRadioButton.Location = new System.Drawing.Point(27, 99);
            this.universitySuitesRadioButton.Name = "universitySuitesRadioButton";
            this.universitySuitesRadioButton.Size = new System.Drawing.Size(145, 17);
            this.universitySuitesRadioButton.TabIndex = 4;
            this.universitySuitesRadioButton.TabStop = true;
            this.universitySuitesRadioButton.Text = "University Suites - $2,500";
            this.universitySuitesRadioButton.UseVisualStyleBackColor = true;
            this.universitySuitesRadioButton.CheckedChanged += new System.EventHandler(this.universitySuitesRadioButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.unlimitedPerWeekRadioButton);
            this.panel2.Controls.Add(this.fourteenPerWeekRadioButton);
            this.panel2.Controls.Add(this.sevenPerWeekRadioButton);
            this.panel2.Controls.Add(this.panel2TopicLabel);
            this.panel2.Location = new System.Drawing.Point(203, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 131);
            this.panel2.TabIndex = 5;
            // 
            // unlimitedPerWeekRadioButton
            // 
            this.unlimitedPerWeekRadioButton.AutoSize = true;
            this.unlimitedPerWeekRadioButton.Location = new System.Drawing.Point(27, 89);
            this.unlimitedPerWeekRadioButton.Name = "unlimitedPerWeekRadioButton";
            this.unlimitedPerWeekRadioButton.Size = new System.Drawing.Size(140, 17);
            this.unlimitedPerWeekRadioButton.TabIndex = 3;
            this.unlimitedPerWeekRadioButton.TabStop = true;
            this.unlimitedPerWeekRadioButton.Text = "Unlimited meals - $1,700";
            this.unlimitedPerWeekRadioButton.UseVisualStyleBackColor = true;
            this.unlimitedPerWeekRadioButton.CheckedChanged += new System.EventHandler(this.unlimitedPerWeekRadioButton_CheckedChanged);
            // 
            // fourteenPerWeekRadioButton
            // 
            this.fourteenPerWeekRadioButton.AutoSize = true;
            this.fourteenPerWeekRadioButton.Location = new System.Drawing.Point(27, 59);
            this.fourteenPerWeekRadioButton.Name = "fourteenPerWeekRadioButton";
            this.fourteenPerWeekRadioButton.Size = new System.Drawing.Size(157, 17);
            this.fourteenPerWeekRadioButton.TabIndex = 2;
            this.fourteenPerWeekRadioButton.TabStop = true;
            this.fourteenPerWeekRadioButton.Text = "14 Meals per week - $1,200";
            this.fourteenPerWeekRadioButton.UseVisualStyleBackColor = true;
            this.fourteenPerWeekRadioButton.CheckedChanged += new System.EventHandler(this.fourteenPerWeekRadioButton_CheckedChanged);
            // 
            // sevenPerWeekRadioButton
            // 
            this.sevenPerWeekRadioButton.AutoSize = true;
            this.sevenPerWeekRadioButton.Location = new System.Drawing.Point(27, 30);
            this.sevenPerWeekRadioButton.Name = "sevenPerWeekRadioButton";
            this.sevenPerWeekRadioButton.Size = new System.Drawing.Size(142, 17);
            this.sevenPerWeekRadioButton.TabIndex = 1;
            this.sevenPerWeekRadioButton.TabStop = true;
            this.sevenPerWeekRadioButton.Text = "7 Meals per week - $600";
            this.sevenPerWeekRadioButton.UseVisualStyleBackColor = true;
            this.sevenPerWeekRadioButton.CheckedChanged += new System.EventHandler(this.sevenPerWeekRadioButton_CheckedChanged);
            // 
            // panel2TopicLabel
            // 
            this.panel2TopicLabel.AutoSize = true;
            this.panel2TopicLabel.Location = new System.Drawing.Point(3, 9);
            this.panel2TopicLabel.Name = "panel2TopicLabel";
            this.panel2TopicLabel.Size = new System.Drawing.Size(62, 13);
            this.panel2TopicLabel.TabIndex = 0;
            this.panel2TopicLabel.Text = "Meal Plans:";
            // 
            // calculateChargesButton
            // 
            this.calculateChargesButton.Location = new System.Drawing.Point(122, 150);
            this.calculateChargesButton.Name = "calculateChargesButton";
            this.calculateChargesButton.Size = new System.Drawing.Size(75, 23);
            this.calculateChargesButton.TabIndex = 6;
            this.calculateChargesButton.Text = "Calculate Charges";
            this.calculateChargesButton.UseVisualStyleBackColor = true;
            this.calculateChargesButton.Click += new System.EventHandler(this.calculateChargesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 150);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 203);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateChargesButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton universitySuitesRadioButton;
        private System.Windows.Forms.RadioButton farthingHallRadioButton;
        private System.Windows.Forms.RadioButton pikeHallRadioButton;
        private System.Windows.Forms.RadioButton allenHallRadioButton;
        private System.Windows.Forms.Label panel1TopicLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton unlimitedPerWeekRadioButton;
        private System.Windows.Forms.RadioButton fourteenPerWeekRadioButton;
        private System.Windows.Forms.RadioButton sevenPerWeekRadioButton;
        private System.Windows.Forms.Label panel2TopicLabel;
        private System.Windows.Forms.Button calculateChargesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

