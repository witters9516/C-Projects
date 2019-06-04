/**
* 9/28/17
* CSC 253
* Shawn Witter
* This program creates three people class objects(through input) and displays their attributes to the screen.
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

namespace M3PP3_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The CreatePerson method creates an instance of the class taking 3 strings and 1 int as arguments.
        private Person CreatePerson(string name, string address, int age, string phoneNumber)
        {
            //Creates the object using the parameters.
            Person personTemp = new Person(name, address, age, phoneNumber);

            //Returns the values to the screen.
            return personTemp;
        }

        private void createPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                string name1 = name1TextBox.Text;               //Name for Person 1
                string address1 = address1TextBox.Text;         //Address for Person 1
                int age1 = int.Parse(age1TextBox.Text);         //Age for Person 1
                string phoneNumber1 = phoneNumber1TextBox.Text; //Phone Number for Person 1

                string name2 = name2TextBox.Text;               //Name for Person 2
                string address2 = address2TextBox.Text;         //Address for Person 2
                int age2 = int.Parse(age2TextBox.Text);         //Age for Person 2
                string phoneNumber2 = phoneNumber2TextBox.Text; //Phone Number for Person 2

                string name3 = name3TextBox.Text;               //Name for Person 3
                string address3 = address3TextBox.Text;         //Address for Person 3
                int age3 = int.Parse(age3TextBox.Text);         //Age for Person 3
                string phoneNumber3 = phoneNumber3TextBox.Text; //Phone Number for Person 3

                //Create objects
                Person person1 = CreatePerson(name1, address1, age1, phoneNumber1);
                Person person2 = CreatePerson(name2, address2, age2, phoneNumber2);
                Person person3 = CreatePerson(name3, address3, age3, phoneNumber3);

                //Display Attributes of object 1
                name1DisplayLabel.Text = person1.getName();
                address1DisplayLabel.Text = person1.getAddress();
                age1DisplayLabel.Text = person1.getAge().ToString();
                phoneNumber1DisplayLabel.Text = person1.getPhone();
                
                //Display Attributes of object 2
                name2DisplayLabel.Text = person2.getName();
                address2DisplayLabel.Text = person2.getAddress();
                age2DisplayLabel.Text = person2.getAge().ToString();
                phoneNumber2DisplayLabel.Text = person2.getPhone();
                
                //Display Attributes of object 3
                name3DisplayLabel.Text = person3.getName();
                address3DisplayLabel.Text = person3.getAddress();
                age3DisplayLabel.Text = person3.getAge().ToString();
                phoneNumber3DisplayLabel.Text = person3.getPhone();
            }
            catch (Exception ex)
            {
                //Display the error message.
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
