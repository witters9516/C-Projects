//CIS-153-HW5-5
//Witters_HW5_5_CelciusAndFarenheitConverter
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

namespace Witters_HW5_5_CelciusAndFarenheitConverter
{
    public partial class Form1 : Form
    {
        //Variables
        double farenheit;
        double celcius;
        double celciusToFarenheit;
        double farenheitToCelcius;


        public Form1()
        {
            InitializeComponent();
        }

        private void convertCelciusToFarenheitButton_Click(object sender, EventArgs e)
        {
            //Get Temperature
            celcius = double.Parse(tempTextbox.Text);

            //Convert Celcius to Farenheit
            celciusToFarenheit = ((9 / 5) * celcius) + 32;

            //Print out converted temperature
            convertedTempLabel.Text = celciusToFarenheit.ToString();
        }

        private void convertFarenheitToCelciusLabel_Click(object sender, EventArgs e)
        {
            //Get Temperature
            farenheit = double.Parse(tempTextbox.Text);

            //Convert Farenheit to Celcius
            farenheitToCelcius = (9 / 5) * (farenheit - 32);

            //Print out converted temperature
            convertedTempLabel.Text = farenheitToCelcius.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
