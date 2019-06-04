/**
* 10/28/17
* CSC 253
* Shawn Witter
* This program uses inheritance by creating a copy of PrefferredCustomer
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

namespace M4PP5_Witter
{
    public partial class PreferredCustomerClass : Form
    {
        public PreferredCustomerClass()
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
                decimal purchaseAmount = decimal.Parse(customerPurchaseAmountTextBox.Text);

                //Create an object with the variables.
                PreferredCustomer customer1 = new PreferredCustomer(purchaseAmount);
                customer1.SetName(name);
                customer1.SetAddress(address);
                customer1.SetTelephoneNumber(teleNumber);
                customer1.SetCustomerNumber(custNumber);
                customer1.SetMailingListOption(SetMailingOption());

                //Display the info using the get fuctions.
                cusNameDisplayLabel.Text = customer1.GetName();
                cusAddressDisplayLabel.Text = customer1.GetAddress();
                cusTeleNumberDisplayLabel.Text = customer1.GetTelephoneNumber();
                cusNumberDisplayLabel.Text = customer1.GetCustomerNumber();
                cusMailListDisplayLabel.Text = customer1.GetMailingListOption();
                customerPurchaseAmountLabel.Text = customer1.GetCustomerPurchase().ToString("c");
                customerDiscountLabel.Text = customer1.GetCustomerDiscount().ToString();

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
