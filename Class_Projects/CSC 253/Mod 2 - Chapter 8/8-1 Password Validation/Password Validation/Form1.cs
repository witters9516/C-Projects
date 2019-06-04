﻿/**
* 9/17/17
* CSC 253
* Shawn Witter
* This program asks the user to create a password and determines if it is valid.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The NumberUpperCase method accepts a string as an argument
        //and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            int upperCase = 0;  //The number of uppercase letters

            //Count the uppercase characters in str
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }

            //Return the number of uppercase characters.
            return upperCase;
        }

        //The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            int lowerCase = 0;  //The number of lowerCase letters

            //Count the lowerCase characters in str
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }

            //Return the number of lowerCase characters.
            return lowerCase;
        }

        //The NumberDigit method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digits = 0;  //The number of digits

            //Count the digits in str
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }

            //Return the number of digits.
            return digits;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;   //Password minimum length

            //Get the password from the textbox
            string password = passwordTextBox.Text;

            //Validate the password
            if (password.Length >= MIN_LENGTH &&
                NumberUpperCase(password) >= 1 &&
                NumberLowerCase(password) >= 1 &&
                NumberDigits(password) >= 1)
            {
                MessageBox.Show("The Password is valid.");
            }
            else
            {
                MessageBox.Show("The password does not meet the requirements.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
