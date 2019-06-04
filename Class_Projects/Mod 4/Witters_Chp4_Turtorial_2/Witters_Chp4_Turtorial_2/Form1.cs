//CSC 153 M4T2
//Witters_Chp4_Tutorial_2 PayRoll With OverTime
//Shawn Witter
//1/24/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_Chp4_Turtorial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //named constants
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                //Local Variables
                decimal hoursWorked;    //Number of hours worked
                decimal hourlyPayRate;  //Hourly pay rate
                decimal basePay;        //Pay not including overtime
                decimal overtimeHours;  //Overtime hours worked
                decimal overtimePay;    //Overtime pay
                decimal grossPay;       //total gross pay

                //Get hours worked and hourly pay rate.
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                //Determine the Gross pay
                if (hoursWorked > BASE_HOURS)
                {
                    //calculate the base pay (without overtime)
                    basePay = hourlyPayRate * BASE_HOURS;

                    //Calculate the number of overtime hours
                    overtimeHours = hoursWorked - BASE_HOURS;

                    //Calculate the overtime pay
                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;

                    //Calculate the gross pay
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    //Calculate gross pay
                    grossPay = hoursWorked * hourlyPayRate;
                }

                //Display the gross Pay
                grossPayLabel.Text = grossPay.ToString("c");

            }
            catch (Exception ex)
            {
                //Display the error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            //Reset the focus
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
