//CSC 153 M5GL5
//Witters_Chp5_GL5_12and13 RandomNumber SaveandLoad
//Shawn Witter
//4/6/17
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

namespace Witters_M5_GL_13and14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The GetFileName Method gets a file name from the
        //user and assigns it to the variable passed as
        // an argument.
        private void GetFileName(out string selectedFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFile.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }

        //The GetRandomNumbers method accepts a filename as an
        //argument. It opens the specified file and displays
        //the contents to the listBox.
        private void GetRandomNumbers(string filename)
        {
            try
            {
                //Variables
                int totalSumRN = 0; //Running Total for Sum of all RNs
                int totalRN = 0;    //Running Total for total number of RNs

                //Declare a variable to hold a country name.
                string randomNumber;

                //Declare a StreamReader
                StreamReader inputFile;

                //Open the file and get a StreamReader object
                inputFile = File.OpenText(filename);

                //Read the file's contents
                while (!inputFile.EndOfStream)
                {
                    //Get a country name
                    randomNumber = inputFile.ReadLine();

                    //Print number to listBox
                    RNListBox.Items.Add(randomNumber);

                    //Keeps a running total pf all RNs
                    totalSumRN += int.Parse(randomNumber);

                    //Increments to keep a running total of RNs
                    totalRN++;
                }

                //Close the file
                inputFile.Close();

                //Update labels that keep the running total 
                //and the total number of random numbers
                totalRNLabel.Text = totalRN.ToString();
                totalSumRNLabel.Text = totalSumRN.ToString();
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        //The SaveRandomNumber method accepts a filename as an
        //argument. It opens the specified file and save
        //a certain number of RandomNumbers to its contents.
        private void SaveRandomNumbers(string filename, int randomsToHold)
        {
            Random rand = new Random();         //Random generator variable

            try
            {
                //Declare a variable to hold a country name.
                int randomNumber;

                //Declare a StreamReader AND Writer
                StreamWriter outputFile;

                //Open the file and get a StreamReader object
                outputFile = File.CreateText(filename);

                //Read the file's contents
                for (int i = 0; i < randomsToHold; i++)
                {
                    //New RN to write
                    randomNumber = rand.Next(100) + 1;

                    //Writes the RN to the file.
                    outputFile.WriteLine(randomNumber);
                }

                //Close the file
                outputFile.Close();
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            //Variables
            int randomsToHold = 0;   //How many are going to be written to a file.
            string filename;         //To hold the filename

            //Get number of random numbers to generate
            if (int.TryParse(RNtextBox.Text, out randomsToHold))
            {
                //Get the filename from the user
                GetFileName(out filename);

                //Set the filename from the user
                SaveRandomNumbers(filename, randomsToHold);
            }
            else
            {
                MessageBox.Show("Error! The number of random number being written must be an integer!");
            }  
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string filename;    //to hold the filename.

            //Get the filename from the user
            GetFileName(out filename);

            //Get the countries from the file
            GetRandomNumbers(filename);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
