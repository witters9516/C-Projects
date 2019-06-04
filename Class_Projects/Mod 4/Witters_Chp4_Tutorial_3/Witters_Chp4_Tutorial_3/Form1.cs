//CSC 153 M4T3
//Witters_Chp4_Tutorial_2 LoanQualifier
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

namespace Witters_Chp4_Tutorial_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Name constants
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                //Local Variables
                decimal salary;
                int yearsOnJob;

                //Get salary and years on the job
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                //Determine whether the user qualifies
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        //The user qualifies
                        decisionLabel.Text = "You Qualify for the loan.";

                    }
                    else
                    {
                        //the does not qualify
                        decisionLabel.Text = "Minimum years at current " + "job not met.";
                    }

                }
                else
                {
                    //the does not qualify
                    decisionLabel.Text = "Minimum salary requirement " + "not met.";
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the textboxes and the decision label
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            //Reset the Focus
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
