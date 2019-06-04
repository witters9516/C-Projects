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
    public partial class DungeonCrawlGame : Form
    {
        //BattleLog accumulator
        int bLCount = 0;    //If this count hits 6, run a clear function.

        //Variables
        string target = "";
        string[] rooms = { "City Outskirts", "Quickstop Station", "Walmart", "Safe Zone", "Marathon"};
        public static string currentRoom;
        public static int currentRoomIndex = 0;
        int room1Search = 0;    //(Outskirts) Need 1 to find Hammer
        int room2Search = 0;    //(Quickstop) Need 2 to find FlashLight
        int room3Search = 0;    //(Walmart) Need 2 to find KeyToSafeZone
        int room4Search = 0;    //(Safe Zone) Need 3 to find HiddenPathtoMarathon
        List<BaseBattlerClass> battlerList = new List<BaseBattlerClass>();
        public static List<BaseItem> tItems;
        public static List<BaseTreasure> tTreasures;

        //Player Object
        public static BaseBattlerClass player;

        //Open Needed Scripts
        StoryTextClass storyTextClassScript = new StoryTextClass();             //Allows for storytelling
        EncounterClass encounterClassScript = new EncounterClass();             //Allows for random encounters
        BattlerFunctionsClass battleFuncScript = new BattlerFunctionsClass();   //Allows for battle calculation.

        public DungeonCrawlGame()
        {
            InitializeComponent();
        }

        private void DungeonCrawlGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playerInfoDataSet.RoomInfo' table. You can move, or remove it, as needed.
            this.roomInfoTableAdapter.Fill(this.playerInfoDataSet.RoomInfo);
            //Load Player Object in.
            player = Form1.player;

            battlerList.Add(player);

            pNameLabel.Text = player.BattlerName;
            pHPLabel.Text = player.BattlerCurrentHP.ToString();

            //Handle Lists
            tItems = player.PlayerItems;
            tTreasures = player.PlayerTreasures;

            //Load in current room.
            currentRoom = rooms[currentRoomIndex];
            currentRoomLabel.Text = currentRoom;
            ChangeRooms(0);

            //Insert Beginning Part of Story
            battleLogRichTextBox.Text += storyTextClassScript.OutskirtsDescription();
            bLCount++;

            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerWeaponInformation' table. You can move, or remove it, as needed.
            this.playerWeaponInformationTableAdapter.Fill(this.playerInfoDataSet.PlayerWeaponInformation);
            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerTreasureListInfo' table. You can move, or remove it, as needed.
            this.playerTreasureListInfoTableAdapter.Fill(this.playerInfoDataSet.PlayerTreasureListInfo);
            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerItemsListInfo' table. You can move, or remove it, as needed.
            this.playerItemsListInfoTableAdapter.Fill(this.playerInfoDataSet.PlayerItemsListInfo);
            // TODO: This line of code loads data into the 'playerInfoDataSet.PlayerInformation' table. You can move, or remove it, as needed.
            this.playerInformationTableAdapter.Fill(this.playerInfoDataSet.PlayerInformation);
            MessageBox.Show(storyTextClassScript.OpeningScene());   
        }

        #region RoomButton Methods
        //Map Changing Functions
        private void northButton_Click(object sender, EventArgs e)
        {
            bool canPass = false;
            bool hammer = false;
            bool flashlight = false;
            bool keyToSZ = false;
            bool hiddenPathToMarathon = false;

            //Check BattleLog
            ClearBattleLog();

            if (currentRoomIndex == 0)
            {
                canPass = CheckForPassageItem(hammer, "Hammer");      //Check for hammer

                if(canPass == true)
                {
                    DisplayRoomDescription(currentRoomIndex);         //Show Room Description
                    Encounter();                                      //Generate an encounter.
                    if (enemyListBox.Items.Count != 0)                //Hide buttons if there are enemies.
                    {
                        HideRoomButtons();
                        enemyListBox.SelectedIndex = 0;
                    }
                }
            }
            else if (currentRoomIndex == 1)
            {
                canPass = CheckForPassageItem(flashlight, "Flashlight");  //Check for flashlight
                if (canPass == true)
                {
                    DisplayRoomDescription(currentRoomIndex);         //Show Room Description
                    Encounter();                                      //Generate an encounter.
                    if (enemyListBox.Items.Count != 0)                //Hide buttons if there are enemies.
                    {
                        HideRoomButtons();
                        enemyListBox.SelectedIndex = 0;
                    }
                }
            }
            else if (currentRoomIndex == 2)
            {
                canPass = CheckForPassageItem(keyToSZ, "Key to the Safe Zone");  //Check for keyToSZ
                if (canPass == true)
                {
                    DisplayRoomDescription(currentRoomIndex);         //Show Room Description
                    Encounter();                                      //Generate an encounter.
                    if (enemyListBox.Items.Count != 0)                //Hide buttons if there are enemies.
                    {
                        HideRoomButtons();
                        enemyListBox.SelectedIndex = 0;
                    }
                }
            }
            else if (currentRoomIndex == 3)
            {
                canPass = CheckForPassageItem(hiddenPathToMarathon, "Hidden Path to Marathon");  //Check for hiddenPathToMarathon
                if (canPass == true)
                {
                    DisplayRoomDescription(currentRoomIndex);         //Show Room Description
                    Encounter();                                      //Generate an encounter.
                    if (enemyListBox.Items.Count != 0)                //Hide buttons if there are enemies.
                    {
                        HideRoomButtons();
                        enemyListBox.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                if (bLCount != 0)
                    battleLogRichTextBox.Text += "\n\n";

                battleLogRichTextBox.Text += storyTextClassScript.LeavingRestrictNorthEnd();
            }

            canPass = false;
            //1. Check for Key Item that allows advancement.
            //2. if the player is holding that item, they may advance.
            //else they are told that they must search to find the item that allows access.
            //3. RandomEncounter for advancement.
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            //Check BattleLog
            ClearBattleLog();

            //No check required to go back.
            if (currentRoomIndex != 0)
            {
                ChangeRooms(-1);    //Return to the previous room.
                Encounter();        //Generate an encounter.
                if (enemyListBox.Items.Count != 0)                //Hide buttons if there are enemies.
                {
                    HideRoomButtons();
                    enemyListBox.SelectedIndex = 0;
                }
            }
            else
            {
                if (bLCount != 0)
                    battleLogRichTextBox.Text += "\n\n";
                battleLogRichTextBox.Text += "You cannot leave the outskirts of the city! You have to continue forward.";
            }
        }

        //Button Click Event that keeps the player in the same room. 
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Check BattleLog
            ClearBattleLog();

            //Display SearchText
            if (bLCount != 0)
                battleLogRichTextBox.Text += "\n\n"; 
            battleLogRichTextBox.Text += "You look around for materials or items you can use...";

            //Create a new enemy to add to enemyListBox
            BaseBattlerClass tempEnemy = encounterClassScript.RandomEncounter(currentRoomLabel.Text);

            if (tempEnemy != null)
            {
                battlerList.Add(tempEnemy);                         //Add new enemy to battlerList
                enemyListBox.Items.Add(tempEnemy.BattlerName);      //Add new enemy to enemyListBox

                battleLogRichTextBox.Text += "A new enemy has appeared! It's a(n) " + tempEnemy.BattlerName;

                //Hide the map changing buttons here (Add in after battle calculations)
                if (enemyListBox.Items.Count != 0)                //Hide buttons if there are enemies.
                {
                    HideRoomButtons();
                    enemyListBox.SelectedIndex = 0;
                }

                IncrementSearchCount();
            }
            else
                IncrementSearchCount();
        }

        //The HideRoomButtons method hides all of the buttons changing rooms.
        //Prevents room changing during battle.
        private void HideRoomButtons()
        {
            northButton.Hide();            //Hide North Button
            southButton.Hide();            //Hide South Button
            searchButton.Hide();            //Hide Search Button
        }

        //The ShowRoomButtons method shows all of the buttons changing rooms.
        //Allows room changing after battle.
        private void ShowSearchButtons()
        {
            northButton.Show();            //Show North Button
            southButton.Show();            //Show South Button
            searchButton.Show();            //Show Search Button
        }

        //Checks for the needed item to continue north.
        private bool CheckForPassageItem(bool item, string itemName)
        {
            for (int i = 0; i < player.PlayerTreasures.Count; i++)
                if (player.PlayerTreasures[i].TreasureName == itemName & player.PlayerTreasures[i].Quantity != 0)
                    item = true;

            if (item == true)
            {
                ChangeRooms(1);
                return true;
            }
            else
            {
                if (bLCount != 0)
                    battleLogRichTextBox.Text += "\n\n";

                battleLogRichTextBox.Text += storyTextClassScript.LeavingRestrictDirection();
                return false;
            }
        }

        //Changes Rooms inside of the Game.
        private void ChangeRooms(int value)
        {
            currentRoomIndex += value;
            currentRoom = rooms[currentRoomIndex];
            currentRoomLabel.Text = currentRoom;
            DisplayMapChange(currentRoomIndex);
        }

        //Changes the highlighted roomPictureBox.
        private void DisplayMapChange(int mapIndex)
        {
            if (mapIndex == 0)
            {
                room1PictureBox.BackColor = Color.Crimson;
                room2PictureBox.BackColor = Color.Gray;
                room3PictureBox.BackColor = Color.Gray;
                room4PictureBox.BackColor = Color.Gray;
                room5PictureBox.BackColor = Color.Gray;
            }
            if (mapIndex == 1)
            {
                room1PictureBox.BackColor = Color.Gray;
                room2PictureBox.BackColor = Color.Crimson;
                room3PictureBox.BackColor = Color.Gray;
                room4PictureBox.BackColor = Color.Gray;
                room5PictureBox.BackColor = Color.Gray;
            }
            if (mapIndex == 2)
            {
                room1PictureBox.BackColor = Color.Gray;
                room2PictureBox.BackColor = Color.Gray;
                room3PictureBox.BackColor = Color.Crimson;
                room4PictureBox.BackColor = Color.Gray;
                room5PictureBox.BackColor = Color.Gray;
            }
            if (mapIndex == 3)
            {
                room1PictureBox.BackColor = Color.Gray;
                room2PictureBox.BackColor = Color.Gray;
                room3PictureBox.BackColor = Color.Gray;
                room4PictureBox.BackColor = Color.Crimson;
                room5PictureBox.BackColor = Color.Gray;
            }
            if (mapIndex == 4)
            {
                room1PictureBox.BackColor = Color.Gray;
                room2PictureBox.BackColor = Color.Gray;
                room3PictureBox.BackColor = Color.Gray;
                room4PictureBox.BackColor = Color.Gray;
                room5PictureBox.BackColor = Color.Crimson;
            }
        }

        //The DisplayRoomDescription method takes an int as an argument.
        //The method displays the Description of the room based on the currentRoomIndex.
        private void DisplayRoomDescription(int indexValue)
        {
            //Set BattleLog to Empty string and blCount to 1 for spacing issues.
            bLCount = 1;
            battleLogRichTextBox.Text = "";

            //Display the Room Description Based on the currentRoomIdex
            switch (indexValue)
            {
                case 0:
                    battleLogRichTextBox.Text += storyTextClassScript.OutskirtsDescription();
                    break;
                case 1:
                    battleLogRichTextBox.Text += storyTextClassScript.QuickStopDescription();
                    break;
                case 2:
                    battleLogRichTextBox.Text += storyTextClassScript.WalmartDescription();
                    break;
                case 3:
                    battleLogRichTextBox.Text += storyTextClassScript.SafeZoneDescription();
                    break;
                case 4:
                    battleLogRichTextBox.Text += storyTextClassScript.MarathonDescription();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Battle Related Methods
        //Battle Target related functions
        private void attackButton_Click(object sender, EventArgs e)
        {
            if (enemyListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose a target!");
            }
            else
            {
                //NameVariables.
                string targetName = enemyListBox.Items[enemyListBox.SelectedIndex].ToString();
                string playerName = player.BattlerName;

                BattlerFunctionsClass.battlerList = battlerList;    //Set script battle list to current battleList.
                battlerList = battleFuncScript.BattleProcess(playerName, targetName);   //Use BattleProcess to calculate damage.
                ReFillListboxWithCurrentEnemyList(battlerList);     //Update enemyListBox
                if (enemyListBox.Items.Count == 0)
                    ShowSearchButtons();                            //Show Search Buttons if there are no enemies.

                BaseBattlerClass temp = battlerList[0];             //Set temp to the 1st index.
                for (int i = 0; i < battlerList.Count; i++)
                    if (battlerList[i].BattlerName == playerName)
                        temp = battlerList[i];                      //Set Temp to this index of battlerList.
                pHPLabel.Text = temp.BattlerCurrentHP.ToString();   //Set HP Text label to temp's Current HP.
                player = temp;                                      //Set Player object to temp
                                                                    //If player HP is 0 or less, then its game over.
                if (temp.BattlerCurrentHP <= 0)
                {
                    GameOver gO = new GameOver();   //Create an instance of the GameOver Form
                    this.Hide();                    //Hide this Form.
                    gO.ShowDialog();                //ShowDialog for GameOver Form
                    this.Show();                    //Show this Form.
                    this.Close();                   //Close this Form.
                }
            }
            
        }

        //Button to use Item. Does not call battleFunction.
        private void itemButton_Click(object sender, EventArgs e)
        {
            //This could be having an issue with the creation of the character.
            //This was added after the player was made so they dont have the item.
            UseItem temp = new UseItem();               //Create a UseItem Form

            for (int i = 0; i < battlerList.Count; i++)
                if (battlerList[i].BattlerName == player.BattlerName)
                    temp.player = battlerList[i];       //Set the form's player object to this form's player object.
            temp.currentItems = player.PlayerItems;     //Set the form's currentItems List to the player's itemList
            this.Hide();                                //Hide this form.
            temp.ShowDialog();                          //Show the Dialog of temp.
            this.Show();                                //Show this Form
            player.PlayerItems = tItems;                //Update itemList
            pHPLabel.Text = player.BattlerCurrentHP.ToString(); //Update Current HP Label


            //Find player in BattleList and set it to this player.
            for (int i = 0; i < battlerList.Count; i++)
                if (battlerList[i].BattlerName == player.BattlerName)
                    battlerList[i] = player;
        }

        //Change Battle target to search for.
        private void enemyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            target = enemyListBox.Items[enemyListBox.SelectedIndex].ToString();
        }

        //The Encounter method will spawn a monster from the current room or possibly produce no monster.
        private void Encounter()
        {
            //Create a new enemy to add to enemyListBox
            BaseBattlerClass tempEnemy = encounterClassScript.RandomEncounter(currentRoomLabel.Text);

            if (tempEnemy != null)
            {
                battlerList.Add(tempEnemy);                     //Add new enemy to battlerList
                enemyListBox.Items.Add(tempEnemy.BattlerName);  //Add new enemy to enemyListBox

                if (bLCount != 0)
                    battleLogRichTextBox.Text += "\n\n";

                battleLogRichTextBox.Text += " A new enemy has appeared! It's a(n) " + tempEnemy.BattlerName + ".";
            }
            else
                battleLogRichTextBox.Text += " There is no encounter here.";
        }

        //Use after Attacking.
        private void ReFillListboxWithCurrentEnemyList(List<BaseBattlerClass> list)
        {
            enemyListBox.Items.Clear();
            foreach (BaseBattlerClass i in list)
                if (i.BattlerName != player.BattlerName)
                    enemyListBox.Items.Add(i.BattlerName);
        }
        #endregion

        #region Other Information Methods
        private void instructionsButton_Click(object sender, EventArgs e)
        {
            //Load Instructions form.
            Instructions temp = new Instructions();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void displayItemsButton_Click(object sender, EventArgs e)
        {
            CurrentItems temp = new CurrentItems();
            temp.currentItems = player.PlayerItems;     //Set the form's currentItems List to the player's itemList
            this.Hide();
            temp.ShowDialog();
            this.Show();
            //Load a form with list of current items.
            //Set form list to list of current items.
        }

        private void displayKeyItemsButton_Click(object sender, EventArgs e)
        {
            CurrentKeyItems temp = new CurrentKeyItems();
            temp.currentTreasures = player.PlayerTreasures;     //Set the form's currentItems List to the player's itemList
            this.Hide();
            temp.ShowDialog();
            this.Show();
            //Load a form with list of current key items.
            //Set form list to list of current key items.
        }
        #endregion

        //The ClearBattleLog method clears the battleLogTextLabel.
        private void ClearBattleLog()
        {
            if (bLCount == 5)
            {
                battleLogRichTextBox.Text = "";
                bLCount = 0;
            }
            else
                bLCount++;
        }

        #region Searching Functions
        //The IncrementSearchCount method increments the current room search counter.
        //next it calls the DisplayFoundTreasures method.
        private void IncrementSearchCount()
        {
            //Increment Search count for the current room.
            if (currentRoom == rooms[0])
                room1Search++;
            else if (currentRoom == rooms[1])
                room2Search++;
            else if (currentRoom == rooms[2])
                room3Search++;
            else if (currentRoom == rooms[3])
                room4Search++;

            DisplayFoundTreasures();    //Determine if anything was found.
        }

        //The DisplayFoundTreasures method determines and displays whether the player finds anything during searches.
        private void DisplayFoundTreasures()
        {
            if (currentRoom == rooms[0])
                if (room1Search == 1)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundHammer(); //Display that you found the hammer
                    for (int i = 0; i < player.PlayerTreasures.Count; i++)
                        if (player.PlayerTreasures[i].TreasureName == "Hammer")
                            if(player.PlayerTreasures[i].Quantity == 0)
                                player.PlayerTreasures[i].Quantity++;
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else if (currentRoom == rooms[1])
                if (room2Search == 2)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundFlashlight(); //Display that you found the flashlight
                    for (int i = 0; i < player.PlayerTreasures.Count; i++)
                        if (player.PlayerTreasures[i].TreasureName == "Flashlight")
                            if (player.PlayerTreasures[i].Quantity == 0)
                                player.PlayerTreasures[i].Quantity++;
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else if (currentRoom == rooms[2])
                if (room3Search == 2)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundKeyToSafeZone(); //Display that you found the key to the safe zone
                    for (int i = 0; i < player.PlayerTreasures.Count; i++)
                        if (player.PlayerTreasures[i].TreasureName == "Key to the Safe Zone")
                            if (player.PlayerTreasures[i].Quantity == 0)
                                player.PlayerTreasures[i].Quantity++;
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else if (currentRoom == rooms[3])
                if (room4Search == 3)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundHiddenPathToMarathon(); //Display that you found the hidden path to the marathon.
                    for (int i = 0; i < player.PlayerTreasures.Count; i++)
                        if (player.PlayerTreasures[i].TreasureName == "Hidden Path to Marathon")
                            if (player.PlayerTreasures[i].Quantity == 0)
                                player.PlayerTreasures[i].Quantity++;
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else
                battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
        }
        #endregion

        #region DatabaseSavingAndLoading
        public void SPD()
        {
            //Create a temp player object.
            BaseBattlerClass tempPlayer = new PlayerClass();

            //Find the Player
            for (int i = 0; i < battlerList.Count; i++)
                if (battlerList[i].BattlerName == player.BattlerName)
                    tempPlayer = battlerList[i];

            //Saves the playerInformation
            try
            {
                this.tableAdapterManager.PlayerInformationTableAdapter.SavePlayerInformation(
                tempPlayer.BattlerName, tempPlayer.BattlerPassword, tempPlayer.BattlerMaxHP, tempPlayer.BattlerCurrentHP);
            
                this.playerWeaponInformationTableAdapter.SavePlayerWeaponInformation(
                    player.Weapon.WeaponName, player.Weapon.WeaponDamage, player.Weapon.WeaponDescription);

                //Player Current Item Information
                for (int i = 0; i < player.PlayerItems.Count; i++)
                    this.tableAdapterManager.PlayerItemsListInfoTableAdapter.SaveItemList(
                        player.PlayerItems[i].ItemName, player.PlayerItems[i].ItemDescription, player.PlayerItems[i].HealValue, player.PlayerItems[i].Quantity);

                //Player Current Treasures Information
                for (int i = 0; i < player.PlayerTreasures.Count; i++)
                    this.tableAdapterManager.PlayerTreasureListInfoTableAdapter.SaveTreasureList(
                        player.PlayerTreasures[i].TreasureName, player.PlayerTreasures[i].TreasureDescription, player.PlayerTreasures[i].TreasureUse, player.PlayerTreasures[i].Quantity);
                //Room Information
                roomInfoTableAdapter.SaveRoomInfo(currentRoom, currentRoomIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataBaseInfo dbInfo = new DataBaseInfo();
            this.Hide();
            dbInfo.ShowDialog();
            this.Show();
        }

        public void SavePlayerData()
        {
            //Create a temp player object.
            BaseBattlerClass tempPlayer = new PlayerClass();

            //Find the Player
            for (int i = 0; i < battlerList.Count; i++)
                if (battlerList[i].BattlerName == player.BattlerName)
                    tempPlayer = battlerList[i];

            //Updates the player information.
            this.playerInformationTableAdapter.UpdateNewData(tempPlayer.BattlerCurrentHP, player.BattlerName, tempPlayer.BattlerName);
            //Update Weapon Info
            this.playerWeaponInformationTableAdapter.UpdateWeapon(tempPlayer.Weapon.WeaponName, tempPlayer.Weapon.WeaponDamage, tempPlayer.Weapon.WeaponDescription, player.Weapon.WeaponName);
            //Update Item info
            for (int i = 0; i < tempPlayer.PlayerItems.Count; i++)
                this.playerItemsListInfoTableAdapter.UpdateItemList(tempPlayer.PlayerItems[i].Quantity, tempPlayer.PlayerItems[i].ItemName, tempPlayer.PlayerItems[i].ItemName);
            //Update Treasure info
            for (int i = 0; i < tempPlayer.PlayerTreasures.Count; i++)
                this.playerTreasureListInfoTableAdapter.UpdateTreasureList(tempPlayer.PlayerTreasures[i].Quantity, tempPlayer.PlayerTreasures[i].TreasureName, tempPlayer.PlayerTreasures[i].TreasureName);
            //Room Info
            string temp = (string)roomInfoTableAdapter.ReturnRoom();
            roomInfoTableAdapter.UpdateRoomInfo(currentRoom, currentRoomIndex, temp);

            DataBaseInfo dbInfo = new DataBaseInfo();
            this.Hide();
            dbInfo.ShowDialog();
            this.Show();
        }
        #endregion

        private void playerInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.playerInfoDataSet);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SavePlayerData();
        }

        private void dealFiveDamageButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < battlerList.Count; i++)
                if (battlerList[i].BattlerName == player.BattlerName)
                {
                    battlerList[i].BattlerCurrentHP -= 5;
                    pHPLabel.Text = battlerList[i].BattlerCurrentHP.ToString();
                }
        }
    }
}
