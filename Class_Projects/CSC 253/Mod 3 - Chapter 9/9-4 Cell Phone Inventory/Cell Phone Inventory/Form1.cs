/**
* 9/26/17
* CSC 253
* Shawn Witter
* This program allows a user to enter data into the textboxes and creates Cellphone objects that will be held in a list.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        //List to hold CellPhone Objects
        List<CellPhone> phoneList = new List<CellPhone>();

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

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            //Create a cellphone Object
            CellPhone myPhone = new CellPhone();

            //Get the phone data
            GetPhoneData(myPhone);

            //Add the CellPhone Object to the List
            phoneList.Add(myPhone);

            //Add an entry to the listBox
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model);

            //Clear the textbox controls
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            //Reset the focus
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of the selected item
            int index = phoneListBox.SelectedIndex;

            //Display the selected item's price
            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
