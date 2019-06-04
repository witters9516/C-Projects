using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    public partial class DataBaseInfo : Form
    {
        public DataBaseInfo()
        {
            InitializeComponent();
        }

        private void playerInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.playerInfoDataSet);

        }

        private void DataBaseInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playerInfoDataSet.RoomInfo' table. You can move, or remove it, as needed.
            this.roomInfoTableAdapter.Fill(this.playerInfoDataSet.RoomInfo);
            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerWeaponInformation' table. You can move, or remove it, as needed.
            this.playerWeaponInformationTableAdapter.Fill(this.playerInfoDataSet.PlayerWeaponInformation);
            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerTreasureListInfo' table. You can move, or remove it, as needed.
            this.playerTreasureListInfoTableAdapter.Fill(this.playerInfoDataSet.PlayerTreasureListInfo);
            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerItemsListInfo' table. You can move, or remove it, as needed.
            this.playerItemsListInfoTableAdapter.Fill(this.playerInfoDataSet.PlayerItemsListInfo);
            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerInformation' table. You can move, or remove it, as needed.
            this.playerInformationTableAdapter.Fill(this.playerInfoDataSet.PlayerInformation);

        }
    }
}
