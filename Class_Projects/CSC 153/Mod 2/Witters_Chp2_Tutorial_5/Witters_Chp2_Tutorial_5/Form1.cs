//CIS-153-0001
//Witters_Chp2_Tutorial_5
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

namespace Witters_Chp2_Tutorial_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardBackButton.Visible = true;
            cardFacePictureBox.Visible = false;
        }

        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardBackButton.Visible = false;
            cardFacePictureBox.Visible = true;
        }
    }
}
