namespace Witters_HW6_4_ColorMixer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.redRadioButton1 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton1 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton1 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton2 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton2 = new System.Windows.Forms.RadioButton();
            this.redRadioButton2 = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yellowRadioButton1);
            this.groupBox1.Controls.Add(this.blueRadioButton1);
            this.groupBox1.Controls.Add(this.redRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the first color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yellowRadioButton2);
            this.groupBox2.Controls.Add(this.blueRadioButton2);
            this.groupBox2.Controls.Add(this.redRadioButton2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the second color";
            // 
            // redRadioButton1
            // 
            this.redRadioButton1.AutoSize = true;
            this.redRadioButton1.Location = new System.Drawing.Point(22, 33);
            this.redRadioButton1.Name = "redRadioButton1";
            this.redRadioButton1.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton1.TabIndex = 0;
            this.redRadioButton1.TabStop = true;
            this.redRadioButton1.Text = "Red";
            this.redRadioButton1.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton1
            // 
            this.blueRadioButton1.AutoSize = true;
            this.blueRadioButton1.Location = new System.Drawing.Point(22, 56);
            this.blueRadioButton1.Name = "blueRadioButton1";
            this.blueRadioButton1.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton1.TabIndex = 1;
            this.blueRadioButton1.TabStop = true;
            this.blueRadioButton1.Text = "Blue";
            this.blueRadioButton1.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton1
            // 
            this.yellowRadioButton1.AutoSize = true;
            this.yellowRadioButton1.Location = new System.Drawing.Point(22, 79);
            this.yellowRadioButton1.Name = "yellowRadioButton1";
            this.yellowRadioButton1.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioButton1.TabIndex = 2;
            this.yellowRadioButton1.TabStop = true;
            this.yellowRadioButton1.Text = "Yellow";
            this.yellowRadioButton1.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton2
            // 
            this.yellowRadioButton2.AutoSize = true;
            this.yellowRadioButton2.Location = new System.Drawing.Point(18, 79);
            this.yellowRadioButton2.Name = "yellowRadioButton2";
            this.yellowRadioButton2.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioButton2.TabIndex = 5;
            this.yellowRadioButton2.TabStop = true;
            this.yellowRadioButton2.Text = "Yellow";
            this.yellowRadioButton2.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton2
            // 
            this.blueRadioButton2.AutoSize = true;
            this.blueRadioButton2.Location = new System.Drawing.Point(18, 56);
            this.blueRadioButton2.Name = "blueRadioButton2";
            this.blueRadioButton2.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton2.TabIndex = 4;
            this.blueRadioButton2.TabStop = true;
            this.blueRadioButton2.Text = "Blue";
            this.blueRadioButton2.UseVisualStyleBackColor = true;
            // 
            // redRadioButton2
            // 
            this.redRadioButton2.AutoSize = true;
            this.redRadioButton2.Location = new System.Drawing.Point(18, 33);
            this.redRadioButton2.Name = "redRadioButton2";
            this.redRadioButton2.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton2.TabIndex = 3;
            this.redRadioButton2.TabStop = true;
            this.redRadioButton2.Text = "Red";
            this.redRadioButton2.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(137, 125);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 125);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 159);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton yellowRadioButton1;
        private System.Windows.Forms.RadioButton blueRadioButton1;
        private System.Windows.Forms.RadioButton redRadioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton yellowRadioButton2;
        private System.Windows.Forms.RadioButton blueRadioButton2;
        private System.Windows.Forms.RadioButton redRadioButton2;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

