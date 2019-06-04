namespace Witters_Chp5_Tutorial_8_CoinToss
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
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tailsPicturebox = new System.Windows.Forms.PictureBox();
            this.headsPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(19, 189);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(75, 23);
            this.tossButton.TabIndex = 0;
            this.tossButton.Text = "Toss";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(114, 189);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tailsPicturebox
            // 
            this.tailsPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPicturebox.Image")));
            this.tailsPicturebox.Location = new System.Drawing.Point(19, 13);
            this.tailsPicturebox.Name = "tailsPicturebox";
            this.tailsPicturebox.Size = new System.Drawing.Size(170, 170);
            this.tailsPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPicturebox.TabIndex = 3;
            this.tailsPicturebox.TabStop = false;
            this.tailsPicturebox.Visible = false;
            // 
            // headsPicturebox
            // 
            this.headsPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("headsPicturebox.Image")));
            this.headsPicturebox.Location = new System.Drawing.Point(19, 12);
            this.headsPicturebox.Name = "headsPicturebox";
            this.headsPicturebox.Size = new System.Drawing.Size(170, 170);
            this.headsPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPicturebox.TabIndex = 4;
            this.headsPicturebox.TabStop = false;
            this.headsPicturebox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 225);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.headsPicturebox);
            this.Controls.Add(this.tailsPicturebox);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox tailsPicturebox;
        private System.Windows.Forms.PictureBox headsPicturebox;
    }
}

