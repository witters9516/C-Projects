//CIS-153-0001
//Witters_Chp2_Tutorial_1_And_2
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

namespace Witters_Chp2_Tutorial_1_and_2
{
    public partial class MyFirstProgram : Form
    {
        public MyFirstProgram()
        {
            InitializeComponent();
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
