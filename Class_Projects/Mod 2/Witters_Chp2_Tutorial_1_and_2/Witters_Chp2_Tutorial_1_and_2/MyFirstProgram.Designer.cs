namespace Witters_Chp2_Tutorial_1_and_2
{
    partial class MyFirstProgram
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
            this.MessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageButton
            // 
            this.MessageButton.Location = new System.Drawing.Point(89, 12);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(89, 39);
            this.MessageButton.TabIndex = 0;
            this.MessageButton.Text = "Display Message";
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // MyFirstProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.MessageButton);
            this.Name = "MyFirstProgram";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MessageButton;
    }
}

