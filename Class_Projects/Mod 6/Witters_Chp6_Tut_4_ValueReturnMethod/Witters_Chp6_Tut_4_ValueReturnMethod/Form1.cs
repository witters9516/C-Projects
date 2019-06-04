//CSC 153 M6T 4
//Witters_Chp6_Tutorial_4_CupsToOunces
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

namespace Witters_Chp6_Tut_4_ValueReturnMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The CupsToOunces method accepts a number
        //of cups as an argument and returns the
        //equivalent number of fluid ounces.
        private double CupsToOunces(double cups)
        {
            return cups * 8.0;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //Variable to hold cups and ounces
            double cups, ounces;

            //Get the number of cups
            if (double.TryParse(cupsTextbox.Text, out cups))
            {
                //Convert the cups to ounces
                ounces = CupsToOunces(cups);

                //Display the ounces
                ouncesLabel.Text = ounces.ToString("n1");
            }
            else
            {
                //Display the error message
                MessageBox.Show("Enter a valid number.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
