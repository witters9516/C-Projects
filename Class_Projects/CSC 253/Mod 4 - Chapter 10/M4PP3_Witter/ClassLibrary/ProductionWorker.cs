using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductionWorker : Employee
    {
        //Constants for the day and night shifts
        public int DAY_SHIFT = 1;
        public int NIGHT_SHIFT = 2;

        private int shift;          //The employee's shift
        private decimal payRate;     //The employee's pay rate

        /**
         * This constructor initializes an object with a name.
         * employee number, hireDate, shift, and pay rate.
         * @param n The Employee's name.
         * @param num The Employee's number.
         * @param sh The Employee's shift.
         * @param rate The Employee's pay rate.
         */

        public ProductionWorker(string n, string num,
                int sh, decimal rate)
        {
            this.SetName(n);
            this.SetEmployeeNumber(num);
            shift = sh;
            payRate = rate;
        }

        /**
         * This no-arg constructor initializes an object with null strings 
         * for name, employee number, hireDate, shift, and pay rate. The day 
         * shift is selected, and the pay rate is set to 0.0.
         */

        public ProductionWorker()
        {
            shift = DAY_SHIFT;
            payRate = 0.0m;
        }

        /**
         * The setShift method sets the employee's shift.
         * @param s The employee's shift.
         */

        public void SetShift(int s)
        {
            shift = s;
        }

        /**
         * The setPayRate method sets th employee's pay rate.
         * @param p the employee's pay rate.
         */

        public void SetPayRate(decimal p)
        {
            payRate = p;
        }

        /**
         * The getShift method return the employee's shift.
         * @return The employee's shift
         */

        public int GetShift()
        {
            return shift;
        }

        /**
         * The getPayRate method returns the employee's pay rate.
         * @return The employee's pay rate.
         */

        public decimal GetPayRate()
        {
            return payRate;
        }
    }
}
