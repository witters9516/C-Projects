/**
* 8/25/2017
* CSC 253
* Shawn Witter
* This program reads the contents of a file and sends the values it contains to an array.
* The total, average, highest, and lowest of those values along with the values themselves will be displayed to the user.
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
using System.IO;

namespace M1PP2_Witter
{
    public partial class lowSalesDescLabel : Form
    {
        const int SIZE = 7;

        public lowSalesDescLabel()
        {
            InitializeComponent();
        }

        private void CalcTotalSalesButton_Click(object sender, EventArgs e)
        {
            //Variables
            decimal[] values = new decimal[SIZE];
            int count = 0;
            decimal total = 0;
            string line;
            decimal average;
            decimal highest = 0;
            decimal lowest = 0;

            //Open the inputFile
            StreamReader inputFile = File.OpenText("Sales.txt");

            //Loop to read the contents of InputFile and send the values to array.
            while (!inputFile.EndOfStream)
            {
                //Set Line to new line of txt document.
                line = inputFile.ReadLine();

                //set values array value to line at an index equal to count.
                values[count] = decimal.Parse(line);

                //Increment Count.
                count++;
            }

            //Close InputFile.
            inputFile.Close();

            //Add Values in array to ListBox.
            foreach (decimal val in values)
                totalSalesListBox.Items.Add(val.ToString("c"));

            //Calculate Total of Sale values.
            for (int i = 0; i < values.Length; i++)
                total += values[i];

            //Finds the average Sale
            average = total / values.Length;

            //Finds the Highest Sale
            for (int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                    highest = values[i];

                if (values[i] > highest)
                    highest = values[i];
            }

            //Finds the Lowest Sale
            for (int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                    lowest = values[i];

                if (values[i] < lowest)
                    lowest = values[i];
            }
            //Display the values of all Sale values.
            totalSalesLabel.Text = total.ToString("c");
            averageSalesLabel.Text = average.ToString("c");
            highestSalesLabel.Text = highest.ToString("c");
            lowestSalesLabel.Text = lowest.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
