namespace Witters_HW8_2DistanceFile
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
            this.hoursTextbox = new System.Windows.Forms.TextBox();
            this.speedTextbox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursTextbox
            // 
            this.hoursTextbox.Location = new System.Drawing.Point(153, 40);
            this.hoursTextbox.Name = "hoursTextbox";
            this.hoursTextbox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextbox.TabIndex = 14;
            // 
            // speedTextbox
            // 
            this.speedTextbox.Location = new System.Drawing.Point(153, 14);
            this.speedTextbox.Name = "speedTextbox";
            this.speedTextbox.Size = new System.Drawing.Size(100, 20);
            this.speedTextbox.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 70);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(17, 70);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 11;
            this.writeButton.Text = "Write To File";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hours Traveled:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicle Speed in MPH:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.hoursTextbox);
            this.Controls.Add(this.speedTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoursTextbox;
        private System.Windows.Forms.TextBox speedTextbox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

