namespace Witters_Chp2_Tutorial_5
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
            this.cardBackButton = new System.Windows.Forms.PictureBox();
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBackButton
            // 
            this.cardBackButton.Image = ((System.Drawing.Image)(resources.GetObject("cardBackButton.Image")));
            this.cardBackButton.Location = new System.Drawing.Point(13, 13);
            this.cardBackButton.Name = "cardBackButton";
            this.cardBackButton.Size = new System.Drawing.Size(100, 140);
            this.cardBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackButton.TabIndex = 0;
            this.cardBackButton.TabStop = false;
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardFacePictureBox.Image")));
            this.cardFacePictureBox.Location = new System.Drawing.Point(120, 13);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(100, 140);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePictureBox.TabIndex = 1;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(13, 159);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(100, 39);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "Show the Card Back";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Location = new System.Drawing.Point(120, 159);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(100, 39);
            this.showFaceButton.TabIndex = 3;
            this.showFaceButton.Text = "Show the Card Face";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 208);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackButton);
            this.Name = "Form1";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackButton;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
    }
}

