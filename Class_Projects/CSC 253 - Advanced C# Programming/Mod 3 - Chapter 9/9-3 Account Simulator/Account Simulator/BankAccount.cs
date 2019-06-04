using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account_Simulator
{
    class BankAccount
    {
        //Field
        private decimal _balance;

        //Constuctor
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        //Balance Property (Read-Only)
        public decimal Balance
        {
            get{ return _balance; }
        }

        //Deposit method
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        
        //Withdraw method
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}
