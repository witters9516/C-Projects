/**
* 9/28/17
* CSC 253
* Shawn Witter
* This program utilizes multiple forms and prompts the user to choose a housing plan and a meal plan.
* Once chosen, it displays the charges and the total of those charges on the second form.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3PP6_Witter
{
    public partial class Form1 : Form
    {
        //Variables
        decimal dormCharge;
        decimal mealPlanCharge;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateChargesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                decimal totalCharges = dormCharge + mealPlanCharge;

                //Create new form
                Form2 form2 = new Form2();

                //Display Form
                form2.Show();
                
                //Display charges to form.
                form2.DisplayCharges(dormCharge, mealPlanCharge, totalCharges);
            }
            catch (Exception ex)
            {
                //Display Error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void allenHallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set dormCharge to 1500.
            dormCharge = 1500.0m;
        }

        private void pikeHallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set dormCharge to 1600.
            dormCharge = 1600.0m;
        }

        private void farthingHallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set dormCharge to 1800.
            dormCharge = 1800.0m;
        }

        private void universitySuitesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set dormCharge to 2500.
            dormCharge = 2500.0m;
        }

        private void sevenPerWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set mealPlanCharge to 600.
            mealPlanCharge = 600.0m;
        }

        private void fourteenPerWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set mealPlanCharge to 1200.
            mealPlanCharge = 1200.0m;
        }

        private void unlimitedPerWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set mealPlanCharge to 1700.
            mealPlanCharge = 1700.0m;
        }
    }
}
