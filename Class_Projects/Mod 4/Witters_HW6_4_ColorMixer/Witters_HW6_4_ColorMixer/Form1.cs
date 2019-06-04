//CSC 153 M4HW6
//Witters_Chp4_HW6_4 ColorMixer
//Shawn Witter
//3/9/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_HW6_4_ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if (redRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (redRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (redRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (blueRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (blueRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (yellowRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("You must select 2 Radio Buttons to mix them.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
