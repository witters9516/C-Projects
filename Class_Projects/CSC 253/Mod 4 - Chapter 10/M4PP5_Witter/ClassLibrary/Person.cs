using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        //fields
        private string name;                //Person's name
        private string address;             //Person's address
        private string telephoneNumber;     //Person's telephone number

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }
    }
}
