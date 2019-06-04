/**
* 9/28/17
* CSC 253
* Shawn Witter
* This program prompts the user to input a Pet's name, Type, and Age.
* The program creates an object with those attributes and displays them to the user.
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

namespace M3PP1_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The CreatePet method takes a two strings and an int as arguments.
        //This function creates that object using the arguments and returns it.
        private Pet CreatePet(string name, string type, int age)
        {
            //Create object
            Pet petTemp = new Pet(name, type, age);

            //return object
            return petTemp;
        }

        private void createPetButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables for newPet Object.
                string name = nameTextBox.Text;
                string type = typeTextBox.Text;
                int age = int.Parse(ageTextBox.Text);

                //Create new Pet Class Object.
                Pet newPet = CreatePet(name, type, age);

                //Display Pet name, type, and age.
                petNameLabel.Text = newPet.getName();
                petTypeLabel.Text = newPet.getType();
                petAgeLabel.Text = newPet.getAge().ToString();
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
