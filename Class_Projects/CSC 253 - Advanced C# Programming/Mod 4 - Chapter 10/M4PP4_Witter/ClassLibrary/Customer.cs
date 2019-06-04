using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer : Person
    {
        //fields
        string customerNumber;      //Customer's number
        bool wantMailingList;       //Customer's choice of being on the mailing list

        //Empty Constructor
        public Customer()
        {
            Name = "";
            Address = "";
            TelephoneNumber = "";
            customerNumber = "";
            wantMailingList = false;
        }

        /**
         * Constructor that takes 4 strings and 1 bool
         * @param name - Customer's name
         * @param address - Customer's address
         * @param phoneNumber - Customer's telephone number
         * @param custNumber - Customer's number
         * @param mailingList - Customer's option to join mailing list
         */
        public Customer(string name, string address, string phoneNumber, string custNumber, bool mailingList)
        {
            Name = name;
            Address = address;
            TelephoneNumber = phoneNumber;
            customerNumber = custNumber;
            wantMailingList = mailingList;
        }

        //Getters
        public string GetName()
        {
            return Name;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string GetTelephoneNumber()
        {
            return TelephoneNumber;
        }

        public string GetCustomerNumber()
        {
            return customerNumber;
        }

        public string GetMailingListOption()
        {
            if (wantMailingList == true)
                return "Yes";
            else
                return "No";
        }

        //Setters
        public void SetName(string str)
        {
            Name = str;
        }

        public void SetAddress(string str)
        {
            Address = str;
        }

        public void SetTelephoneNumber(string str)
        {
            TelephoneNumber = str;
        }

        public void SetCustomerNumber(string str)
        {
            customerNumber = str;
        }

        public void SetMailingListOption(bool bl)
        {
            wantMailingList = bl;
        }
    }
}
