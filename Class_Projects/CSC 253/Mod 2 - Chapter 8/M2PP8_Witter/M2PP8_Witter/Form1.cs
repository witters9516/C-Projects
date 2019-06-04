/**
* 9/24/2017
* CSC 253
* Shawn Witter
* This program prompts the user to enter numbers that are separated by 
* commas. the program then finds the sum of those numbers.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2PP8_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The method Sum accepts a string as an argument.
        //The method returns a string. The method splits 
        //the input into numbers and adds them together to 
        //get the return value that is then parsed as a string.
        private string Sum(string input)
        {
            //Variables
            string[] inputArray = input.Split(',');
            int[] numbers = new int[inputArray.Length];
            int count = 0;
            int sum = 0;

            try
            {
                foreach (string str in inputArray)
                {
                    //Trim str
                    string strTemp = str.Trim();
                    //try to parse str as an int.
                    if (int.TryParse(strTemp, out numbers[count]))
                        count++;    //increment count
                }

                //Add all the numbers up using a for loop.
                for (int i = 0; i < numbers.Length; i++)
                    sum += numbers[i];

                //Return the sum as a string.
                return sum.ToString();
            }
            catch (Exception ex)
            {
                //Display the error message.
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void findSumButton_Click(object sender, EventArgs e)
        {
            //Variables
            string input = inputTextBox.Text;
            string output = Sum(input);

            //Display to screen
            sumLabel.Text = output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
