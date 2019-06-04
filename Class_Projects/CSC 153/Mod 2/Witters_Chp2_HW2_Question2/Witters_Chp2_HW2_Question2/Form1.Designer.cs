namespace Witters_Chp2_HW2_Question2
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
            this.onePictureBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.twoPictureBox = new System.Windows.Forms.PictureBox();
            this.threePictureBox = new System.Windows.Forms.PictureBox();
            this.fourPictureBox = new System.Windows.Forms.PictureBox();
            this.fivePictureBox = new System.Windows.Forms.PictureBox();
            this.numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.onePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // onePictureBox
            // 
            this.onePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("onePictureBox.Image")));
            this.onePictureBox.Location = new System.Drawing.Point(13, 34);
            this.onePictureBox.Name = "onePictureBox";
            this.onePictureBox.Size = new System.Drawing.Size(80, 144);
            this.onePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onePictureBox.TabIndex = 0;
            this.onePictureBox.TabStop = false;
            this.onePictureBox.Click += new System.EventHandler(this.onePictureBox_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(80, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(260, 13);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Click on a number to display the name of that number.";
            // 
            // twoPictureBox
            // 
            this.twoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("twoPictureBox.Image")));
            this.twoPictureBox.Location = new System.Drawing.Point(99, 34);
            this.twoPictureBox.Name = "twoPictureBox";
            this.twoPictureBox.Size = new System.Drawing.Size(80, 144);
            this.twoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twoPictureBox.TabIndex = 2;
            this.twoPictureBox.TabStop = false;
            this.twoPictureBox.Click += new System.EventHandler(this.twoPictureBox_Click);
            // 
            // threePictureBox
            // 
            this.threePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("threePictureBox.Image")));
            this.threePictureBox.Location = new System.Drawing.Point(185, 34);
            this.threePictureBox.Name = "threePictureBox";
            this.threePictureBox.Size = new System.Drawing.Size(80, 144);
            this.threePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.threePictureBox.TabIndex = 3;
            this.threePictureBox.TabStop = false;
            this.threePictureBox.Click += new System.EventHandler(this.threePictureBox_Click);
            // 
            // fourPictureBox
            // 
            this.fourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fourPictureBox.Image")));
            this.fourPictureBox.Location = new System.Drawing.Point(271, 34);
            this.fourPictureBox.Name = "fourPictureBox";
            this.fourPictureBox.Size = new System.Drawing.Size(80, 144);
            this.fourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fourPictureBox.TabIndex = 4;
            this.fourPictureBox.TabStop = false;
            this.fourPictureBox.Click += new System.EventHandler(this.fourPictureBox_Click);
            // 
            // fivePictureBox
            // 
            this.fivePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fivePictureBox.Image")));
            this.fivePictureBox.Location = new System.Drawing.Point(357, 34);
            this.fivePictureBox.Name = "fivePictureBox";
            this.fivePictureBox.Size = new System.Drawing.Size(80, 144);
            this.fivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fivePictureBox.TabIndex = 5;
            this.fivePictureBox.TabStop = false;
            this.fivePictureBox.Click += new System.EventHandler(this.fivePictureBox_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.Location = new System.Drawing.Point(165, 191);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(100, 23);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 262);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.fivePictureBox);
            this.Controls.Add(this.fourPictureBox);
            this.Controls.Add(this.threePictureBox);
            this.Controls.Add(this.twoPictureBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.onePictureBox);
            this.Name = "Form1";
            this.Text = "Clickable Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.onePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox onePictureBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox twoPictureBox;
        private System.Windows.Forms.PictureBox threePictureBox;
        private System.Windows.Forms.PictureBox fourPictureBox;
        private System.Windows.Forms.PictureBox fivePictureBox;
        private System.Windows.Forms.Label numberLabel;
    }
}

