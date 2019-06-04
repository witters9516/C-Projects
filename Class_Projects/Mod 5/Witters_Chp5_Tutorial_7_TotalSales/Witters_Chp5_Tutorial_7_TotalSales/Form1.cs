﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Witters_Chp5_Tutorial_7_TotalSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                decimal sales;      //To hold a sales amount
                decimal total = 0m; //Accumulator, set to 0

                //Declare a StreamReader variable.
                StreamReader inputFile;

                //Open the file and get a StreamReader object
                inputFile = File.OpenText("Sales.txt");

                //Read the Files contents
                while (!inputFile.EndOfStream)
                {
                    //Get a sales amount
                    sales = decimal.Parse(inputFile.ReadLine());

                    //Add the sales amount to the total
                    total += sales;
                }

                //Close the File
                inputFile.Close();

                //Display the total
                totalLabel.Text = total.ToString("C");

            }
            catch (Exception ex)
            {
                //Display the error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
