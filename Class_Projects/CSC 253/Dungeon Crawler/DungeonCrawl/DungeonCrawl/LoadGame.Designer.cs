namespace DungeonCrawl
{
    partial class LoadGame
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
            this.components = new System.ComponentModel.Container();
            this.loadInfoButton = new System.Windows.Forms.Button();
            this.pPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.pPasswordLabel = new System.Windows.Forms.Label();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerInfoDataSet = new DungeonCrawl.PlayerInfoDataSet();
            this.playerInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerInformationTableAdapter = new DungeonCrawl.PlayerInfoDataSetTableAdapters.PlayerInformationTableAdapter();
            this.tableAdapterManager = new DungeonCrawl.PlayerInfoDataSetTableAdapters.TableAdapterManager();
            this.playerItemsListInfoTableAdapter = new DungeonCrawl.PlayerInfoDataSetTableAdapters.PlayerItemsListInfoTableAdapter();
            this.playerTreasureListInfoTableAdapter = new DungeonCrawl.PlayerInfoDataSetTableAdapters.PlayerTreasureListInfoTableAdapter();
            this.playerWeaponInformationTableAdapter = new DungeonCrawl.PlayerInfoDataSetTableAdapters.PlayerWeaponInformationTableAdapter();
            this.playerItemsListInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTreasureListInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerWeaponInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomInfoTableAdapter = new DungeonCrawl.PlayerInfoDataSetTableAdapters.RoomInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.playerInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerItemsListInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTreasureListInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWeaponInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loadInfoButton
            // 
            this.loadInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.loadInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadInfoButton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadInfoButton.Location = new System.Drawing.Point(114, 126);
            this.loadInfoButton.Name = "loadInfoButton";
            this.loadInfoButton.Size = new System.Drawing.Size(189, 39);
            this.loadInfoButton.TabIndex = 86;
            this.loadInfoButton.Text = "Load Information";
            this.loadInfoButton.UseVisualStyleBackColor = false;
            this.loadInfoButton.Click += new System.EventHandler(this.loadInfoButton_Click);
            // 
            // pPasswordTextBox
            // 
            this.pPasswordTextBox.BackColor = System.Drawing.Color.Crimson;
            this.pPasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pPasswordTextBox.Location = new System.Drawing.Point(241, 88);
            this.pPasswordTextBox.Name = "pPasswordTextBox";
            this.pPasswordTextBox.Size = new System.Drawing.Size(170, 20);
            this.pPasswordTextBox.TabIndex = 85;
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.BackColor = System.Drawing.Color.Crimson;
            this.pNameTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pNameTextBox.Location = new System.Drawing.Point(241, 61);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.pNameTextBox.TabIndex = 84;
            // 
            // pPasswordLabel
            // 
            this.pPasswordLabel.AutoSize = true;
            this.pPasswordLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPasswordLabel.ForeColor = System.Drawing.Color.Crimson;
            this.pPasswordLabel.Location = new System.Drawing.Point(25, 83);
            this.pPasswordLabel.Name = "pPasswordLabel";
            this.pPasswordLabel.Size = new System.Drawing.Size(210, 25);
            this.pPasswordLabel.TabIndex = 83;
            this.pPasswordLabel.Text = "Player Password:";
            // 
            // pNameLabel
            // 
            this.pNameLabel.AutoSize = true;
            this.pNameLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.pNameLabel.Location = new System.Drawing.Point(25, 56);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(156, 25);
            this.pNameLabel.TabIndex = 82;
            this.pNameLabel.Text = "Player Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Please Enter Player Login Info:";
            // 
            // playerInfoDataSet
            // 
            this.playerInfoDataSet.DataSetName = "PlayerInfoDataSet";
            this.playerInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerInformationBindingSource
            // 
            this.playerInformationBindingSource.DataMember = "PlayerInformation";
            this.playerInformationBindingSource.DataSource = this.playerInfoDataSet;
            // 
            // playerInformationTableAdapter
            // 
            this.playerInformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayerInformationTableAdapter = this.playerInformationTableAdapter;
            this.tableAdapterManager.PlayerItemsListInfoTableAdapter = this.playerItemsListInfoTableAdapter;
            this.tableAdapterManager.PlayerTreasureListInfoTableAdapter = this.playerTreasureListInfoTableAdapter;
            this.tableAdapterManager.PlayerWeaponInformationTableAdapter = this.playerWeaponInformationTableAdapter;
            this.tableAdapterManager.RoomInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DungeonCrawl.PlayerInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerItemsListInfoTableAdapter
            // 
            this.playerItemsListInfoTableAdapter.ClearBeforeFill = true;
            // 
            // playerTreasureListInfoTableAdapter
            // 
            this.playerTreasureListInfoTableAdapter.ClearBeforeFill = true;
            // 
            // playerWeaponInformationTableAdapter
            // 
            this.playerWeaponInformationTableAdapter.ClearBeforeFill = true;
            // 
            // playerItemsListInfoBindingSource
            // 
            this.playerItemsListInfoBindingSource.DataMember = "PlayerItemsListInfo";
            this.playerItemsListInfoBindingSource.DataSource = this.playerInfoDataSet;
            // 
            // playerTreasureListInfoBindingSource
            // 
            this.playerTreasureListInfoBindingSource.DataMember = "PlayerTreasureListInfo";
            this.playerTreasureListInfoBindingSource.DataSource = this.playerInfoDataSet;
            // 
            // playerWeaponInformationBindingSource
            // 
            this.playerWeaponInformationBindingSource.DataMember = "PlayerWeaponInformation";
            this.playerWeaponInformationBindingSource.DataSource = this.playerInfoDataSet;
            // 
            // roomInfoBindingSource
            // 
            this.roomInfoBindingSource.DataMember = "RoomInfo";
            this.roomInfoBindingSource.DataSource = this.playerInfoDataSet;
            // 
            // roomInfoTableAdapter
            // 
            this.roomInfoTableAdapter.ClearBeforeFill = true;
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(448, 187);
            this.Controls.Add(this.loadInfoButton);
            this.Controls.Add(this.pPasswordTextBox);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(this.pPasswordLabel);
            this.Controls.Add(this.pNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "LoadGame";
            this.Text = "LoadGame";
            this.Load += new System.EventHandler(this.LoadGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerItemsListInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTreasureListInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWeaponInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadInfoButton;
        private System.Windows.Forms.TextBox pPasswordTextBox;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.Label pPasswordLabel;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Label label1;
        private PlayerInfoDataSet playerInfoDataSet;
        private System.Windows.Forms.BindingSource playerInformationBindingSource;
        private PlayerInfoDataSetTableAdapters.PlayerInformationTableAdapter playerInformationTableAdapter;
        private PlayerInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PlayerInfoDataSetTableAdapters.PlayerItemsListInfoTableAdapter playerItemsListInfoTableAdapter;
        private System.Windows.Forms.BindingSource playerItemsListInfoBindingSource;
        private PlayerInfoDataSetTableAdapters.PlayerTreasureListInfoTableAdapter playerTreasureListInfoTableAdapter;
        private System.Windows.Forms.BindingSource playerTreasureListInfoBindingSource;
        private PlayerInfoDataSetTableAdapters.PlayerWeaponInformationTableAdapter playerWeaponInformationTableAdapter;
        private System.Windows.Forms.BindingSource playerWeaponInformationBindingSource;
        private System.Windows.Forms.BindingSource roomInfoBindingSource;
        private PlayerInfoDataSetTableAdapters.RoomInfoTableAdapter roomInfoTableAdapter;
    }
}