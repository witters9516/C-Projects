using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3PP1_Witter
{
    

    class Pet
    {
        //Fields
        string name;
        string type;
        int age;

        //Empty Constructor
        public Pet()
        {
            name = "";
            type = "";
            age = 0;
        }

        //Contructor that takes 2 ints and a string as variables.
        //It then sets the fields to the argument values.
        public Pet(string pName, string pType, int pAge)
        {
            name = pName;
            type = pType;
            age = pAge;
        }
        //The setName method sets the object's name field to the argument.
        public void setName(string newName)
        {
            name = newName;
        }

        //The setType method sets the object's type field to the argument.
        public void setType(string newType)
        {
            type = newType;
        }

        //The setAge method sets the object's age field to the argument.
        public void setAge(int newAge)
        {
            age = newAge;
        }

        //The getName method returns the name field.
        public string getName()
        {
            return name;
        }

        //The getType method returns the type field.
        public string getType()
        {
            return type;
        }

        //The getAge method returns the age field.
        public int getAge()
        {
            return age;
        }
    }
}
