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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        public bool VerifyCreatedPassword(string str)
        {
            //Variables
            bool pass1 = false; //Pass for Symbols and Punctuation
            bool pass2 = false; //Pass for UpperCase Letters
            bool pass3 = false; //Pass for LowerCase Letters
            bool pass4 = false; //Pass for numbers
            char[] passArray = str.ToCharArray();

            //Check for a symbol
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsPunctuation(temp) || char.IsSymbol(temp))
                    pass1 = true;
            }

            //Check for an Uppercase Letter
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsUpper(temp))
                    pass2 = true;
            }

            //Check for a Lowercase Letter
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsLower(temp))
                    pass3 = true;
            }

            //Check for a Lowercase Letter
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsNumber(temp))
                    pass4 = true;
            }

            //If all passes are true, return true.
            if (pass1 == true && pass2 == true && pass3 == true && pass4 == true)
            {
                MessageBox.Show("The password is valid.");
                return true;
            }
            else
            {
                //Set all passes to false.
                pass1 = false;
                pass2 = false;
                pass3 = false;
                pass4 = false;
                MessageBox.Show("The password is not valid.");
                return false;
            }
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                string playerName = pNameTextBox.Text;
                string password = pPasswordTextBox.Text;
                BaseWeapon weapon;

                //Set playerClass
                if (potRadioButton.Checked == true)
                    weapon = new PotWeapon();
                else if (axeRadioButton.Checked == true)
                    weapon = new AxeWeapon();
                else if (swordRadioButton.Checked == true)
                    weapon = new SwordWeapon();
                else if (gunRadioButton.Checked == true)
                    weapon = new GunWeapon();
                else
                    weapon = new PotWeapon();

                //Check Password.
                bool correctPassword = VerifyCreatedPassword(password);

                //If there are no problems with the passwords, the program writes a player file.
                if (correctPassword == true)
                {
                    BaseBattlerClass player = new PlayerClass(playerName, password, weapon);    //Create new Player object
                    SaveNewPlayerData(player);      //Save all new data to the database
                    Form1.player = LoadGameData();  //Load all of the saved data into a new player object and transfer that object from form to form.
                    this.Close();                   //Close this form.
                }
                else
                    MessageBox.Show("The player could not be created because the password is not valid.");  //Tell player it came out wrong.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    //Display error message.
            }
        }

        private void SaveNewPlayerData(BaseBattlerClass player)
        {
            //Delete all Data from the tables.
            playerInformationTableAdapter.DeleteAllTableData();
            playerWeaponInformationTableAdapter.DeleteAllTableData();
            playerItemsListInfoTableAdapter.DeleteAllTableData();
            playerTreasureListInfoTableAdapter.DeleteAllTableData();
            roomInfoTableAdapter.DeleteAllTableData();

            //Save all new information.
            playerInformationTableAdapter.SavePlayerInformation(player.BattlerName, player.BattlerPassword, player.BattlerMaxHP, player.BattlerCurrentHP);
            playerWeaponInformationTableAdapter.SavePlayerWeaponInformation(player.Weapon.WeaponName, player.Weapon.WeaponDamage, player.Weapon.WeaponDescription);
            for (int i = 0; i < player.PlayerItems.Count; i++)
                playerItemsListInfoTableAdapter.SaveItemList(player.PlayerItems[i].ItemName, player.PlayerItems[i].ItemDescription, player.PlayerItems[i].HealValue, player.PlayerItems[i].Quantity);
            for (int i = 0; i < player.PlayerTreasures.Count; i++)
                playerTreasureListInfoTableAdapter.SaveTreasureList(player.PlayerTreasures[i].TreasureName, player.PlayerTreasures[i].TreasureDescription, player.PlayerTreasures[i].TreasureUse, player.PlayerTreasures[i].Quantity);
            roomInfoTableAdapter.SaveRoomInfo("City Outskirts", 0);
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
            for(int i = 0; i < temp.PlayerTreasures.Count; i++)
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
    }
}
