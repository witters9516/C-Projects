/**
* 11/15/2017
* CSC 253
* Shawn Witter
* This program shows multiform displays of the content of a database.
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

namespace M5T5_Witter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the DetailsForm.
            DetailsForm details = new DetailsForm();

            //Display this form.
            details.ShowDialog();

            //Update the dataset
            this.productTableAdapter.Fill(this.productDataSet.Product);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
