/**
* 11/11/2017
* CSC 253
* Shawn Witter, Tanisha Robertson, Dexter Wilder,  William Crockett
* This is the Dungeon Crawl Game for Part 4.
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
using ClassLibrary;

namespace DungeonCrawl
{
    public partial class Form1 : Form
    {
        public static BaseBattlerClass player;
        public static string currentRoom;
        public static int currentRoomIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //Create a NewGame form
            NewGame newGameForm = new NewGame();

            //ShowDialog for NewGame Form for Player Creation
            OpenFormDialog(newGameForm);
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            //Create a LoadGame form
            LoadGame loadGameForm = new LoadGame();

            //ShowDialog for LoadForm for Player Loading
            OpenFormDialog(loadGameForm);
        }

        private void otherInfoButton_Click(object sender, EventArgs e)
        {
            OtherInfo otherInfoForm = new OtherInfo();
            this.Hide();
            otherInfoForm.ShowDialog();
            this.Show();
        }

        //The ExecuteGame method creates a Main Game form and displays it.
        private void ExecuteGame()
        {
            DungeonCrawlGame dcgForm = new DungeonCrawlGame();
            DungeonCrawlGame.player = player;
            DungeonCrawlGame.currentRoom = currentRoom;
            DungeonCrawlGame.currentRoomIndex = currentRoomIndex;

            this.Hide();
            dcgForm.ShowDialog();
            this.Show();
        }

        //The OpenFormDialog takes a form object as an argument.
        //The method opens that form and based of the player object that comes back,
        //The whole program closes or the program takes the user to the main game.
        private void OpenFormDialog(Form form)
        {
            //Hide this form while the new form is showing, then show it when the new form is closed.
            this.Hide();
            form.ShowDialog();
            this.Show();

            //If the player is Not null, start game. Else, diaplay error and close the program.
            if (player != null)
                ExecuteGame();
            else
                DisplayFaultyGame();
        }

        //The DisplayFaultyGame method displays an error message stating that
        //the user did not load or get created so it cannot continue. The
        //main program (this) closes and has to be restarted.
        private void DisplayFaultyGame()
        {
            //Display Error Message.
            MessageBox.Show("ERROR: You did not create a player so the game cannot begin.");
        }
    }
}
