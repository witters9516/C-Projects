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

namespace M4PP3_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createTLButton_Click(object sender, EventArgs e)
        {
            //Variables
            string name = pwNameTextBox.Text;
            string employeeNumber = pwEmployeeNumberTextBox.Text;
            int shiftNumber = int.Parse(pwShiftNumTextBox.Text);
            decimal hpr = decimal.Parse(pwHPRTextBox.Text);
            float monthlyBonus = float.Parse(tLMonthlyBonusTextBox.Text);
            int requiredTraingingHours = int.Parse(tLReqTrainHoursTextBox.Text);
            int completedTrainingHours = int.Parse(tLComTrainHoursTextBox.Text);


            //Create a new ProductionWorker Class
            TeamLeader teamLeader = new TeamLeader(name, employeeNumber, shiftNumber, hpr, monthlyBonus, requiredTraingingHours, completedTrainingHours);

            //Display the data
            tLNameLabel.Text = teamLeader.GetName();
            tLEmployeeNumberLabel.Text = teamLeader.GetEmployeeNumber();
            tLShiftNumLabel.Text = teamLeader.GetShift().ToString();
            tLHPRLabel.Text = teamLeader.GetPayRate().ToString();
            monthlyBonusLabel.Text = teamLeader.GetMonthlyBonus().ToString("c");
            reqTrainHoursLabel.Text = teamLeader.GetRequiredTrainingHours().ToString();
            comTrainHoursLabel.Text = teamLeader.GetCompletedTrainingHours().ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
