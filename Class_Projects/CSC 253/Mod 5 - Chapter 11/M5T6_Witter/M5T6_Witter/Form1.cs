﻿/**
* 11/15/2017
* CSC 253
* Shawn Witter
* This program shows how to implement queries that will filter the data of a database.
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

namespace M5T6_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByPrice(this.productDataSet.Product);
        }

        private void unitsGreater100Button_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnits(this.productDataSet.Product);
        }
    }
}
