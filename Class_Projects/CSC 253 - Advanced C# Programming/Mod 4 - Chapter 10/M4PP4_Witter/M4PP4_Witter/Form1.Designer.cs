namespace M4PP4_Witter
{
    partial class PersonAndCustomerClass
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
            this.inputDescLabel = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.inputLabel4 = new System.Windows.Forms.Label();
            this.inputLabel5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.teleNumTextBox = new System.Windows.Forms.TextBox();
            this.cusNumTextBox = new System.Windows.Forms.TextBox();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.ouputLabel5 = new System.Windows.Forms.Label();
            this.ouputLabel4 = new System.Windows.Forms.Label();
            this.ouputLabel3 = new System.Windows.Forms.Label();
            this.ouputLabel2 = new System.Windows.Forms.Label();
            this.ouputLabel1 = new System.Windows.Forms.Label();
            this.outputDescLabel = new System.Windows.Forms.Label();
            this.cusNameDisplayLabel = new System.Windows.Forms.Label();
            this.cusAddressDisplayLabel = new System.Windows.Forms.Label();
            this.cusTeleNumberDisplayLabel = new System.Windows.Forms.Label();
            this.cusNumberDisplayLabel = new System.Windows.Forms.Label();
            this.cusMailListDisplayLabel = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDescLabel
            // 
            this.inputDescLabel.AutoSize = true;
            this.inputDescLabel.Location = new System.Drawing.Point(15, 11);
            this.inputDescLabel.Name = "inputDescLabel";
            this.inputDescLabel.Size = new System.Drawing.Size(155, 13);
            this.inputDescLabel.TabIndex = 0;
            this.inputDescLabel.Text = "Enter the Customer Information:";
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.exitButton);
            this.InputPanel.Controls.Add(this.createCustomerButton);
            this.InputPanel.Controls.Add(this.noRadioButton);
            this.InputPanel.Controls.Add(this.yesRadioButton);
            this.InputPanel.Controls.Add(this.cusNumTextBox);
            this.InputPanel.Controls.Add(this.teleNumTextBox);
            this.InputPanel.Controls.Add(this.addressTextBox);
            this.InputPanel.Controls.Add(this.nameTextBox);
            this.InputPanel.Controls.Add(this.inputLabel5);
            this.InputPanel.Controls.Add(this.inputLabel4);
            this.InputPanel.Controls.Add(this.inputLabel3);
            this.InputPanel.Controls.Add(this.inputLabel2);
            this.InputPanel.Controls.Add(this.inputLabel1);
            this.InputPanel.Controls.Add(this.inputDescLabel);
            this.InputPanel.Location = new System.Drawing.Point(13, 13);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(270, 225);
            this.InputPanel.TabIndex = 1;
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Location = new System.Drawing.Point(3, 35);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(85, 13);
            this.inputLabel1.TabIndex = 1;
            this.inputLabel1.Text = "Customer Name:";
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(3, 62);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(95, 13);
            this.inputLabel2.TabIndex = 2;
            this.inputLabel2.Text = "Customer Address:";
            // 
            // inputLabel3
            // 
            this.inputLabel3.AutoSize = true;
            this.inputLabel3.Location = new System.Drawing.Point(3, 89);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(148, 13);
            this.inputLabel3.TabIndex = 3;
            this.inputLabel3.Text = "Customer Telephone Number:";
            // 
            // inputLabel4
            // 
            this.inputLabel4.AutoSize = true;
            this.inputLabel4.Location = new System.Drawing.Point(3, 117);
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Size = new System.Drawing.Size(94, 13);
            this.inputLabel4.TabIndex = 4;
            this.inputLabel4.Text = "Customer Number:";
            // 
            // inputLabel5
            // 
            this.inputLabel5.AutoSize = true;
            this.inputLabel5.Location = new System.Drawing.Point(3, 145);
            this.inputLabel5.Name = "inputLabel5";
            this.inputLabel5.Size = new System.Drawing.Size(84, 13);
            this.inputLabel5.TabIndex = 5;
            this.inputLabel5.Text = "Join Mailing List:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(160, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(160, 59);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // teleNumTextBox
            // 
            this.teleNumTextBox.Location = new System.Drawing.Point(160, 86);
            this.teleNumTextBox.Name = "teleNumTextBox";
            this.teleNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.teleNumTextBox.TabIndex = 8;
            // 
            // cusNumTextBox
            // 
            this.cusNumTextBox.Location = new System.Drawing.Point(160, 114);
            this.cusNumTextBox.Name = "cusNumTextBox";
            this.cusNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.cusNumTextBox.TabIndex = 9;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Checked = true;
            this.yesRadioButton.Location = new System.Drawing.Point(160, 143);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 10;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(217, 143);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 11;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Location = new System.Drawing.Point(76, 171);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(75, 35);
            this.createCustomerButton.TabIndex = 12;
            this.createCustomerButton.Text = "Create Customer";
            this.createCustomerButton.UseVisualStyleBackColor = true;
            this.createCustomerButton.Click += new System.EventHandler(this.createCustomerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(160, 171);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OutputPanel
            // 
            this.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPanel.Controls.Add(this.cusMailListDisplayLabel);
            this.OutputPanel.Controls.Add(this.cusNumberDisplayLabel);
            this.OutputPanel.Controls.Add(this.cusTeleNumberDisplayLabel);
            this.OutputPanel.Controls.Add(this.cusAddressDisplayLabel);
            this.OutputPanel.Controls.Add(this.cusNameDisplayLabel);
            this.OutputPanel.Controls.Add(this.ouputLabel5);
            this.OutputPanel.Controls.Add(this.ouputLabel4);
            this.OutputPanel.Controls.Add(this.ouputLabel3);
            this.OutputPanel.Controls.Add(this.ouputLabel2);
            this.OutputPanel.Controls.Add(this.ouputLabel1);
            this.OutputPanel.Controls.Add(this.outputDescLabel);
            this.OutputPanel.Location = new System.Drawing.Point(289, 13);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(270, 225);
            this.OutputPanel.TabIndex = 14;
            // 
            // ouputLabel5
            // 
            this.ouputLabel5.AutoSize = true;
            this.ouputLabel5.Location = new System.Drawing.Point(3, 145);
            this.ouputLabel5.Name = "ouputLabel5";
            this.ouputLabel5.Size = new System.Drawing.Size(84, 13);
            this.ouputLabel5.TabIndex = 5;
            this.ouputLabel5.Text = "Join Mailing List:";
            // 
            // ouputLabel4
            // 
            this.ouputLabel4.AutoSize = true;
            this.ouputLabel4.Location = new System.Drawing.Point(3, 117);
            this.ouputLabel4.Name = "ouputLabel4";
            this.ouputLabel4.Size = new System.Drawing.Size(94, 13);
            this.ouputLabel4.TabIndex = 4;
            this.ouputLabel4.Text = "Customer Number:";
            // 
            // ouputLabel3
            // 
            this.ouputLabel3.AutoSize = true;
            this.ouputLabel3.Location = new System.Drawing.Point(3, 89);
            this.ouputLabel3.Name = "ouputLabel3";
            this.ouputLabel3.Size = new System.Drawing.Size(148, 13);
            this.ouputLabel3.TabIndex = 3;
            this.ouputLabel3.Text = "Customer Telephone Number:";
            // 
            // ouputLabel2
            // 
            this.ouputLabel2.AutoSize = true;
            this.ouputLabel2.Location = new System.Drawing.Point(3, 62);
            this.ouputLabel2.Name = "ouputLabel2";
            this.ouputLabel2.Size = new System.Drawing.Size(95, 13);
            this.ouputLabel2.TabIndex = 2;
            this.ouputLabel2.Text = "Customer Address:";
            // 
            // ouputLabel1
            // 
            this.ouputLabel1.AutoSize = true;
            this.ouputLabel1.Location = new System.Drawing.Point(3, 35);
            this.ouputLabel1.Name = "ouputLabel1";
            this.ouputLabel1.Size = new System.Drawing.Size(85, 13);
            this.ouputLabel1.TabIndex = 1;
            this.ouputLabel1.Text = "Customer Name:";
            // 
            // outputDescLabel
            // 
            this.outputDescLabel.AutoSize = true;
            this.outputDescLabel.Location = new System.Drawing.Point(15, 11);
            this.outputDescLabel.Name = "outputDescLabel";
            this.outputDescLabel.Size = new System.Drawing.Size(109, 13);
            this.outputDescLabel.TabIndex = 0;
            this.outputDescLabel.Text = "Customer Information:";
            // 
            // cusNameDisplayLabel
            // 
            this.cusNameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusNameDisplayLabel.Location = new System.Drawing.Point(153, 29);
            this.cusNameDisplayLabel.Name = "cusNameDisplayLabel";
            this.cusNameDisplayLabel.Size = new System.Drawing.Size(112, 25);
            this.cusNameDisplayLabel.TabIndex = 6;
            this.cusNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusAddressDisplayLabel
            // 
            this.cusAddressDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusAddressDisplayLabel.Location = new System.Drawing.Point(153, 56);
            this.cusAddressDisplayLabel.Name = "cusAddressDisplayLabel";
            this.cusAddressDisplayLabel.Size = new System.Drawing.Size(112, 25);
            this.cusAddressDisplayLabel.TabIndex = 7;
            this.cusAddressDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusTeleNumberDisplayLabel
            // 
            this.cusTeleNumberDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusTeleNumberDisplayLabel.Location = new System.Drawing.Point(153, 83);
            this.cusTeleNumberDisplayLabel.Name = "cusTeleNumberDisplayLabel";
            this.cusTeleNumberDisplayLabel.Size = new System.Drawing.Size(112, 25);
            this.cusTeleNumberDisplayLabel.TabIndex = 8;
            this.cusTeleNumberDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusNumberDisplayLabel
            // 
            this.cusNumberDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusNumberDisplayLabel.Location = new System.Drawing.Point(153, 111);
            this.cusNumberDisplayLabel.Name = "cusNumberDisplayLabel";
            this.cusNumberDisplayLabel.Size = new System.Drawing.Size(112, 25);
            this.cusNumberDisplayLabel.TabIndex = 9;
            this.cusNumberDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusMailListDisplayLabel
            // 
            this.cusMailListDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusMailListDisplayLabel.Location = new System.Drawing.Point(153, 139);
            this.cusMailListDisplayLabel.Name = "cusMailListDisplayLabel";
            this.cusMailListDisplayLabel.Size = new System.Drawing.Size(112, 25);
            this.cusMailListDisplayLabel.TabIndex = 10;
            this.cusMailListDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonAndCustomerClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 245);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.InputPanel);
            this.Name = "PersonAndCustomerClass";
            this.Text = "Person And Customer Class";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inputDescLabel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createCustomerButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.TextBox cusNumTextBox;
        private System.Windows.Forms.TextBox teleNumTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label inputLabel5;
        private System.Windows.Forms.Label inputLabel4;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label ouputLabel5;
        private System.Windows.Forms.Label ouputLabel4;
        private System.Windows.Forms.Label ouputLabel3;
        private System.Windows.Forms.Label ouputLabel2;
        private System.Windows.Forms.Label ouputLabel1;
        private System.Windows.Forms.Label outputDescLabel;
        private System.Windows.Forms.Label cusMailListDisplayLabel;
        private System.Windows.Forms.Label cusNumberDisplayLabel;
        private System.Windows.Forms.Label cusTeleNumberDisplayLabel;
        private System.Windows.Forms.Label cusAddressDisplayLabel;
        private System.Windows.Forms.Label cusNameDisplayLabel;
    }
}

