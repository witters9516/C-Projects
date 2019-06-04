// This program asks the user to update their information by inputing it into the text boxes. 
//When the user clicks submit the program creates a new message box to tell the user what their information is. 
//If the cancel button is pressed, the program exits.
// 1/20/17
// CSC 153 0001
// Shawn Witter

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_Mod2_GradedLab
{
    public partial class updateInformation : Form
    {
        public updateInformation()
        {
            InitializeComponent();
        }

        const int JAN = 31;
        const int FEB = 28;
        const int FEB_LY = 29;
        const int MAR = 31;
        const int APL = 30;
        const int MAY = 31;
        const int JUN = 30;
        const int JUL = 31;
        const int AUG = 31;
        const int SEP = 30;
        const int OCT = 31;
        const int NOV = 30;
        const int DEC = 31;

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            
            //Variables
            String name;
            String email;
            int dOBDay;
            int dOBMonth;
            int dOBYear;
            int dayChecker = 0;
            bool leapYearCheck = false;


            /*
             * Check year first
             *      if the year is a leap year, make sure to accomadate Feb 29
             * check month
             *      if 2 then the leap year thing is addressed.
             * check day
             *      if month equals 2 and year = leap year
             * 
             * 
             */

            name = nameTextbox.Text;
            email = emailTextbox.Text;

            if (int.TryParse(DOBYearTextbox.Text, out dOBYear))
            {
                
                if (int.TryParse(DOBMonthTextbox.Text, out dOBMonth))
                {
                    CheckDays(dOBMonth, dayChecker);

                    if (int.TryParse(DOBDayTextbox.Text, out dOBDay))
                    {
                        if (dOBDay < 1 || dOBDay > dayChecker)
                        {
                            MessageBox.Show("Error: D.O.B. Days must be entered between the range of 1 and " + dayChecker.ToString());
                        }
                        else
                        {
                            //ShowFinalMessage(name, email, dOBYear, dOBMonth, dOBDay);
                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }

            
            

        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CheckDays(int dOBirthMonth, int dayChecker)
        {

            if (dOBirthMonth == 1)
                dayChecker = JAN;
            else if (dOBirthMonth == 2)
                dayChecker = FEB;
            else if (dOBirthMonth == 3)
                dayChecker = MAR;
            else if (dOBirthMonth == 4)
                dayChecker = APL;
            else if (dOBirthMonth == 5)
                dayChecker = MAY;
            else if (dOBirthMonth == 6)
                dayChecker = JUN;
            else if (dOBirthMonth == 7)
                dayChecker = JUL;
            else if (dOBirthMonth == 8)
                dayChecker = AUG;
            else if (dOBirthMonth == 9)
                dayChecker = SEP;
            else if (dOBirthMonth == 10)
                dayChecker = OCT;
            else if (dOBirthMonth == 11)
                dayChecker = NOV;
            else
                dayChecker = DEC;
        }

        public void ShowFinalMessage(String name, String email, int dOBYear, int dOBMonth, int dOBDay)
        {
            MessageBox.Show("Thank you. Your information has been updated.\n" +
            "\t\t" +
            name +
            "\n\t\t" +
            dOBDay.ToString() + "/" +
            dOBMonth.ToString() + "/" +
            dOBYear.ToString() +
            "\n\t\t" +
            email);
        }
    }
}
