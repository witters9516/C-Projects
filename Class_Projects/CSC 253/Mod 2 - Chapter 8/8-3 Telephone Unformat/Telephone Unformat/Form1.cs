using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The IsValidNumber method accepts a string and
        //determines whether it is properly formatted as
        //a US telephone number in the following manner:
        //(XXX)XXX-XXXX
        //If the argument is properly formatted, the method
        //returns true, otherwise false.
        private bool IsValidFormat(string str)
        {
            const int VALID_LENGTH = 13;    //length of a vaild string
            bool valid = true;              //flag to indicate validity

            //Determine if the string is properly formated.
            if (str.Length == VALID_LENGTH && str[0] == '(' &&
                str[4] == ')' && str[8] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            //Return the status
            return valid;
        }

        //The Unformat method accepts a string argument, by reference
        //assumed to contain a telephone number formatted in
        //this manner: (XXX)XXX-XXXX
        //The method unformats the string by removing the
        //the parenthesis and the hyphen.
        private void Unformat(ref string str)
        {
            //First, remove the left paren at position 0.
            str = str.Remove(0, 1);

            //Next, Delete the right paren. Because the
            //Previous deletion it is now located at
            //position 3.
            str = str.Remove(3, 1);

            //Next, Delete the hyphen. Because the
            //Previous deletions it is now located at
            //position 6.
            str = str.Remove(6, 1);
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            //get a trimmed copy of the user's input
            string input = numberTextBox.Text.Trim();

            //If the input is properly formatted, unformat it
            //and display it
            if (IsValidFormat(input))
            {
                Unformat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                //Display an error message
                MessageBox.Show("Invalid Input.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
