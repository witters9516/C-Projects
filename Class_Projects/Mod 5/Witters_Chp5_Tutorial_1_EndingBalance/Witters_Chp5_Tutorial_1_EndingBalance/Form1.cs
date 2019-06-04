//CSC 153 M5T 1and2
//Witters_Chp5_Tutorial_1and2_EndingBalance
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

namespace Witters_Chp5_Tutorial_1_EndingBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Constant for the monthly interest rate
            const decimal INTEREST_RATE = 0.005m;

            //Local Variables
            decimal balance;    //The account balance
            int months;         //The number of months
            int count = 1;      //Loop Counter, initialized at 1

            //Get the starting balance
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                //Get the number of months
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    //The following loop calculates the ending balance
                    while (count <= months)
                    {
                        //Add this month's interest to the balance
                        balance = balance + (INTEREST_RATE * balance);

                        //Display this month's ending balance
                        detailListBox.Items.Add("The ending balance " +
                            "for month " + count + " is " +
                            balance.ToString("c"));

                        //Add one to the loop counter
                        count = count + 1;
                    }

                    //Display the ending balance
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    //Invalid starting balance was entered.
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else
            {
                //Invalid Starting balance was entered 
                MessageBox.Show("Invalid value for starting balance.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes and the endingBalanceLabel
            //and the ListBox
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            //Reset focus
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
