/**
* 10/19/17
* CSC 253
* Shawn Witter
* This program utilizes inheritance to create a customer class.
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
using ClassLibrary;

namespace M4PP4_Witter
{
    public partial class PersonAndCustomerClass : Form
    {
        public PersonAndCustomerClass()
        {
            InitializeComponent();
        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                string teleNumber = teleNumTextBox.Text;
                string custNumber = cusNumTextBox.Text;
                bool joinMailList = SetMailingOption();

                //Create an object with the variables.
                Customer customer1 = new Customer(name, address, teleNumber, custNumber, joinMailList);

                //Display the info using the get fuctions.
                cusNameDisplayLabel.Text = customer1.GetName();
                cusAddressDisplayLabel.Text = customer1.GetAddress();
                cusTeleNumberDisplayLabel.Text = customer1.GetTelephoneNumber();
                cusNumberDisplayLabel.Text = customer1.GetCustomerNumber();
                cusMailListDisplayLabel.Text = customer1.GetMailingListOption();
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private bool SetMailingOption()
        {
            //Return whatever option is chosen by user.
            if (yesRadioButton.Checked == true)
                return true;
            else
                return false;
        }
    }
}
