//CSC 153 M4T4
//Witters_Chp4_Tutorial_4 CalculateMPG
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

namespace Witters_Chp4_Tutorial_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;   //To hold Miles Driven
            double gallons; //To hold Gallons used
            double mpg;     //To hold MPG

            //Validate the milesTextbox control
            if (double.TryParse(milesTextBox.Text, out miles))
            {
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    //Calculate MPG
                    mpg = miles / gallons;

                    //Display the MPG in the mpgLabel control.
                    mpgLabel.Text = mpg.ToString("n1");
                }
                else
                {
                    //Display error message for gallons textbox
                    MessageBox.Show("Invalid input for gallons.");
                }
            }
            else
            {
                //Display error message for miles textbox
                MessageBox.Show("Invalid input for miles.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
