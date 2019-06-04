namespace Witters_HW10_10_RockPaperScissors
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
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.ScissorButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.choice2Label = new System.Windows.Forms.Label();
            this.playerChoiceLabel = new System.Windows.Forms.Label();
            this.pScoreLabel = new System.Windows.Forms.Label();
            this.enemyChoiceLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(24, 78);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 23);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(105, 78);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 23);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // ScissorButton
            // 
            this.ScissorButton.Location = new System.Drawing.Point(186, 78);
            this.ScissorButton.Name = "ScissorButton";
            this.ScissorButton.Size = new System.Drawing.Size(75, 23);
            this.ScissorButton.TabIndex = 2;
            this.ScissorButton.Text = "Scissors";
            this.ScissorButton.UseVisualStyleBackColor = true;
            this.ScissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(62, 145);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 23);
            this.playAgainButton.TabIndex = 3;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(143, 145);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your Choice:";
            // 
            // choice2Label
            // 
            this.choice2Label.AutoSize = true;
            this.choice2Label.Location = new System.Drawing.Point(21, 46);
            this.choice2Label.Name = "choice2Label";
            this.choice2Label.Size = new System.Drawing.Size(68, 13);
            this.choice2Label.TabIndex = 6;
            this.choice2Label.Text = "CPU Choice:";
            // 
            // playerChoiceLabel
            // 
            this.playerChoiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerChoiceLabel.Location = new System.Drawing.Point(109, 6);
            this.playerChoiceLabel.Name = "playerChoiceLabel";
            this.playerChoiceLabel.Size = new System.Drawing.Size(91, 26);
            this.playerChoiceLabel.TabIndex = 7;
            this.playerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pScoreLabel
            // 
            this.pScoreLabel.AutoSize = true;
            this.pScoreLabel.Location = new System.Drawing.Point(26, 113);
            this.pScoreLabel.Name = "pScoreLabel";
            this.pScoreLabel.Size = new System.Drawing.Size(63, 13);
            this.pScoreLabel.TabIndex = 9;
            this.pScoreLabel.Text = "Your Score:";
            // 
            // enemyChoiceLabel
            // 
            this.enemyChoiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyChoiceLabel.Location = new System.Drawing.Point(109, 39);
            this.enemyChoiceLabel.Name = "enemyChoiceLabel";
            this.enemyChoiceLabel.Size = new System.Drawing.Size(91, 26);
            this.enemyChoiceLabel.TabIndex = 10;
            this.enemyChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.AutoSize = true;
            this.cpuScoreLabel.Location = new System.Drawing.Point(150, 113);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(63, 13);
            this.cpuScoreLabel.TabIndex = 11;
            this.cpuScoreLabel.Text = "CPU Score:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerScoreLabel.Location = new System.Drawing.Point(95, 106);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(29, 26);
            this.playerScoreLabel.TabIndex = 12;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerScoreLabel.Location = new System.Drawing.Point(219, 106);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(31, 26);
            this.computerScoreLabel.TabIndex = 13;
            this.computerScoreLabel.Text = "0";
            this.computerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.enemyChoiceLabel);
            this.Controls.Add(this.pScoreLabel);
            this.Controls.Add(this.playerChoiceLabel);
            this.Controls.Add(this.choice2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.ScissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button ScissorButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label choice2Label;
        private System.Windows.Forms.Label playerChoiceLabel;
        private System.Windows.Forms.Label pScoreLabel;
        private System.Windows.Forms.Label enemyChoiceLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
    }
}

