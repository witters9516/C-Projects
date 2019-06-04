/**
* 11/21/17
* CSC 253
* Shawn Witter
* This program demonstrates creating a database and then displaying 
* its info multipule forms (details and DataGridView).
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

namespace M5PP2_Witter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void detailsViewButton_Click(object sender, EventArgs e)
        {
            //Create an instance of a DetailsViewForm
            DetailsViewForm DVF = new DetailsViewForm();
            this.Hide();
            DVF.ShowDialog();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
