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
namespace DungeonCrawl1_Witter
{
    #region PlayerInformation
    //Enum for playerClass
    enum playerClass
    {
        WARRIOR, MAGE, JEDI
    };

    //Enum for playerRace
    enum playerRace
    {
        ELF, HUMAN, DWARF
    };

    //Player Struct
    struct Player
    {
        public string playerName;
        public string password;
        public playerClass playerClass;
        public playerRace playerRace;
    };
    #endregion

    public partial class PlayerForm : Form
    {
        public PlayerForm()
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
                //Create new Player struct
                Player player = new Player();
                player.playerName = pNameTextBox.Text;
                player.password = pPasswordTextBox.Text;

                //Check Password.
                bool correctPassword = VerifyCreatedPassword(player.password);

                //Set playerClass
                if (warriorRadioButton.Checked == true)
                    player.playerClass = playerClass.WARRIOR;
                else if (mageRadioButton.Checked == true)
                    player.playerClass = playerClass.MAGE;
                else if (jediRadioButton.Checked == true)
                    player.playerClass = playerClass.JEDI;

                //Set playerRace
                if (dwarfRadioButton.Checked == true)
                    player.playerRace = playerRace.DWARF;
                else if (elfRadioButton.Checked == true)
                    player.playerRace = playerRace.ELF;
                else if (humanRadioButton.Checked == true)
                    player.playerRace = playerRace.HUMAN;

                //If there are no problems with the passwords, the program writes a player file.
                if (correctPassword == true)
                {
                    string filename = player.playerName + ".txt";
                    StreamWriter playerFile = File.CreateText(filename);

                    playerFile.WriteLine(player.playerName);
                    playerFile.WriteLine(player.password);
                    playerFile.WriteLine(player.playerClass.ToString());
                    playerFile.WriteLine(player.playerRace.ToString());

                    playerFile.Close();
                }
                else
                {
                    //Tell player it came out wrong.
                    MessageBox.Show("The player could not be created because the password is not valid.");
                }
            }
            catch (Exception ex)
            {
                //Display error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void loadInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create string to form a file name.
                string filename = playerNameCheckTextBox.Text + ".txt";

                //Open a File with the created string.
                StreamReader inFile = File.OpenText(filename);

                //Create a string to hold all of the files contents to be split later.
                string str = "";

                //Loop to add info to the str string
                while (!inFile.EndOfStream)
                    str += inFile.ReadLine() + " ";

                //Create an array from splitting a string.
                string[] strArray = str.Split(null);

                //Check Password from player input to see if it is correct.
                //If the password is correct, it displays the information to the user.
                //If the password is incorrect, it says that the person has inputed the wrong password.
                if (strArray[1] != playerPasswordCheckTextBox.Text)
                    MessageBox.Show("You have entered an incorrect password.");
                else
                    for (int i = 0; i < strArray.Length; i++)
                        if (i == 0)
                            pNameLabel.Text = strArray[0];      //Display PlayerName
                        else if (i == 1)
                            pPasswordLabel.Text = strArray[1];  //Display PlayerPassword
                        else if (i == 2)
                            pClassLabel.Text = strArray[2];     //Display PlayerClass
                        else if (i == 3)
                            pRaceLabel.Text = strArray[3];      //Display PlayerRace
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
