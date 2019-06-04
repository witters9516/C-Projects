namespace Witters_Chp6_Tutorial_3_NorthAmerica
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(155, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Countries of North America";
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(16, 29);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(228, 186);
            this.countriesListBox.TabIndex = 1;
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Location = new System.Drawing.Point(16, 221);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(75, 34);
            this.getCountriesButton.TabIndex = 2;
            this.getCountriesButton.Text = "Get Countries";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "North America";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

