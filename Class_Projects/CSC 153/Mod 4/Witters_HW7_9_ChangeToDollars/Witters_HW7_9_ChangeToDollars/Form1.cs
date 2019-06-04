//CSC 153 M4HW7
//Witters_Chp4_HW7_9 ChangeToDollars
//Shawn Witter
//3/9/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_HW7_9_ChangeToDollars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        const decimal PENNY = .01m;
        const decimal NICKEL = .05m;
        const decimal DIME = .1m;
        const decimal QUARTER = .25m;
        decimal total = 0.00m;



        private void totalButton_Click(object sender, EventArgs e)
        {
            decimal pennyTotal = PENNY * decimal.Parse(pennyTextBox.Text);
            decimal nickelTotal = NICKEL * decimal.Parse(nickelTextBox.Text);
            decimal dimeTotal = DIME * decimal.Parse(dimeTextBox.Text);
            decimal quarterTotal = QUARTER * decimal.Parse(quarterTextBox.Text);

            total = pennyTotal + nickelTotal + dimeTotal + quarterTotal;
            if (total == 1)
            {
                totalChangeCollectedLabel.Text = "$" + total.ToString();
                MessageBox.Show("CONGRATULATIONS!\nYOU WIN!!!");
            }

            else if (total > 1)
            {
                totalChangeCollectedLabel.Text = "$" + total.ToString();
                MessageBox.Show("You have gone over $1");
                total = 0;
            }
            else
            {
                totalChangeCollectedLabel.Text = "$" + total.ToString();
            }
        }

            
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            total = 0.0m;
            pennyTextBox.Text = "";
            nickelTextBox.Text = "";
            dimeTextBox.Text = "";
            quarterTextBox.Text = "";
            totalChangeCollectedLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

    }
}
