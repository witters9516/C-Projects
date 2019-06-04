/**
* 9/17/17
* CSC 253
* Shawn Witter
* This program reads in grades from a csv file.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile; //to read the file
                string line;            //To hold a line from the file.
                int count = 0;          //Student Counter
                int total;              //Accumulator
                double average;         //Test Score Average

                //Create a Delimiter array
                char[] delim = { ',' };

                //Open the CSV File.
                inputFile = File.OpenText("Grades.csv");

                while (!inputFile.EndOfStream)
                {
                    //increment the student counter
                    count++;

                    //Read a line from the file.
                    line = inputFile.ReadLine();

                    //Get the test scores as tokens
                    string[] tokens = line.Split(delim);

                    //Set the accumulator to 0
                    total = 0;

                    //Calculate the total of the 
                    //test score tokens.
                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);
                    }

                    //Calculate the average of these test scores.
                    average = (double)total / tokens.Length;

                    //Display the average.
                    averagesListBox.Items.Add("The average for student " +
                        count + " is " + average.ToString("n1"));
                }

                //Close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
