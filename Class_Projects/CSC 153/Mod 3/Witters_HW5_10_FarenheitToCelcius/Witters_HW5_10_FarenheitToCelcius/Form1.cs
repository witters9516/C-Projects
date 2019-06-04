//CIS-153-HW5-10
//Witters_HW5_10_CalorieCounter 
//Shawn Witter
//1/24/17
//I accidently named the file Wrong, but it is the Calorie Counter Program.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_HW5_10_FarenheitToCelcius
{
    public partial class Form1 : Form
    {
        double banana = 115;
        double apple = 80;
        double orange = 90;
        double pear = 120;

        double totalCalories;

        public Form1()
        {
            InitializeComponent();
        }

        private void bananaPicturebox_Click(object sender, EventArgs e)
        {
            //Add calories to total
            totalCalories += banana;

            //update Total label
            totalCaloriesCountedLabel.Text = totalCalories.ToString();

        }

        private void applePicturebox_Click(object sender, EventArgs e)
        {
            //Add calories to total
            totalCalories += apple;

            //update Total label
            totalCaloriesCountedLabel.Text = totalCalories.ToString();
        }

        private void orangePicturebox_Click(object sender, EventArgs e)
        {
            //Add calories to total
            totalCalories += orange;

            //update Total label
            totalCaloriesCountedLabel.Text = totalCalories.ToString();
        }

        private void pearPicturebox_Click(object sender, EventArgs e)
        {
            //Add calories to total
            totalCalories += pear;

            //update Total label
            totalCaloriesCountedLabel.Text = totalCalories.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Return total to 0
            totalCalories = 0;

            //Change total on screen
            totalCaloriesCountedLabel.Text = totalCalories.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
