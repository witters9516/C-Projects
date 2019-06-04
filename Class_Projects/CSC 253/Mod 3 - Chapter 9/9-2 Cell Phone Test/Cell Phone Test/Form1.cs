﻿/**
* 9/26/17
* CSC 253
* Shawn Witter
* This program lets the user input the brand, model, and price of a cell phone.
* The system then makes an instance of that object and displays its properties.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The GetPhoneData method accepts a CellPhone object
        //as an argument. It assigns the data entered by the
        //user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            //Temporary variable to hold the price
            decimal price;

            //Get the phone's brand
            phone.Brand = brandTextBox.Text;

            //Get the phone's brand
            phone.Model = modelTextBox.Text;

            //Get the phone's price
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                //Display an error message
                MessageBox.Show("Invalid price.");
            }
        }


        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a CellPhone Object
            CellPhone myPhone = new CellPhone();

            //Get the phones Data
            GetPhoneData(myPhone);

            //Display the phone data
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
