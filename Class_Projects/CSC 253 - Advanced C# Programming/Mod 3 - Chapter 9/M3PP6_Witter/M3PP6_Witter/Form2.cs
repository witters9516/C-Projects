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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //The DisplayCharges method takes 3 doubles as arguments. The method
        //then displays the values in the labels on the form.
        public void DisplayCharges(decimal dorm, decimal meal, decimal total)
        {
            //Variables
            decimal dormCharge = dorm;
            decimal mealCharge = meal;
            decimal totalCharges = total;

            //Display the information to the second form
            dormChargesLabel.Text = dormCharge.ToString("c");
            mealChargeLabel.Text = mealCharge.ToString("c");
            totalChargesLabel.Text = totalCharges.ToString("c");
        }

    }
}
