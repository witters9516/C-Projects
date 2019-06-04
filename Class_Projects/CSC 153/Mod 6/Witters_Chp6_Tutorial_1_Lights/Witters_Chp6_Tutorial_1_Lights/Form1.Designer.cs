namespace Witters_Chp6_Tutorial_1_Lights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lightsOnPictureBox = new System.Windows.Forms.PictureBox();
            this.lightsOffPictureBox = new System.Windows.Forms.PictureBox();
            this.lightStateLabel = new System.Windows.Forms.Label();
            this.switchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lightsOnPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightsOffPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lightsOnPictureBox
            // 
            this.lightsOnPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lightsOnPictureBox.Image")));
            this.lightsOnPictureBox.Location = new System.Drawing.Point(35, 12);
            this.lightsOnPictureBox.Name = "lightsOnPictureBox";
            this.lightsOnPictureBox.Size = new System.Drawing.Size(112, 190);
            this.lightsOnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lightsOnPictureBox.TabIndex = 0;
            this.lightsOnPictureBox.TabStop = false;
            this.lightsOnPictureBox.Visible = false;
            // 
            // lightsOffPictureBox
            // 
            this.lightsOffPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lightsOffPictureBox.Image")));
            this.lightsOffPictureBox.Location = new System.Drawing.Point(35, 12);
            this.lightsOffPictureBox.Name = "lightsOffPictureBox";
            this.lightsOffPictureBox.Size = new System.Drawing.Size(111, 190);
            this.lightsOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lightsOffPictureBox.TabIndex = 1;
            this.lightsOffPictureBox.TabStop = false;
            this.lightsOffPictureBox.UseWaitCursor = true;
            // 
            // lightStateLabel
            // 
            this.lightStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightStateLabel.Location = new System.Drawing.Point(40, 219);
            this.lightStateLabel.Name = "lightStateLabel";
            this.lightStateLabel.Size = new System.Drawing.Size(100, 23);
            this.lightStateLabel.TabIndex = 2;
            this.lightStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(9, 255);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(75, 23);
            this.switchButton.TabIndex = 3;
            this.switchButton.Text = "Switch Light";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(90, 255);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 288);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.lightStateLabel);
            this.Controls.Add(this.lightsOffPictureBox);
            this.Controls.Add(this.lightsOnPictureBox);
            this.Name = "Form1";
            this.Text = "Lights";
            ((System.ComponentModel.ISupportInitialize)(this.lightsOnPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightsOffPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lightsOnPictureBox;
        private System.Windows.Forms.PictureBox lightsOffPictureBox;
        private System.Windows.Forms.Label lightStateLabel;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

