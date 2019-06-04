//CSC 153 M5T 4-5
//Witters_Chp5_Tutorial_4_And_5_FriendFile
//Shawn Witter
//1/24/17

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

namespace Witters_Chp5_Tutorial_4_FriendFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a StreamWriter variable
                StreamWriter outputFile;

                //Open the Freiend.txt file for appending
                //and get a StreamWriter
                outputFile = File.AppendText("Friend.txt");

                //Write the friend's name to the file.
                outputFile.WriteLine(nameTextBox.Text);

                //Close this file
                outputFile.Close();

                //Let the user know the name was written
                MessageBox.Show("The name was written.");

                //Clear the nameTextBox control
                nameTextBox.Text = "";

                //Give the focus to the nameTextBox
                nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
