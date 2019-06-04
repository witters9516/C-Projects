//CSC 153 M4T6
//Witters_Chp4_Tutorial_6 TimeZone
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

namespace Witters_Chp4_Tutorial_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city; // to hold the city name

            if (cityListBox.SelectedIndex != -1)
            {
                //Get the selected item
                city = cityListBox.SelectedItem.ToString();

                //Determine the time zone
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;
                }
            }
            else
            {
                //No city was selected.
                MessageBox.Show("Select a City.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
