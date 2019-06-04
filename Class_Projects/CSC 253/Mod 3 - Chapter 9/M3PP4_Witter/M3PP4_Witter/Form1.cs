/**
* 9/28/17
* CSC 253
* Shawn Witter
* This program creates three employee class objects and displays their attributes to the screen.
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

namespace M3PP4_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The CreateEmployee method creates an instance of the class taking 3 strings and 1 int as arguments.
        private Employee CreateEmployee(string eName, int eNumber, string eDepartment, string ePosition)
        {
            Employee employeeTemp = new Employee(eName, eNumber, eDepartment, ePosition);

            return employeeTemp;
        }

        private void createPersonButton_Click(object sender, EventArgs e)
        {
            //Create 3 Employees with specific data.
            Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee employee3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");

            //Display Attributes of object 1
            name1DisplayLabel.Text = employee1.getName();
            id1DisplayLabel.Text = employee1.getEmployeeNumber().ToString();
            department1DisplayLabel.Text = employee1.getDepartment();
            position1DisplayLabel.Text = employee1.getPosition();

            //Display Attributes of object 2
            name2DisplayLabel.Text = employee2.getName();
            id2DisplayLabel.Text = employee2.getEmployeeNumber().ToString();
            department2DisplayLabel.Text = employee2.getDepartment();
            position2DisplayLabel.Text = employee2.getPosition();

            //Display Attributes of object 3
            name3DisplayLabel.Text = employee3.getName();
            id3DisplayLabel.Text = employee3.getEmployeeNumber().ToString();
            department3DisplayLabel.Text = employee3.getDepartment();
            position3DisplayLabel.Text = employee3.getPosition();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form.
            this.Close();
        }
    }
}
