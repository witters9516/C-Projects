// CSC 153 HW2
// Witters_Chp2_HW2_Question2
// Shawn Witter
// 1/24/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_Chp2_HW2_Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onePictureBox_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "One";
        }

        private void twoPictureBox_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Two";
        }

        private void threePictureBox_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Three";
        }

        private void fourPictureBox_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Four";
        }

        private void fivePictureBox_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Five";
        }
    }
}
