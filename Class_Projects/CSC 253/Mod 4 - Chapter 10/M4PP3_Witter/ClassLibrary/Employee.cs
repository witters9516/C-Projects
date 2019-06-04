using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        private string name;            //Employee Name
        private string employeeNumber;  //Employee Number

        /**
         * This constructor initializes an object with a name,
         * employee number
         * @param n The employee's name.
         * @param num The employee's number.
        */

        public Employee(string n, string num)
        {
            name = n;
            SetEmployeeNumber(num);
        }

        /**
         * The no-arg constructor initializes an object with 
         * null strings for name, employee number, and hire 
         * date.
         */

        public Employee()
        {
            name = "";
            employeeNumber = "";
        }

        /**
         * The setName method sets the employee's name.
         * @param n The employee's name.
         */

        public void SetName(string n)
        {
            name = n;
        }

        /**
         * The setEmployeeNumber method sets the employee's number.
         * @param e The employee's number.
         */

        public void SetEmployeeNumber(string e)
        {
            employeeNumber = e;
        }

        /**
         * The getName method returns the employee's name.
         * @return The employee's name.
         */

        public string GetName()
        {
            return name;
        }

        /**
         * The getEmployeeNumber method returns the employee's number.
         * @return The Employee's number.
         */

        public string GetEmployeeNumber()
        {
            return employeeNumber;
        }
    }
}
