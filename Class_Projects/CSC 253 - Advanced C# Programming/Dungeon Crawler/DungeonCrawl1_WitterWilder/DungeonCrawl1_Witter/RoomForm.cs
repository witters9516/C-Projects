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
    public partial class RoomForm : Form
    {
        //Globals.
        const int SIZE = 5;
        Room[] roomList = new Room[SIZE];

        public RoomForm()
        {
            InitializeComponent();
        }

        struct Room
        {
            public string RoomName;
            public string RoomDescription;
        };

        private Room CreateRoom(string rName, string rDesc)
        {
            //Create a temp struct.
            Room temp = new Room();

            //Set variables of struct.
            temp.RoomName = rName;
            temp.RoomDescription = rDesc;

            //Return temp
            return temp;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            //Create all the room structs.
            Room room1 = CreateRoom("Castle Gates", "The area outside of the castle.");
            Room room2 = CreateRoom("Entrance Hall", "Hallway at the entrace of the castle.");
            Room room3 = CreateRoom("Grand Hallway", "The following hallway of the castle that hosts many soldiers.");
            Room room4 = CreateRoom("Audience Chamber", "The chamber that the king usually resides in.");
            Room room5 = CreateRoom("Royal Throne Room", "The king's bedroom. A secret room behind the audience chamber.");

            //Set indexes of roomList to the new structs.
            roomList[0] = room1;
            roomList[1] = room2;
            roomList[2] = room3;
            roomList[3] = room4;
            roomList[4] = room5;

            //Add rooms to ListBox
            foreach (Room r in roomList)
                roomListBox.Items.Add(r.RoomName);

            //Set selected index to 0.
            roomListBox.SelectedIndex = 0;
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRoomInfo(roomList);  //Display current index
        }

        private void DisplayRoomInfo(Room[] rList)
        {
            //Set temp equal to the name of the selected index.
            string temp = roomListBox.Items[roomListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < rList.Length; i++)
                if (rList[i].RoomName == temp)
                {
                    rNameLabel.Text = rList[i].RoomName;
                    rDescLabel.Text = rList[i].RoomDescription;
                }
        }
    }
}
