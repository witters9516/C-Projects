//CSC 153 M5HW8
//Witters_Chp5_HW8_2DistanceFile
//Shawn Witter
//3/9/17

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


namespace Witters_HW8_2DistanceFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double speed;
            double hoursTraveled;
            double.TryParse(speedTextbox.Text, out speed);
            double.TryParse(hoursTextbox.Text, out hoursTraveled);

            try
            {
                //Declare a StreamWriter variable
                StreamWriter outputFile;

                //Open the Freiend.txt file for appending
                //and get a StreamWriter
                outputFile = File.CreateText("distance.txt");


                for (int i = 0; i < hoursTraveled; i++)
                {
                    double distance = speed * (i + 1);

                    //Write the friend's name to the file.
                    outputFile.WriteLine("In " + (i + 1) + " hours, the distance is " + distance.ToString() + ".");

                }

                //Close this file
                outputFile.Close();

                //Let the user know the name was written
                MessageBox.Show("The distance was written.");
            }
            catch (Exception ex)
            {
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
