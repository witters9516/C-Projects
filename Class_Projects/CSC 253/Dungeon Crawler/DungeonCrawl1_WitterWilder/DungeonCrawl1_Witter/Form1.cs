/**
* 9/6/17
* CSC 253
* Shawn Witter & Dexter Wilder
* This program displays the arrays and lists that 
* meets the requirements of Dungeon Crawl 1.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl1_Witter
{
    public partial class Form1 : Form
    {
        //Arrays
        string[] roomArray = { "Castle Gates", "Entrance Hall", "Grand Hallway", "Audience Chamber", "Royal Throne Room"};
        string[] weaponArray = { "Sword", "Bow", "Rod", "Staff" };
        string[] potionArray = { "Potion", "Hi-Potion"};
        string[] treasureArray = { "Star Pendent", "Silver Wristband", "Gold Crown"};
        
        //Lists
        List<string> mobList = new List<string> { "Soldier", "Captain", "General", "King's Guard", "King"};
        List<string> itemList = new List<string>{ "Potion", "Hi-Potion", "Mega-Potion", "Revive"};

        //Important Room Variables
        string currentRoom;
        int currentRoomIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add Rooms in roomArray to roomListBox
            foreach (string str in roomArray)
                roomListBox.Items.Add(str);

            //Sort Weapons Array.
            Array.Sort(weaponArray);

            //Add Weapons in weaponArray to weaponListBox
            foreach (string str in weaponArray)
                weaponListBox.Items.Add(str);


            //Add Potions in potionArray to potionListBox
            foreach (string str in potionArray)
                potionListBox.Items.Add(str);
            
            //Add Treasures in treasureArray to tresureListBox
            foreach (string str in treasureArray)
                treasureListBox.Items.Add(str);

            //Add Mob in mobList to mobListBox
            foreach (string str in mobList)
                mobListBox.Items.Add(str);

            //Add Items in itemList to itemListBox
            foreach (string str in itemList)
                itemListBox.Items.Add(str);

            //Hide Data on List tab.
            mobPanel.Hide();
            itemPanel.Hide();

            //Highlight the current room.
            room1PictureBox.BackColor = Color.Blue;

            //Set currentRoom to the starting room.
            currentRoom = roomArray[0];

            //Display Current Room Name.
            currentRoomLabel.Text = currentRoom;

        }

        private void arraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show all Data on array tab.
            roomPanel.Show();
            weaponPanel.Show();
            potionPanel.Show();
            treasurePanel.Show();

            //Hide Data on List tab.
            mobPanel.Hide();
            itemPanel.Hide();
        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide all data on array tab.
            roomPanel.Hide();
            weaponPanel.Hide();
            potionPanel.Hide();
            treasurePanel.Hide();

            //Show Data on List tab.
            mobPanel.Show();
            itemPanel.Show();
        }

        private void northButton_Click(object sender, EventArgs e)
        {
            //Change information displayed to move player north.
            currentRoomIndex = ChangeRooms(currentRoomIndex, "North");
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            //Change information displayed to move player north.
            currentRoomIndex = ChangeRooms(currentRoomIndex, "South");
        }

        //The ChangeRooms Method accepts an int and a string as parameters.
        //The int is the direction the player has chosen and the int is
        //the index of the currentRoom. This method will change the index of
        //the current room and name of the current Room to Display to the user.
        public int ChangeRooms(int currentRoomIndex, string direction)
        {
            //Conditional statement to check for a direction and if the player
            //can proceed in that direction. otherwise an error statement will display.
            if (direction == "North")
                if (currentRoomIndex != (roomArray.Length - 1))
                    currentRoomIndex++;
                else
                    MessageBox.Show("You cannot go north anymore.");
            else if (direction == "South")
                if (currentRoomIndex != 0)
                    currentRoomIndex--;
                else
                    MessageBox.Show("You cannot go south anymore.");

            //Update the Current Room Name.
            currentRoom = roomArray[currentRoomIndex];
            //Display the Current Room Name.
            currentRoomLabel.Text = currentRoom;

            //Returns all PictureBoxes to Gray before it will update the current room.
            ReturnColorsToNormal();

            //Conditional Statement to update the Room PictureBox.
            if (currentRoomIndex == 0)
                room1PictureBox.BackColor = Color.Blue;
            if (currentRoomIndex == 1)
                room2PictureBox.BackColor = Color.Blue;
            if (currentRoomIndex == 2)
                room3PictureBox.BackColor = Color.Blue;
            if (currentRoomIndex == 3)
                room4PictureBox.BackColor = Color.Blue;
            if (currentRoomIndex == 4)
                room5PictureBox.BackColor = Color.Blue;

            //Return the new currentRoomIndex
            return currentRoomIndex;
        }

        //The ReturnColorsToNormal method returns all of the picture boxes to gray.
        public void ReturnColorsToNormal()
        {
            room1PictureBox.BackColor = Color.Gray;
            room2PictureBox.BackColor = Color.Gray;
            room3PictureBox.BackColor = Color.Gray;
            room4PictureBox.BackColor = Color.Gray;
            room5PictureBox.BackColor = Color.Gray;
        }

        

        private void playerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerForm form = new PlayerForm();
            form.Show();
        }

        private void enemyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnemyForm form = new EnemyForm();
            form.Show();
        }

        private void roomInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm form = new RoomForm();
            form.Show();
        }


    }
}
