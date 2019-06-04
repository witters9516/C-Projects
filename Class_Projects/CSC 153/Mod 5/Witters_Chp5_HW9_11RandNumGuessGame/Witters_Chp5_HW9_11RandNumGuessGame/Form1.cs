//CSC 153 M5HW9
//Witters_Chp5_HW9_11 RandomNumberGuessingGame
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

namespace Witters_Chp5_HW9_11RandNumGuessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Create Random number rand
        Random rand = new Random();
        //Variables that do not need to change at button click
        int answer = 0;
        int numberChosen = 0;
        int numberOfGuesses = 0;

        private void guessButton_Click(object sender, EventArgs e)
        {
            //Variables that can change on button click
            //User's guess
            int guess;

            //Choose random number if not chosen already.
            while (numberChosen == 0)
            { 
                //Choose random number
                answer = rand.Next(99) + 1;
                //Escape variable
                numberChosen = 1;
            }

            //increase number of guesses by 1 at each click
            numberOfGuesses++;

            //Try to parse guess to ensure it is an int; sends it to guess
            int.TryParse(guessTextbox.Text, out guess);

            //Determine if the user is higher, lower, or equal to the number the game chose.
            //Else will be for invalid answers that are outside the range.
            if (guess == answer)
            {
                //Update number of guesses label
                displayGuessesLabel.Text = numberOfGuesses.ToString();
                answerLabel.Text = "Correct! A new number has been selected!";
                MessageBox.Show("A new number has been selected. Try to figure out what it is.");
                //Reset loop variable so the program can choose a new number
                numberChosen = 0;
                //Reset number of guesses to 0
                numberOfGuesses = 0;
                //Update number of guesses label back to 0
                displayGuessesLabel.Text = "0";
            }
            else if (guess < answer)
            {
                //Update number of guesses label
                displayGuessesLabel.Text = numberOfGuesses.ToString();
                //Display hint
                answerLabel.Text = "Too low! try again.";
            }
            else if (guess > answer)
            {
                //Update number of guesses label
                displayGuessesLabel.Text = numberOfGuesses.ToString();
                //Display hint
                answerLabel.Text = "Too high! try again.";
            }
            else if(guess <= 0 || guess >=101)
            {
                //Display Error
                answerLabel.Text = "Invalid Choice! You must enter a number between 1 and 100!";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
