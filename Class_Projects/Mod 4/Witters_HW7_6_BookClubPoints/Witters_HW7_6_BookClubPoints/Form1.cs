//CSC 153 M4HW7
//Witters_Chp4_HW7_6 BookClubPoints
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


namespace Witters_HW7_6_BookClubPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcPointsButton_Click(object sender, EventArgs e)
        {
            //Variables
            int books_Purchased;
            int points_Earned;

            //Try to parse the number as an int. if so, send it to books_Purchased.
            int.TryParse(booksPurchTextBox.Text, out books_Purchased);

            //Allocate points based on number of books purchased.
            if (books_Purchased == 0)
            {
                points_Earned = 0;
                pointesEarnedLabel.Text = points_Earned.ToString();
            }
            else if (books_Purchased == 1)
            {
                points_Earned = 5;
                pointesEarnedLabel.Text = points_Earned.ToString();
            }
            else if (books_Purchased == 2)
            {
                points_Earned = 15;
                pointesEarnedLabel.Text = points_Earned.ToString();
            }
            else if (books_Purchased == 3)
            {
                points_Earned = 30;
                pointesEarnedLabel.Text = points_Earned.ToString();
            }
            else
            {
                points_Earned = 60;
                pointesEarnedLabel.Text = points_Earned.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
