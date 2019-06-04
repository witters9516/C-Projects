//CIS-153-HW4-2
//Witters_HW4_2_TipTaxTotal
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

namespace WItters_HW4_2_TipTaxAndTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBillButton_Click(object sender, EventArgs e)
        {
            //Variables
            double billPrice;
            double salesTax;
            double tip;

            
            //Calculate Sales Tax
            salesTax = double.Parse(billPriceTextbox.Text) * 0.07;

            //Print Sales Tax to screen
            taxPrintLabel.Text = salesTax.ToString("c");

            //Calculate Tip
            tip = (double.Parse(billPriceTextbox.Text) + salesTax) * .15;

            //Print Tip to the Screen
            tipPrintLabel.Text = tip.ToString("c");
            
            //Get bill price
            billPrice = double.Parse(billPriceTextbox.Text);
            billPrice = billPrice + salesTax + tip;

            //Print out the bill price below.
            billPrintLabel.Text = billPrice.ToString("c");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
