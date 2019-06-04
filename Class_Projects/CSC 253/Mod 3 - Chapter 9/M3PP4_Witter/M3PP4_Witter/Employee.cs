using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3PP4_Witter
{
    class Employee
    {
        //Fields
        string eName;
        int eNumber;
        string eDepartment;
        string ePosition;

        //Constructor that takes 1 string, 2 ints, and 1 float value as arguments.
        //The constructor sets the field values to the value of the arguments.
        public Employee(string name, int employee_Number, string department, string position)
        {
            eName = name;
            eNumber = employee_Number;
            eDepartment = department;
            ePosition = position;
        }
        
        //The setName method takes a string as an argument.
        //It sets eName to the value of the argument.
        public void setName(string name)
        {
            eName = name;
        }

        //The setEmployeeNumber method takes a int as an argument.
        //It sets eNumber to the value of the argument.
        public void setEmployeeNumber(int employee_Number)
        {
            eNumber = employee_Number;
        }

        //The setShiftNumber method takes a int as an argument.
        //It sets eShiftNumber to the value of the argument.
        public void setDepartment(string department)
        {
            eDepartment = department;
        }


        //The setHourlyPayRate method takes a float as an argument.
        //It sets eHPR to the value of the argument.
        public void setPosition(string position)
        {
            ePosition = position;
        }

        //The getName method returns eName.
        public string getName()
        {
            return eName;
        }

        //The getEmployeeNumber method returns eNumber.
        public int getEmployeeNumber()
        { 
            return eNumber;
        }

        //The getShiftNumber method returns eShiftNumber.
        public string getDepartment()
        {
            return eDepartment;
        }

        //The getHourlyPayRate method returns eHPR.
        public string getPosition()
        {
            return ePosition;
        }
    }
}
