//CIS-153-M3T5
//Witters_Chp3_Tutorial_5_ChangeCounter
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

namespace Witters_Chp3_Tutorial_5_ChangeCounter
{
    public partial class Form1 : Form
    {
        //Constant Feilds
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        //Field variable to hold the total 
        //initialized with o
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add the value of five cents to the total
            total += FIVE_CENTS_VALUE;

            //Display the total, Formatted as currency
            totalLabel.Text = total.ToString();
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add the value of ten cents to the total
            total += TEN_CENTS_VALUE;

            //Display the total, Formatted as currency
            totalLabel.Text = total.ToString();
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add the value of twenty five cents to the total
            total += TWENTY_FIVE_CENTS_VALUE;

            //Display the total, Formatted as currency
            totalLabel.Text = total.ToString();
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add the value of fifty cents to the total
            total += FIFTY_CENTS_VALUE;

            //Display the total, Formatted as currency
            totalLabel.Text = total.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
