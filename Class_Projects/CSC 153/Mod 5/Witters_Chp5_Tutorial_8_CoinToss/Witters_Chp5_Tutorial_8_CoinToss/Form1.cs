//CSC 153 M5T 8
//Witters_Chp5_Tutorial_8_Cointoss
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

namespace Witters_Chp5_Tutorial_8_CoinToss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Variable to indicate which side is up
            int sideUp;

            //Create a Rondom Object
            Random rand = new Random();

            //Get a random integer in the range of 0 through 1
            //0 means tails up, 1 is heads up.
            sideUp = rand.Next(2);

            //Display the side that is up
            if (sideUp == 0)
            {
                //Display tails up
                tailsPicturebox.Visible = true;
                headsPicturebox.Visible = false;
            }
            else
            {
                //Display heads up
                headsPicturebox.Visible = true;
                tailsPicturebox.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }


    }
}
