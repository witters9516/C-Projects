/**
* 11/21/17
* CSC 253/
* Shawn Witter
* This program implements queries that sort the data in a database by ascending/descending HPR.
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

namespace M5PP3_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void sortAscendingHPRButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SortByAscendingHPR(this.personnelDataSet.Employee);
        }

        private void sortDescendingHPRButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SortByDescendingHPR(this.personnelDataSet.Employee);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
