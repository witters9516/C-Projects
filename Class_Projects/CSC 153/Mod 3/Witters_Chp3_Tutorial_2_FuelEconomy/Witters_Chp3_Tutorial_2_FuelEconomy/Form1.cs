﻿//CIS-153-M3T2
//Witters_Chp3_Tutorial_2_FuelEconomy
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

namespace Witters_Chp3_Tutorial_2_FuelEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;   //To hold miles driven
            double gallons; //To hold gallons used
            double mpg;     //To hold MPG

            //Get the miles driven and assign it to
            //the miles variable
            miles = double.Parse(milesTextbox.Text);

            //Get the gallons and assign it to
            //the gallons variable
            gallons = double.Parse(gallonsTextbox.Text);

            //Calculates MPG
            mpg = miles / gallons;

            //Display the MPG in the mpgLabel control
            mpgLabel.Text = mpg.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
