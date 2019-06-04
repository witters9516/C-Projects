//CSC 153 M6T 2
//Witters_Chp6_Tutorial_2_Cards
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

namespace Witters_Chp6_Tutorial_2_Cards
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }

        //The ShowCard method accepts a string that names
        //the selected card, and displays that card.
        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        private void ShowTenHearts()
        {
            tenHeartsPictureBox.Visible = true;
            aceSpadesPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        private void ShowKingClubs()
        {
            kingClubsPictureBox.Visible = true;
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
        }
        private void showCardButton_Click(object sender, EventArgs e)
        {
            //If a card is selected in the ListBox, display it.
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from " +
                    "the list box.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
