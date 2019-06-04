namespace Witters_Mod_6_GL_5_JoesAutomotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsinstructLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.calcServeLabel = new System.Windows.Forms.Label();
            this.calcPartLabel = new System.Windows.Forms.Label();
            this.calcTaxLabel = new System.Windows.Forms.Label();
            this.calcTotalFeeLabel = new System.Windows.Forms.Label();
            this.ServiceAndLaborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubeJobCheckBox);
            this.groupBox1.Controls.Add(this.oilChangeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiatorFlushCheckBox);
            this.groupBox2.Controls.Add(this.transmissionFlushCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(198, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tireRotationCheckBox);
            this.groupBox3.Controls.Add(this.inspectionCheckBox);
            this.groupBox3.Controls.Add(this.replaceMufflerCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 92);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.laborLabel);
            this.groupBox4.Controls.Add(this.partsinstructLabel);
            this.groupBox4.Controls.Add(this.laborTextBox);
            this.groupBox4.Controls.Add(this.partsTextBox);
            this.groupBox4.Location = new System.Drawing.Point(198, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 92);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.totalFeeLabel);
            this.groupBox5.Controls.Add(this.taxLabel);
            this.groupBox5.Controls.Add(this.partsLabel);
            this.groupBox5.Controls.Add(this.ServiceAndLaborLabel);
            this.groupBox5.Controls.Add(this.calcTotalFeeLabel);
            this.groupBox5.Controls.Add(this.calcTaxLabel);
            this.groupBox5.Controls.Add(this.calcPartLabel);
            this.groupBox5.Controls.Add(this.calcServeLabel);
            this.groupBox5.Location = new System.Drawing.Point(12, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(367, 137);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(74, 328);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(155, 328);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(236, 328);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(17, 19);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(120, 17);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(17, 42);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(112, 17);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(15, 19);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(136, 17);
            this.radiatorFlushCheckBox.TabIndex = 2;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(15, 42);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(157, 17);
            this.transmissionFlushCheckBox.TabIndex = 3;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(17, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(117, 17);
            this.inspectionCheckBox.TabIndex = 4;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(17, 42);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(149, 17);
            this.replaceMufflerCheckBox.TabIndex = 5;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(17, 65);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(129, 17);
            this.tireRotationCheckBox.TabIndex = 6;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(74, 21);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 0;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(74, 47);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborTextBox.TabIndex = 1;
            // 
            // partsinstructLabel
            // 
            this.partsinstructLabel.AutoSize = true;
            this.partsinstructLabel.Location = new System.Drawing.Point(12, 24);
            this.partsinstructLabel.Name = "partsinstructLabel";
            this.partsinstructLabel.Size = new System.Drawing.Size(34, 13);
            this.partsinstructLabel.TabIndex = 2;
            this.partsinstructLabel.Text = "Parts:";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(12, 50);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(52, 13);
            this.laborLabel.TabIndex = 3;
            this.laborLabel.Text = "Labor ($):";
            // 
            // calcServeLabel
            // 
            this.calcServeLabel.AutoSize = true;
            this.calcServeLabel.Location = new System.Drawing.Point(14, 27);
            this.calcServeLabel.Name = "calcServeLabel";
            this.calcServeLabel.Size = new System.Drawing.Size(97, 13);
            this.calcServeLabel.TabIndex = 3;
            this.calcServeLabel.Text = "Service and Labor:";
            // 
            // calcPartLabel
            // 
            this.calcPartLabel.AutoSize = true;
            this.calcPartLabel.Location = new System.Drawing.Point(14, 53);
            this.calcPartLabel.Name = "calcPartLabel";
            this.calcPartLabel.Size = new System.Drawing.Size(34, 13);
            this.calcPartLabel.TabIndex = 4;
            this.calcPartLabel.Text = "Parts:";
            // 
            // calcTaxLabel
            // 
            this.calcTaxLabel.AutoSize = true;
            this.calcTaxLabel.Location = new System.Drawing.Point(14, 79);
            this.calcTaxLabel.Name = "calcTaxLabel";
            this.calcTaxLabel.Size = new System.Drawing.Size(75, 13);
            this.calcTaxLabel.TabIndex = 5;
            this.calcTaxLabel.Text = "Tax (on parts):";
            // 
            // calcTotalFeeLabel
            // 
            this.calcTotalFeeLabel.AutoSize = true;
            this.calcTotalFeeLabel.Location = new System.Drawing.Point(14, 105);
            this.calcTotalFeeLabel.Name = "calcTotalFeeLabel";
            this.calcTotalFeeLabel.Size = new System.Drawing.Size(60, 13);
            this.calcTotalFeeLabel.TabIndex = 6;
            this.calcTotalFeeLabel.Text = "Total Fees:";
            // 
            // ServiceAndLaborLabel
            // 
            this.ServiceAndLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceAndLaborLabel.Location = new System.Drawing.Point(150, 23);
            this.ServiceAndLaborLabel.Name = "ServiceAndLaborLabel";
            this.ServiceAndLaborLabel.Size = new System.Drawing.Size(149, 21);
            this.ServiceAndLaborLabel.TabIndex = 7;
            this.ServiceAndLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partsLabel
            // 
            this.partsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsLabel.Location = new System.Drawing.Point(150, 49);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(149, 21);
            this.partsLabel.TabIndex = 8;
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(150, 75);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(149, 21);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeeLabel.Location = new System.Drawing.Point(150, 101);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(149, 21);
            this.totalFeeLabel.TabIndex = 10;
            this.totalFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 361);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsinstructLabel;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label ServiceAndLaborLabel;
        private System.Windows.Forms.Label calcTotalFeeLabel;
        private System.Windows.Forms.Label calcTaxLabel;
        private System.Windows.Forms.Label calcPartLabel;
        private System.Windows.Forms.Label calcServeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

