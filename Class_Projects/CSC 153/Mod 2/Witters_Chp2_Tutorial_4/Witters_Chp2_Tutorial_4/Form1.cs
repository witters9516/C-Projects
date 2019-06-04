//CIS-153-0001
//Witters_Chp2_Tutorial_4
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

namespace Witters_Chp2_Tutorial_4
{
    public partial class FlagsForm : Form
    {
        public FlagsForm()
        {
            InitializeComponent();
        }

        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland";
        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France";
        }

        private void germanyPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany";
        }
    }
}
