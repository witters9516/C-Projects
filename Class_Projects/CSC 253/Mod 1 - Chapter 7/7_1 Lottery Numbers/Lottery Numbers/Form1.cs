/**
* 8/21/2017
* CSC 253
* Shawn Witter
* This program generates a set of lottery numbers by using arrays.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Create an array to hold the numbers
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            //Create a Random Object
            Random rand = new Random();

            //Fill the array with random numbers, in the range
            // of 0 through 99.
            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(100);
            }

            // Display the array elements in the Label Controls.
            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString();
            fifthLabel.Text = lotteryNumbers[4].ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form.
            this.Close();
        }
    }
}
