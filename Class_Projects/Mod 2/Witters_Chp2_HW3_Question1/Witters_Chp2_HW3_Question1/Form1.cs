// CSC 153 HW3
// Witters_Chp2_HW3_Question1
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

namespace Witters_Chp2_HW3_Question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            translatedWordLabel.Text = "Left";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            translatedWordLabel.Text = "Right";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            translatedWordLabel.Text = "Center";
        }
    }
}
