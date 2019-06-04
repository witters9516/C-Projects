//CIS-153-HW4-1
//Witters_HW4_1_NameFormatter
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

namespace Witters_HW4_1_NameFormatter
{
    public partial class Form1 : Form
    {
        //name Pieces
        String first;
        String middle;
        String last;
        String prefTitle;

        //Name arrangements
        String fullName_withTitle;
        String fullName_withoutTitle;
        String firstAndLast;
        String lastFirstAndMiddle_withTitle;
        String lastFirstAndMiddle_withoutTitle;
        String lastAndFirst;

        public Form1()
        {
            InitializeComponent();
        }

        private void FullWTitleButton_Click(object sender, EventArgs e)
        {
            //Get Information from the textboxes
            first = firstNameTextbox.Text;
            middle = middleNameTextbox.Text;
            last = lastNameTextbox.Text;
            prefTitle = preferredTitleTextbox.Text;

            //Combine the Name parts
            fullName_withTitle = prefTitle + " " +
                first + " " +
                middle + " " +
                last;

            //Print out the name
            nameLabel.Text = fullName_withTitle;
        }

        private void FullWOTitleButton_Click(object sender, EventArgs e)
        {
            //Get Information from the textboxes
            first = firstNameTextbox.Text;
            middle = middleNameTextbox.Text;
            last = lastNameTextbox.Text;
            prefTitle = preferredTitleTextbox.Text;

            //Combine the Name parts
            fullName_withoutTitle = first + " " +
                middle + " " +
                last;

            //Print out the name
            nameLabel.Text = fullName_withoutTitle;
        }

        private void firstAndLastButton_Click(object sender, EventArgs e)
        {
            //Get Information from the textboxes
            first = firstNameTextbox.Text;
            middle = middleNameTextbox.Text;
            last = lastNameTextbox.Text;
            prefTitle = preferredTitleTextbox.Text;

            //Combine the Name parts
            firstAndLast = first + " " +
                last;

            //Print out the name
            nameLabel.Text = firstAndLast;

        }

        private void lastFirstMiddlePreferredTitleButton_Click(object sender, EventArgs e)
        {
            //Get Information from the textboxes
            first = firstNameTextbox.Text;
            middle = middleNameTextbox.Text;
            last = lastNameTextbox.Text;
            prefTitle = preferredTitleTextbox.Text;
            
            //Combine the Name parts
            lastFirstAndMiddle_withTitle = last + ", " +
                first + " " +
                middle + ", " +
                prefTitle;
            
            //Print out the name
            nameLabel.Text = lastFirstAndMiddle_withTitle;

        }

        private void lastFirstMiddleButton_Click(object sender, EventArgs e)
        {
            //Get Information from the textboxes
            first = firstNameTextbox.Text;
            middle = middleNameTextbox.Text;
            last = lastNameTextbox.Text;
            prefTitle = preferredTitleTextbox.Text;

            //Combine the Name parts
            lastFirstAndMiddle_withoutTitle = last + ", " +
                first + " " +
                middle;

            //Print out the name
            nameLabel.Text = lastFirstAndMiddle_withoutTitle;

        }

        private void lastFirstButton_Click(object sender, EventArgs e)
        {
            //Get Information from the textboxes
            first = firstNameTextbox.Text;
            middle = middleNameTextbox.Text;
            last = lastNameTextbox.Text;
            prefTitle = preferredTitleTextbox.Text;

            //Combine the Name parts
            lastAndFirst = last + ", " +
                first;

            //Print out the name
            nameLabel.Text = lastAndFirst;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
