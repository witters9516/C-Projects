//CSC 153 M4HW6
//Witters_Chp4_HW6_1 RomanNumeralConverter
//Shawn Witter
//3/9/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_HW6_1_RomanNumeralConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findRomNumButton_Click(object sender, EventArgs e)
        {
            int numberselected;

            numberselected = int.Parse(numberSelectedTextBox.Text);

            if (numberselected == 1)
            {
                romanNumLabel.Text = "I";
            }
            else if (numberselected == 2)
            {
                romanNumLabel.Text = "II";
            }
            else if (numberselected == 3)
            {
                romanNumLabel.Text = "III";
            }
            else if (numberselected == 4)
            {
                romanNumLabel.Text = "IV";
            }
            else if (numberselected == 5)
            {
                romanNumLabel.Text = "V";
            }
            else if (numberselected == 6)
            {
                romanNumLabel.Text = "VI";
            }
            else if (numberselected == 7)
            {
                romanNumLabel.Text = "VII";
            }
            else if (numberselected == 8)
            {
                romanNumLabel.Text = "VIII";
            }
            else if (numberselected == 9)
            {
                romanNumLabel.Text = "IX";
            }
            else if (numberselected == 10)
            {
                romanNumLabel.Text = "X";
            }
            else
            {
                MessageBox.Show("The value must be a number between 1 and 10.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
