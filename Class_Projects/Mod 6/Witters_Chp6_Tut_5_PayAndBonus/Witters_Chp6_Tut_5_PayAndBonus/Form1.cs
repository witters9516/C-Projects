//CSC 153 M6T 5
//Witters_Chp6_Tutorial_5_PayAndBonus
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

namespace Witters_Chp6_Tut_5_PayAndBonus
{
    public partial class Form1 : Form
    {
        //Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        //
        //
        //
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            //Flag variable to indicate whether the input is good
            bool inputGood = false;

            //Try to convert both inputs to decimal
            if (decimal.TryParse(grossPayTextbox.Text, out pay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    //Both inputs are good
                    inputGood = true;
                }
                else
                {
                    //Display an error message for the bonus.
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                //Display error message for gross pay.
                MessageBox.Show("Gross pay is invalid.");
            }
            //Return the result.
            return inputGood;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables for gross pay, bonus, and contributions
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if (InputIsValid(ref grossPay, ref bonus))
            {
                //Calculates the amount of contribution.
                contributions = (grossPay + bonus) * CONTRIB_RATE;

                //Displays the Contribution.
                contributionLabel.Text = contributions.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
