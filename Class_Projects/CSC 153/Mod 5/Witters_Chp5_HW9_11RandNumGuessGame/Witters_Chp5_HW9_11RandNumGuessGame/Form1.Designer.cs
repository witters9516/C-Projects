namespace Witters_Chp5_HW9_11RandNumGuessGame
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
            this.guessButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessTextbox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.displayGuessesLabel = new System.Windows.Forms.Label();
            this.numGuessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(15, 63);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(133, 63);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(165, 13);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Guess the random number to win!";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(12, 37);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(92, 13);
            this.guessLabel.TabIndex = 3;
            this.guessLabel.Text = "Number to Guess:";
            // 
            // guessTextbox
            // 
            this.guessTextbox.Location = new System.Drawing.Point(108, 34);
            this.guessTextbox.Name = "guessTextbox";
            this.guessTextbox.Size = new System.Drawing.Size(100, 20);
            this.guessTextbox.TabIndex = 4;
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Location = new System.Drawing.Point(15, 99);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(203, 45);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayGuessesLabel
            // 
            this.displayGuessesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayGuessesLabel.Location = new System.Drawing.Point(118, 152);
            this.displayGuessesLabel.Name = "displayGuessesLabel";
            this.displayGuessesLabel.Size = new System.Drawing.Size(100, 28);
            this.displayGuessesLabel.TabIndex = 6;
            this.displayGuessesLabel.Text = "0";
            this.displayGuessesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numGuessLabel
            // 
            this.numGuessLabel.AutoSize = true;
            this.numGuessLabel.Location = new System.Drawing.Point(12, 160);
            this.numGuessLabel.Name = "numGuessLabel";
            this.numGuessLabel.Size = new System.Drawing.Size(103, 13);
            this.numGuessLabel.TabIndex = 7;
            this.numGuessLabel.Text = "Number of Guesses:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 189);
            this.Controls.Add(this.numGuessLabel);
            this.Controls.Add(this.displayGuessesLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.guessTextbox);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guessButton);
            this.Name = "Form1";
            this.Text = "Random Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox guessTextbox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label displayGuessesLabel;
        private System.Windows.Forms.Label numGuessLabel;
    }
}

