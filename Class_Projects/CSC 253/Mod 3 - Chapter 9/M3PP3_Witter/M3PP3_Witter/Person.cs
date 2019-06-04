using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3PP3_Witter
{
    class Person
    {
        //Variables
        private string myName;      //Employee's name
        private string myAddress;   //ID Number
        private int myAge;          //Hourly Pay Rate
        private string myPhone;     //Number of Hours Worked

        //Empty Constructor
        public Person()
        {
            myName = "";
            myAddress = "";
            myAge = 0;
            myPhone = "";
        }

        
        //Constructor that takes 3 strings and an int as arguments. This method will set the field
        //values to the argument values.
        public Person(string personName, string personAddress, int personAge, string personPhone)
        {
            myName = personName;
            myAddress = personAddress;
            myAge = personAge;
            myPhone = personPhone;
        }

        //Setters

        //The setName method sets the person's name
        public void setName(string name)
        {
            myName = name;
        }

        //The setAddress method sets the person's address
        public void setAddress(string address)
        {
            myAddress = address;
        }

        //The setAge method sets the person's age
        public void setAge(int age)
        {
            myAge = age;
        }

        //The setPhone method sets the person's phone number
        public void setPhone(string phone)
        {
            myPhone = phone;
        }

        //Getters

        //The getName method returns the person's name
        public string getName()
        {
            return myName;
        }

        //The getAddress method returns the person's address
        public string getAddress()
        {
            return myAddress;
        }

        //The getAge method returns the person's age
        public int getAge()
        {
            return myAge;
        }

        //The getPhone method returns the person's phone number
        public string getPhone()
        {
            return myPhone;
        }
    }
}
