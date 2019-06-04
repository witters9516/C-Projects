using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2PP7_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ConvertToPigLatin(string str)
        {
            //Variables
            char[] array = str.ToCharArray();
            char temp = array[0];               //Set to the first letter of the word.

            //Loop to run through word.
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '.')
                {
                    array[i] = ' ';
                }

                if (i != (array.Length - 1))    //if not the last index; set current i to i+1)
                    array[i] = array[i + 1];
                else
                    array[i] = temp;             //Set the value to the first letter of the word.
                
            }

            //Initialize return string.
            string output = "";

            //Loop to construct return string.
            foreach (char ch in array)
                output += ch.ToString();

            //Add the phrase "ay" to the end of each word.
            output += "ay ";

            //Return the output string.
            return output.ToUpper();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            //Variables
            string input = inputTextBox.Text;
            string[] tokens = input.Split(null);

            //Loop to convert input to Pig latin.
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i] = ConvertToPigLatin(tokens[i]);
                outputLabel.Text += tokens[i];
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
