//CIS-153-M3GL
//M3Lab_Witter
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

namespace M3Lab_Witter
{
    public partial class Form1 : Form
    {
        double classA_TicketsSold;
        double classB_TicketsSold;
        double classC_TicketsSold;

        double classA_TicketCost = 15.0;
        double classB_TicketCost = 12.0;
        double classC_TicketCost = 9.0;

        double totalRevenue;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateRevenueButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get information from textboxes
                
                classA_TicketsSold = double.Parse(classATextbox.Text);
                classB_TicketsSold = double.Parse(classBTextbox.Text);
                classC_TicketsSold = double.Parse(classCTextbox.Text);

                if (classA_TicketsSold < 0 || classB_TicketsSold < 0 || classC_TicketsSold < 0)
                {
                    MessageBox.Show("The number of tickets in Class Textboxes must be 0 or more!");
                }
                else
                {
                    //Calculate Revenue
                    double classA_Revenue = classA_TicketsSold * classA_TicketCost;
                    double classB_Revenue = classB_TicketsSold * classB_TicketCost;
                    double classC_Revenue = classC_TicketsSold * classC_TicketCost;

                    //Calculate Total Revenue
                    totalRevenue = classA_Revenue + classB_Revenue + classC_Revenue;

                    //Display information to empty label
                    classAEmptyLabel.Text = classA_Revenue.ToString("c");
                    classBEmptyLabel.Text = classB_Revenue.ToString("c");
                    classCEmptyLabel.Text = classC_Revenue.ToString("c");
                    totalEmptyLabel.Text = totalRevenue.ToString("c");
                }
            }
            catch(Exception ex)
            {
                //Display error message.
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            classATextbox.Text = "";
            classBTextbox.Text = "";
            classCTextbox.Text = "";
            classAEmptyLabel.Text = "";
            classBEmptyLabel.Text = "";
            classCEmptyLabel.Text = "";
            totalEmptyLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
