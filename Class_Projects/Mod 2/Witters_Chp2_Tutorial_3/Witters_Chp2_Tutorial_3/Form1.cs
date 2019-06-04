//CIS-153-0001
//Witters_Chp2_Tutorial_3
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

namespace Witters_Chp2_Tutorial_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Italian_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buogiorno";
        }

        private void Spanish_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void German_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgan";
        }
    }
}
