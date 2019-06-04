using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Witters_Chp5_GL5_12_CalcFactNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Variables
            int inputNumberToFind;
            int temp;
            int factorial = 1;

            int.TryParse(numberTextbox.Text, out inputNumberToFind);

            if (inputNumberToFind > 0)
            {

                for (int i = 0; i <= inputNumberToFind; i++)
                {

                    if (i == 0)
                    {
                        //Assign temp to 1 so the factorial will not result in 0.
                        temp = i + 1;
                        //Multiply factorial by temp
                        factorial *= temp;

                    }
                    else
                    {
                        //Set temp to the value of i
                        temp = i;
                        //Multiply factorial by temp
                        factorial *= temp;
                    }
                }
                //Display final result of Factorial.
                displayFactorialLabel.Text = factorial.ToString();
            }
            else
            {
                //Display if the user enters a negative number.
                MessageBox.Show("You have entered an invalid number. The number must be negative.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void openDiaBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a StreamWriter variable
                StreamWriter outputFile;

                //Open the Freiend.txt file for appending
                //and get a StreamWriter
                outputFile = File.AppendText("factorial.txt");
                


                //Write the friend's name to the file.
                //outputFile.WriteLine(nameTextBox.Text);

                //Close this file
                outputFile.Close();

                //Let the user know the name was written
                //MessageBox.Show("The name was written.");

                //Clear the nameTextBox control
                //nameTextBox.Text = "";

                //Give the focus to the nameTextBox
                //nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
