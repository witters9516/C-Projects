//CSC 153 M5T 6-7
//Witters_Chp5_Tutorial_6_And_7_South America
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

namespace Witters_Chp5_Tutorial_6_And_7_SouthAmerica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable to hold a country name
                string countryName;

                //Declare a StreamReader variable
                StreamReader inputFile;

                //Open the file and a get a StreamReader Object
                inputFile = File.OpenText("Countries.txt");

                //Clear anything currently in the listbox
                countriesListBox.Items.Clear();

                //Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    //Get a Country Name
                    countryName = inputFile.ReadLine();

                    //Add the country name to the ListBox
                    countriesListBox.Items.Add(countryName);
                }

                //Close the file
                inputFile.Close();
            }
            catch(Exception ex)
            {
                //Display the Error message
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
