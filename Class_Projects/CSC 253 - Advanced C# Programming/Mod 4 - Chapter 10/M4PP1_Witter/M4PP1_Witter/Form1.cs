using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace M4PP1_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createPWButton_Click(object sender, EventArgs e)
        {
            //Variables
            string name = pwNameTextBox.Text;
            string employeeNumber = pwEmployeeNumberTextBox.Text;
            int shiftNumber = int.Parse(pwShiftNumTextBox.Text);
            decimal hpr = decimal.Parse(pwHPRTextBox.Text);

            //Create a new ProductionWorker Class
            ProductionWorker prodWork = new ProductionWorker(name, employeeNumber, shiftNumber, hpr);

            //Display the data
            pwNameLabel.Text = prodWork.GetName();
            pwEmployeeNumberLabel.Text = prodWork.GetEmployeeNumber();
            pwShiftNumLabel.Text = prodWork.GetShift().ToString();
            pwHPRLabel.Text = prodWork.GetPayRate().ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
