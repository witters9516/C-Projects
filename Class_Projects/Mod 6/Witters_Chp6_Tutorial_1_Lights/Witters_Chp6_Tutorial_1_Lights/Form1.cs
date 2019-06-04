//CSC 153 M6T 1
//Witters_Chp6_Tutorial_1_Lights
//Shawn Witter
//3/28/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_Chp6_Tutorial_1_Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            //Display the 'Light On' image
            lightsOnPictureBox.Visible = true;

            //Hide the 'Light Off' image
            lightsOffPictureBox.Visible = false;

            //Display the light's state
            lightStateLabel.Text = "ON";
        }
        private void TurnLightOff()
        {
            //Display the 'Light Off' image
            lightsOffPictureBox.Visible = true;

            //Hide the 'Light On' image
            lightsOnPictureBox.Visible = false;

            //Display the light's state
            lightStateLabel.Text = "OFF";

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            //Reverse the state of the light
            if (lightsOnPictureBox.Visible)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
