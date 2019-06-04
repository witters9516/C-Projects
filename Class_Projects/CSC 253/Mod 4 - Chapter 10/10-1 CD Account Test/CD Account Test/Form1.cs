/**
* 10/28/17
* CSC 253
* Shawn Witter
* This program demonstrates inheritance by creating an instance of CDAccount.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The GetCDData Method accepts a CDAccount object as an argument.
        //It assigns the data entered by the user to the object's properties.
        private void GetCDData(CDAccount account)
        {
            //Temporary variables to hold interest rate and balnace
            decimal interestRate;
            decimal balance;

            // Get the Account number
            account.AccountNumber = accountNumberTextBox.Text;

            // Get the maturity date
            account.MaturityDate = maturityDateTextBox.Text;

            //Get the interest Rate
            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                //Get the Balance
                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    //Display an error message
                    MessageBox.Show("Invalid Balance.");
                }
            }
            else
            {
                //Display an error message
                MessageBox.Show("Invalid Interest Rate.");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a CDAccount object
            CDAccount myAccount = new CDAccount();

            //Get the CD Account Data.
            GetCDData(myAccount);

            //Display the CD Account Data
            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
