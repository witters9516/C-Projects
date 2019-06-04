//CSC 153 M6T 3
//Witters_Chp6_Tutorial_3_NorthAmerica
//Shawn Witter
//3/28/17

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

namespace Witters_Chp6_Tutorial_3_NorthAmerica
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

        //The GetCountries method accepts a filename as an
        //argument. It opens the specified file and displays
        //an argument.
        private void GetCountries(string filename)
        {
            try
            {
                //Declare a variable to hold a country name.
                string countryName;

                //Declare a StreamReader
                StreamReader inputFile;

                //Open the file and get a StreamReader object
                inputFile = File.OpenText(filename);

                //Clear anything currently in the listBox
                countriesListBox.Items.Clear();

                //Read the file's contents
                while (!inputFile.EndOfStream)
                {
                    //Get a country name
                    countryName = inputFile.ReadLine();

                    //Add the country name to the ListBox
                    countriesListBox.Items.Add(countryName);
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

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string filename;    //to hold the filename.

            //Get the filename from the user
            GetFileName(out filename);

            //Get the countries from the file
            GetCountries(filename);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
