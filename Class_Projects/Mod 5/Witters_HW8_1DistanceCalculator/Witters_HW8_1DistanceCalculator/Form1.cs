//CSC 153 M5HW8
//Witters_Chp5_HW8_1DistanceCalculator
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

namespace Witters_HW8_1DistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double speed;  
            double hoursTraveled; 
            double.TryParse(speedTextbox.Text, out speed);
            double.TryParse(hoursTextbox.Text, out hoursTraveled);

            for (int i = 0; i < hoursTraveled; i++)
            {
                double distance = speed * (i + 1);
                listBox1.Items.Add("In " + (i + 1) + " hours, the distance is " + distance.ToString() + ".");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
