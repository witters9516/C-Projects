//CSC 153 M4 GL P2
//Witters_Chp4_GradedLab_Part2 Input Validation
//Shawn Witter
//3/23/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_Mod2GL_InputValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Globals
        const int JAN = 31;
        const int FEB = 28;
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Variables
            String name;
            String email;
            int dOBDay;
            int dOBMonth;
            int dOBYear;
            int dayChecker = 0;

            name = nameTextbox.Text;
            email = emailTextbox.Text;
            
            //Try to Parse Year
            if (int.TryParse(DOBYearTextbox.Text, out dOBYear))
            {
                //Check year Range(1930-2016)
                if (dOBYear < 1930 || dOBYear > 2016)
                {
                    //Error Message
                    MessageBox.Show("Error: D.O.B. Year must be entered between the range of 1930 and 2016!");
                }
                else
                {
                    //Try to Parse Month
                    if (int.TryParse(DOBMonthTextbox.Text, out dOBMonth))
                    {
                        //Check month Range(1-12)
                        if (dOBMonth < 1 || dOBMonth > 12)
                        {
                            //Error Message
                            MessageBox.Show("Error: D.O.B. Months must be entered between the range of 1 and 12!");
                        }
                        else
                        {
                            //Set dayChecker to the number of days in the entered month.
                            dayChecker = CheckDays(dOBMonth, dayChecker);
                            
                            //Try to Parse Day
                            if (int.TryParse(DOBDayTextbox.Text, out dOBDay))
                            {
                                //Check day Range(1-dayChecker)
                                if (dOBDay < 1 || dOBDay > dayChecker)
                                {
                                    //Error Message
                                    MessageBox.Show("Error: D.O.B. Days must be entered between the range of 1 and " + dayChecker.ToString());
                                }
                                else
                                {
                                    //Show Final Message.
                                    ShowFinalMessage(name, email, dOBYear, dOBMonth, dOBDay);
                                }
                            }
                            else
                            {
                                //Error Message
                                MessageBox.Show("Error: D.O.B. Day must be an integer!");
                            }
                        }
                    }
                    else
                    {
                        //Error Message
                        MessageBox.Show("Error: D.O.B. Month must be an integer!");
                    }
                }
            }
            else
            {
                //Error Message
                MessageBox.Show("Error: D.O.B. Year must be an integer!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        public int CheckDays(int dOBirthMonth, int dayChecker)
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

            return dayChecker;
        }

        public void ShowFinalMessage(String name, String email, int dOBYear, int dOBMonth, int dOBDay)
        {
            MessageBox.Show("Thank you. Your information has been updated.\n" +
            "\tName:\t" + 
            name +
            "\n\tDOB:\t" +
            dOBDay.ToString() + "/" +
            dOBMonth.ToString() + "/" +
            dOBYear.ToString() +
            "\n\tE-mail:\t" +
            email);
        }

    }
}
