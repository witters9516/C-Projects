using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

namespace DungeonCrawl
{
    public partial class LoadGame : Form
    {
        public LoadGame()
        {
            InitializeComponent();
        }

        private void loadInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables from textBoxes
                string name = pNameTextBox.Text;
                string password = pPasswordTextBox.Text;
                //Variables for login
                string tempName = (string)playerInformationTableAdapter.ReturnPlayerName();
                string tempPassword = (string)playerInformationTableAdapter.ReturnPlayerPassword();

                if (name == tempName)
                    if (password == tempPassword)
                    {
                        BaseBattlerClass temp = LoadGameData();
                        Form1.player = temp;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Invalid Password");
                else
                    MessageBox.Show("Invalid Login Name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private BaseBattlerClass LoadGameData()
        {
            //Reinstantiate Player Data
            BaseWeapon bw = null;
            string playerName = (string)playerInformationTableAdapter.ReturnPlayerName();
            string playerPassword = (string)playerInformationTableAdapter.ReturnPlayerPassword();
            int playerMaxHP = (int)playerInformationTableAdapter.ReturnPlayerMaxHP();
            int playerCurrentHP = (int)playerInformationTableAdapter.ReturnPlayerCurrentHP();
            string playerWeaponName = (string)playerWeaponInformationTableAdapter.ReturnWeaponName();

            //Find and Set player weapon.
            if (playerWeaponName == "Pot")
                bw = new PotWeapon();
            if (playerWeaponName == "Axe")
                bw = new AxeWeapon();
            if (playerWeaponName == "Sword")
                bw = new SwordWeapon();
            if (playerWeaponName == "Gun")
                bw = new GunWeapon();

            //Create an instance of the player with these variables.
            BaseBattlerClass temp = new PlayerClass(playerName, playerPassword, playerMaxHP, playerCurrentHP, bw);

            //Reinstantiate the item and trasure lists
            //Items
            int foodQuantity = (int)playerItemsListInfoTableAdapter.ReturnQuantity("Food");
            int medSuppliesQuantity = (int)playerItemsListInfoTableAdapter.ReturnQuantity("Medical Supplies");
            int clothesQuantity = (int)playerItemsListInfoTableAdapter.ReturnQuantity("Clothes");
            BaseItem food = new Food();
            BaseItem medicalSupplies = new MedicalSupplies();
            BaseItem clothes = new Clothes();
            for (int i = 0; i < temp.PlayerTreasures.Count; i++)
            {
                if (temp.PlayerTreasures[i].TreasureName == "Food")
                    temp.PlayerTreasures[i].Quantity = foodQuantity;
                if (temp.PlayerTreasures[i].TreasureName == "Medical Supplies")
                    temp.PlayerTreasures[i].Quantity = medSuppliesQuantity;
                if (temp.PlayerTreasures[i].TreasureName == "Clothes")
                    temp.PlayerTreasures[i].Quantity = clothesQuantity;
            }
            //Treasures
            int hammerQuantity = (int)playerTreasureListInfoTableAdapter.ReturnQuantity("Hammer");
            int flashlightQuantity = (int)playerTreasureListInfoTableAdapter.ReturnQuantity("Flashlight");
            int keyTSZQuantity = (int)playerTreasureListInfoTableAdapter.ReturnQuantity("Key to the Safe Zone");
            int hiddenPTMQuantity = (int)playerTreasureListInfoTableAdapter.ReturnQuantity("Hidden Path to Marathon");
            BaseTreasure hammer = new Hammer();
            BaseTreasure flashlight = new Flashlight();
            BaseTreasure KTSZ = new KeyToSafeZone();
            BaseTreasure HPTM = new HiddenPathToMarathon();
            for (int i = 0; i < temp.PlayerTreasures.Count; i++)
            {
                if (temp.PlayerTreasures[i].TreasureName == "Hammer")
                    temp.PlayerTreasures[i].Quantity = hammerQuantity;
                if (temp.PlayerTreasures[i].TreasureName == "Flashlight")
                    temp.PlayerTreasures[i].Quantity = flashlightQuantity;
                if (temp.PlayerTreasures[i].TreasureName == "Key to the Safe Zone")
                    temp.PlayerTreasures[i].Quantity = keyTSZQuantity;
                if (temp.PlayerTreasures[i].TreasureName == "Hidden Path to Marathon")
                    temp.PlayerTreasures[i].Quantity = hiddenPTMQuantity;
            }

            //Reinstantiate the Room and EnemyList.
            //Reinstantiate the Room and EnemyList.
            string currentRoom = (string)roomInfoTableAdapter.ReturnRoom();
            int currentRoomIndex = (int)roomInfoTableAdapter.ReturnIndex();
            Form1.currentRoom = currentRoom;
            Form1.currentRoomIndex = currentRoomIndex;

            return temp;
        }


        private void playerInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.playerInfoDataSet);

        }

        private void LoadGame_Load(object sender, EventArgs e)
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
