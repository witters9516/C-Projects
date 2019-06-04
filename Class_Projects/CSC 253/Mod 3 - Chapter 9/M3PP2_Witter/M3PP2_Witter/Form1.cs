/**
* 9/28/17
* CSC 253
* Shawn Witter
* This program prompts the user to input a Car's Year, Make, and Speed.
* The program creates an object with those attributes and displays them to the user.
* It also increases and decreases the speed five times and displays it to a listBox.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3PP2_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The CreateCar method takes a two strings and an int as arguments.
        //This function creates that object using the arguments and returns it.
        private Car CreateCar(int year, string make, int speed)
        {
            //Create new Car Object
            Car carTemp = new Car(year, make, speed);

            //Return object
            return carTemp;
        }

        private void createCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables for newCar Object.
                int year = int.Parse(yearTextBox.Text);
                string make = makeTextBox.Text;
                int speed = int.Parse(speedTextBox.Text);

                //Call Create car to create new object.
                Car newCar = CreateCar(year, make, speed);

                //Display variables of object.
                carYearLabel.Text = newCar.getYear().ToString();
                CarMakeLabel.Text = newCar.getMake();
                carSpeedLabel.Text = newCar.getSpeed().ToString();

                //Display Accelerate 5 times.
                for (int i = 0; i < 5; i++)
                {
                    newCar.Accelerate();
                    speedListBox.Items.Add("The speed increased to " + newCar.getSpeed().ToString() + ".");
                }

                //Display Brake 5 times.
                for (int i = 0; i < 5; i++)
                {
                    newCar.Brake();
                    speedListBox.Items.Add("The speed decreased to " + newCar.getSpeed().ToString() + ".");
                }

            }
            catch (Exception ex)
            {
                //Display Error Message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
