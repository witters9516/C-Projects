//CIS-153-M3T1
//Witters_Chp3_Tutorial_1_BirthDateString
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

namespace Witters_Chp3_Tutorial_1_BirthDateString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            //Declare a String Variable
            string output;

            //Concatenate the input and build the output string
            output = dayOfWeekTextbox.Text + ", " +
                monthTextbox.Text + " " +
                dayOfMonthTextbox.Text + ", " +
                yearTextbox.Text;

            //Display the output string in the label control
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the Textboxes
            dayOfWeekTextbox.Text = "";
            monthTextbox.Text = "";
            dayOfMonthTextbox.Text = "";
            yearTextbox.Text = "";

            //Clear the dateOutputLabel control
            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the Form
            this.Close();
        }
    }
}
