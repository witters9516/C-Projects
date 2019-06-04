using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PreferredCustomer : Customer
    {
        //fields
        decimal customerPurchases;
        decimal customerDiscountLevel;

        //No-Arg Constructor
        public PreferredCustomer()
        {
            customerPurchases = 0.0m;
            customerDiscountLevel = 0.0m;
        }

        /**
         * Constructor that takes 4 strings and 1 bool
         * @param purchase - Customer's purchase amount
         */
        public PreferredCustomer(decimal purchase)
        {
            customerPurchases = purchase;
            customerDiscountLevel = FindDiscount(customerPurchases);
        }

        //Getters
        public decimal GetCustomerPurchase()
        {
            return customerPurchases;
        }

        public decimal GetCustomerDiscount()
        {
            return customerDiscountLevel;
        }

        //Setters
        public void SetCustomerPurchase(decimal purchase)
        {
            customerPurchases = purchase;
        }

        public void SetCustomerDiscount(decimal discount)
        {
            customerDiscountLevel = discount;
        }

        //The FindDiscount method takes a decimal as an argument. 
        //This method uses that argument to discern a discount value.
        public decimal FindDiscount(decimal amount)
        {
            //create a temp decimal to return later.
            decimal tempDiscount = 0.0m;

            //Conditional to find discount.
            if (amount < 500.0m)
                tempDiscount = 0.0m;
            else if (amount <= 1000.0m)
                tempDiscount = .05m;
            else if (amount <= 1500.0m)
                tempDiscount = .06m;
            else if (amount <= 1500.0m)
                tempDiscount = .07m;
            else
                tempDiscount = .1m;

            //return tempDiscount
            return tempDiscount;
        }
    }
}
