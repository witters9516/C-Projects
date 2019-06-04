namespace DungeonCrawl1_Witter
{
    partial class RoomForm
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
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.roomInfoPanel = new System.Windows.Forms.Panel();
            this.rDescLabel = new System.Windows.Forms.Label();
            this.rNameLabel = new System.Windows.Forms.Label();
            this.rDescDescLabel = new System.Windows.Forms.Label();
            this.rNameDescLabel = new System.Windows.Forms.Label();
            this.RoomInfoDescLabel = new System.Windows.Forms.Label();
            this.roomInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomListBox
            // 
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.Location = new System.Drawing.Point(12, 12);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(141, 147);
            this.roomListBox.TabIndex = 0;
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.roomListBox_SelectedIndexChanged);
            // 
            // roomInfoPanel
            // 
            this.roomInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomInfoPanel.Controls.Add(this.rDescLabel);
            this.roomInfoPanel.Controls.Add(this.rNameLabel);
            this.roomInfoPanel.Controls.Add(this.rDescDescLabel);
            this.roomInfoPanel.Controls.Add(this.rNameDescLabel);
            this.roomInfoPanel.Controls.Add(this.RoomInfoDescLabel);
            this.roomInfoPanel.Location = new System.Drawing.Point(159, 12);
            this.roomInfoPanel.Name = "roomInfoPanel";
            this.roomInfoPanel.Size = new System.Drawing.Size(255, 147);
            this.roomInfoPanel.TabIndex = 1;
            // 
            // rDescLabel
            // 
            this.rDescLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rDescLabel.Location = new System.Drawing.Point(121, 58);
            this.rDescLabel.Name = "rDescLabel";
            this.rDescLabel.Size = new System.Drawing.Size(121, 76);
            this.rDescLabel.TabIndex = 6;
            this.rDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rNameLabel
            // 
            this.rNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rNameLabel.Location = new System.Drawing.Point(121, 29);
            this.rNameLabel.Name = "rNameLabel";
            this.rNameLabel.Size = new System.Drawing.Size(121, 20);
            this.rNameLabel.TabIndex = 4;
            this.rNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rDescDescLabel
            // 
            this.rDescDescLabel.AutoSize = true;
            this.rDescDescLabel.Location = new System.Drawing.Point(21, 62);
            this.rDescDescLabel.Name = "rDescDescLabel";
            this.rDescDescLabel.Size = new System.Drawing.Size(94, 13);
            this.rDescDescLabel.TabIndex = 2;
            this.rDescDescLabel.Text = "Room Description:";
            // 
            // rNameDescLabel
            // 
            this.rNameDescLabel.AutoSize = true;
            this.rNameDescLabel.Location = new System.Drawing.Point(21, 33);
            this.rNameDescLabel.Name = "rNameDescLabel";
            this.rNameDescLabel.Size = new System.Drawing.Size(69, 13);
            this.rNameDescLabel.TabIndex = 1;
            this.rNameDescLabel.Text = "Room Name:";
            // 
            // RoomInfoDescLabel
            // 
            this.RoomInfoDescLabel.AutoSize = true;
            this.RoomInfoDescLabel.Location = new System.Drawing.Point(3, 10);
            this.RoomInfoDescLabel.Name = "RoomInfoDescLabel";
            this.RoomInfoDescLabel.Size = new System.Drawing.Size(93, 13);
            this.RoomInfoDescLabel.TabIndex = 0;
            this.RoomInfoDescLabel.Text = "Room Information:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 172);
            this.Controls.Add(this.roomInfoPanel);
            this.Controls.Add(this.roomListBox);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.roomInfoPanel.ResumeLayout(false);
            this.roomInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Panel roomInfoPanel;
        private System.Windows.Forms.Label rDescLabel;
        private System.Windows.Forms.Label rNameLabel;
        private System.Windows.Forms.Label rDescDescLabel;
        private System.Windows.Forms.Label rNameDescLabel;
        private System.Windows.Forms.Label RoomInfoDescLabel;
    }
}