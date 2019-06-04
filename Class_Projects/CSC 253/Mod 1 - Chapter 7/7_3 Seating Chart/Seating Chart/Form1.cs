﻿/**
* 8/21/2017
* CSC 253
* Shawn Witter
* This program generates a price that the user must pay based on what seat they choose.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            //Variables for the selected row and column.
            int row, col;

            //Constants for the maximum row and column subscripts
            const int MAX_ROW = 5;
            const int MAX_COL = 3;

            //Create an array with the seat prices.
            decimal[,] prices = { {450m, 450m, 450m, 450m},
                                {425m, 425m, 425m, 425m},
                                {400m, 400m, 400m, 400m},
                                {375m, 375m, 375m, 375m},
                                {375m, 375m, 375m, 375m},
                                {350m, 350m, 350m, 350m}
                                };

            //Get the selected row number.
            if (int.TryParse(rowTextBox.Text, out row))
            {
                //Get the selected column number.
                if (int.TryParse(colTextBox.Text, out col))
                {
                    //Make sure the row is within range.
                    if (row >= 0 && row <= MAX_ROW)
                    {
                        //Make sure the column is within range
                        if (col >= 0 && col <= MAX_COL)
                        {
                            //Display the selected seat's price
                            priceLabel.Text = prices[row, col].ToString("c");
                        }
                        else
                        {
                            //Error message for invalid column
                            MessageBox.Show("Column must be 0 through " + MAX_COL);
                        }
                    }
                    else
                    {
                        //Error message for invalid row
                        MessageBox.Show("Row must be 0 through " + MAX_ROW);
                    }
                }
                else
                {
                    //Error message for noninteger column
                    MessageBox.Show("Enter an integer for the column.");
                }
            }
            else
            {
                //Error message for noninteger row
                MessageBox.Show("Enter an integer for the row.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
