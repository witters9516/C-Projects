namespace Witters_Chp6_Tutorial_2_Cards
{
    partial class Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.aceSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.tenHeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.kingClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.showCardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingClubsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardListBox
            // 
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.cardListBox.Location = new System.Drawing.Point(98, 126);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(120, 95);
            this.cardListBox.TabIndex = 0;
            // 
            // aceSpadesPictureBox
            // 
            this.aceSpadesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aceSpadesPictureBox.Image")));
            this.aceSpadesPictureBox.Location = new System.Drawing.Point(12, 12);
            this.aceSpadesPictureBox.Name = "aceSpadesPictureBox";
            this.aceSpadesPictureBox.Size = new System.Drawing.Size(100, 108);
            this.aceSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceSpadesPictureBox.TabIndex = 1;
            this.aceSpadesPictureBox.TabStop = false;
            this.aceSpadesPictureBox.Visible = false;
            // 
            // tenHeartsPictureBox
            // 
            this.tenHeartsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tenHeartsPictureBox.Image")));
            this.tenHeartsPictureBox.Location = new System.Drawing.Point(118, 12);
            this.tenHeartsPictureBox.Name = "tenHeartsPictureBox";
            this.tenHeartsPictureBox.Size = new System.Drawing.Size(100, 108);
            this.tenHeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenHeartsPictureBox.TabIndex = 2;
            this.tenHeartsPictureBox.TabStop = false;
            this.tenHeartsPictureBox.Visible = false;
            // 
            // kingClubsPictureBox
            // 
            this.kingClubsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kingClubsPictureBox.Image")));
            this.kingClubsPictureBox.Location = new System.Drawing.Point(224, 12);
            this.kingClubsPictureBox.Name = "kingClubsPictureBox";
            this.kingClubsPictureBox.Size = new System.Drawing.Size(100, 108);
            this.kingClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingClubsPictureBox.TabIndex = 3;
            this.kingClubsPictureBox.TabStop = false;
            this.kingClubsPictureBox.Visible = false;
            // 
            // showCardButton
            // 
            this.showCardButton.Location = new System.Drawing.Point(72, 227);
            this.showCardButton.Name = "showCardButton";
            this.showCardButton.Size = new System.Drawing.Size(75, 23);
            this.showCardButton.TabIndex = 4;
            this.showCardButton.Text = "Show Card";
            this.showCardButton.UseVisualStyleBackColor = true;
            this.showCardButton.Click += new System.EventHandler(this.showCardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(153, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showCardButton);
            this.Controls.Add(this.kingClubsPictureBox);
            this.Controls.Add(this.tenHeartsPictureBox);
            this.Controls.Add(this.aceSpadesPictureBox);
            this.Controls.Add(this.cardListBox);
            this.Name = "Cards";
            this.Text = "Cards";
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingClubsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.PictureBox aceSpadesPictureBox;
        private System.Windows.Forms.PictureBox tenHeartsPictureBox;
        private System.Windows.Forms.PictureBox kingClubsPictureBox;
        private System.Windows.Forms.Button showCardButton;
        private System.Windows.Forms.Button exitButton;
    }
}

