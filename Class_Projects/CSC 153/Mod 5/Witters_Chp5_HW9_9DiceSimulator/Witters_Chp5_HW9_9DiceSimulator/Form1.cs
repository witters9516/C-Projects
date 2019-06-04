//CSC 153 M5HW9
//Witters_Chp5_HW9_9 DiceSimulator
//Shawn Witter
//3/11/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_Chp5_HW9_9DiceSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            //Pick Random Number for dice1
            int dice1 = rand1.Next(5) + 1;

            //Make whatever picture visible based on number that was chosen for dice1
            if (dice1 == 1)
            {
                //Make side 1 of dice1 visible and others false
                dice1PictureBox.Visible = true;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;

            }
            else if (dice1 == 2)
            {
                //Make side 2 of dice1 visible and others false
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = true;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;
            }
            else if (dice1 == 3)
            {
                //Make side 3 of dice1 visible and others false
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = true;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;
            }
            else if (dice1 == 4)
            {
                //Make side 4 of dice1 visible and others false
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = true;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;
            }
            else if (dice1 == 5)
            {
                //Make side 5 of dice1 visible and others false
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = true;
                dice6PictureBox.Visible = false;
            }
            else
            {
                //Make side 6 of dice1 visible and others false
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = true;
            }

            //Pick Random Number for dice2
            int dice2 = rand1.Next(5) + 1;

            //Make whatever picture visible based on number that was chosen for dice2
            if (dice2 == 1)
            {
                //Make side 1 of dice2 visible and others false
                dice7PictureBox.Visible = true;
                dice8PictureBox.Visible = false;
                dice9PictureBox.Visible = false;
                dice10PictureBox.Visible = false;
                dice11PictureBox.Visible = false;
                dice12PictureBox.Visible = false;
            }
            else if (dice2 == 2)
            {
                //Make side 2 of dice2 visible and others false
                dice7PictureBox.Visible = false;
                dice8PictureBox.Visible = true;
                dice9PictureBox.Visible = false;
                dice10PictureBox.Visible = false;
                dice11PictureBox.Visible = false;
                dice12PictureBox.Visible = false;
            }
            else if (dice2 == 3)
            {
                //Make side 3 of dice2 visible and others false
                dice7PictureBox.Visible = false;
                dice8PictureBox.Visible = false;
                dice9PictureBox.Visible = true;
                dice10PictureBox.Visible = false;
                dice11PictureBox.Visible = false;
                dice12PictureBox.Visible = false;
            }
            else if (dice2 == 4)
            {
                //Make side 4 of dice2 visible and others false
                dice7PictureBox.Visible = false;
                dice8PictureBox.Visible = false;
                dice9PictureBox.Visible = false;
                dice10PictureBox.Visible = true;
                dice11PictureBox.Visible = false;
                dice12PictureBox.Visible = false;
            }
            else if (dice2 == 5)
            {
                //Make side 5 of dice2 visible and others false
                dice7PictureBox.Visible = false;
                dice8PictureBox.Visible = false;
                dice9PictureBox.Visible = false;
                dice10PictureBox.Visible = false;
                dice11PictureBox.Visible = true;
                dice12PictureBox.Visible = false;
            }
            else
            {
                //Make side 6 of dice2 visible and others false
                dice7PictureBox.Visible = false;
                dice8PictureBox.Visible = false;
                dice9PictureBox.Visible = false;
                dice10PictureBox.Visible = false;
                dice11PictureBox.Visible = false;
                dice12PictureBox.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
