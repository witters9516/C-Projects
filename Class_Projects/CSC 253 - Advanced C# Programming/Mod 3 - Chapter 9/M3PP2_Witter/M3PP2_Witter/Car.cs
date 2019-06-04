using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3PP2_Witter
{
    class Car
    {
        //fields
        int year;
        string make;
        int speed;

        //Empty Constructor
        public Car()
        {
            year = 0;
            make = "";
            speed = 0;
        }

        //Contructor that takes 2 ints and a string as variables.
        //It then sets the fields to the argument values. 
        public Car(int cYear, string cMake, int cSpeed)
        {
            year = cYear;
            make = cMake;
            speed = cSpeed;
        }

        //The setYear method sets the object's year field to the argument.
        public void setYear(int cYear)
        {
            year = cYear;
        }

        //The setMake method sets the object's Make field to the argument.
        public void setMake(string cMake)
        {
            make = cMake;
        }

        //The setSpeed method sets the object's Speed field to the argument.
        public void setSpeed(int cSpeed)
        {
            speed = cSpeed;
        }

        //The getYear method returns the year field.
        public int getYear()
        {
            return year;
        }

        //The getMake method returns the make field.
        public string getMake()
        {
            return make;
        }

        //The getSpeed method returns the speed field.
        public int getSpeed()
        {
            return speed;
        }

        //The Accelerate method increases the speed field by 5.
        public void Accelerate()
        {
            speed += 5;
        }

        //The Brake method decreases the speed field by 5.
        public void Brake()
        {
            speed -= 5;
        }
    }
}
