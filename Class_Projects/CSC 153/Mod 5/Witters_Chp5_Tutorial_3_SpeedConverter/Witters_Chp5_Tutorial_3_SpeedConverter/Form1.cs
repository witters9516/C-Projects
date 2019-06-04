//CSC 153 M5T 3
//Witters_Chp5_Tutorial_3_SpeedConverter
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

namespace Witters_Chp5_Tutorial_3_SpeedConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //Constants
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            //Variables
            int kph;    //Kilometers per hour
            double mph; //Miles Per Hour

            //Display the table of speeds.
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                //Calculate miles per hour
                mph = kph * CONVERSION_FACTOR;

                //Display the Conversion
                outputListBox.Items.Add(kph + " KPH is the same as " +
                    mph + " MPH");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
