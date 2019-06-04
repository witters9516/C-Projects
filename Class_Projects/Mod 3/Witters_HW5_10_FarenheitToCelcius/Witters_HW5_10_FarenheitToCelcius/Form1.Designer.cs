namespace Witters_HW5_10_FarenheitToCelcius
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
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.totalCaloriesCountedLabel = new System.Windows.Forms.Label();
            this.bananaPicturebox = new System.Windows.Forms.PictureBox();
            this.applePicturebox = new System.Windows.Forms.PictureBox();
            this.orangePicturebox = new System.Windows.Forms.PictureBox();
            this.pearPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(280, 72);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(347, 101);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(317, 13);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(71, 13);
            this.totalCaloriesLabel.TabIndex = 2;
            this.totalCaloriesLabel.Text = "Total Calories";
            // 
            // totalCaloriesCountedLabel
            // 
            this.totalCaloriesCountedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCaloriesCountedLabel.Location = new System.Drawing.Point(280, 36);
            this.totalCaloriesCountedLabel.Name = "totalCaloriesCountedLabel";
            this.totalCaloriesCountedLabel.Size = new System.Drawing.Size(142, 22);
            this.totalCaloriesCountedLabel.TabIndex = 3;
            this.totalCaloriesCountedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bananaPicturebox
            // 
            this.bananaPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("bananaPicturebox.Image")));
            this.bananaPicturebox.Location = new System.Drawing.Point(13, 13);
            this.bananaPicturebox.Name = "bananaPicturebox";
            this.bananaPicturebox.Size = new System.Drawing.Size(128, 155);
            this.bananaPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bananaPicturebox.TabIndex = 4;
            this.bananaPicturebox.TabStop = false;
            this.bananaPicturebox.Click += new System.EventHandler(this.bananaPicturebox_Click);
            // 
            // applePicturebox
            // 
            this.applePicturebox.Image = ((System.Drawing.Image)(resources.GetObject("applePicturebox.Image")));
            this.applePicturebox.Location = new System.Drawing.Point(146, 13);
            this.applePicturebox.Name = "applePicturebox";
            this.applePicturebox.Size = new System.Drawing.Size(128, 155);
            this.applePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.applePicturebox.TabIndex = 5;
            this.applePicturebox.TabStop = false;
            this.applePicturebox.Click += new System.EventHandler(this.applePicturebox_Click);
            // 
            // orangePicturebox
            // 
            this.orangePicturebox.Image = ((System.Drawing.Image)(resources.GetObject("orangePicturebox.Image")));
            this.orangePicturebox.Location = new System.Drawing.Point(12, 174);
            this.orangePicturebox.Name = "orangePicturebox";
            this.orangePicturebox.Size = new System.Drawing.Size(128, 155);
            this.orangePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orangePicturebox.TabIndex = 6;
            this.orangePicturebox.TabStop = false;
            this.orangePicturebox.Click += new System.EventHandler(this.orangePicturebox_Click);
            // 
            // pearPicturebox
            // 
            this.pearPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("pearPicturebox.Image")));
            this.pearPicturebox.Location = new System.Drawing.Point(146, 174);
            this.pearPicturebox.Name = "pearPicturebox";
            this.pearPicturebox.Size = new System.Drawing.Size(128, 155);
            this.pearPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pearPicturebox.TabIndex = 7;
            this.pearPicturebox.TabStop = false;
            this.pearPicturebox.Click += new System.EventHandler(this.pearPicturebox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 335);
            this.Controls.Add(this.pearPicturebox);
            this.Controls.Add(this.orangePicturebox);
            this.Controls.Add(this.applePicturebox);
            this.Controls.Add(this.bananaPicturebox);
            this.Controls.Add(this.totalCaloriesCountedLabel);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.bananaPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label totalCaloriesCountedLabel;
        private System.Windows.Forms.PictureBox bananaPicturebox;
        private System.Windows.Forms.PictureBox applePicturebox;
        private System.Windows.Forms.PictureBox orangePicturebox;
        private System.Windows.Forms.PictureBox pearPicturebox;
    }
}

