/**
* 9/26/17
* CSC 253
* Shawn Witter
* This program flips a coin 5 times and then displays the results to the screen.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Create a coin Object
            Coin myCoin = new Coin();

            //Clear the ListBox
            outputListBox.Items.Clear();

            //Toss the coin five times
            for (int count = 0; count < 5; count++)
            {
                //Toss the coin
                myCoin.toss();

                //Display the side that is up
                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
