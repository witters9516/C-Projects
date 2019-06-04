﻿//CIS-153-M3T4
//Witters_Chp3_Tutorial_4_TestAverage
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

namespace Witters_Chp3_Tutorial_4_TestAverage
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
                double test1;   //To hold test score #1
                double test2;   //To hold test score #2
                double test3;   //To hold test score #3
                double average; //To hold the average test score

                //Get the three test scores.
                test1 = double.Parse(test1Textbox.Text);
                test2 = double.Parse(test2Textbox.Text);
                test3 = double.Parse(test3Textbox.Text);

                //Calculate the average test score
                average = (test1 + test2 + test3) / 3.0;

                //Display the average test score, with
                //the output rounded to 1 decimal point.
                averageLabel.Text = average.ToString("n1");
            }
            catch(Exception ex)
            {
                //Display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the input and output controls
            test1Textbox.Text = "";
            test2Textbox.Text = "";
            test3Textbox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
