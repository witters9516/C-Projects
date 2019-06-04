//CSC 153 M6Hw10
//Witters_Chp6_Homework10_RockPaperScissors
//Shawn Witter
//4/25/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_HW10_10_RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playerScore = 0;
        int cpuScore = 0;

        //WhoWins Method takes the two choices made by both players and picks a winner.
        private void WhoWins(ref String pChoice, ref String eChoice)
        {
            String whoWon;  //Winner Variable

            //Determine the winner by comparing the choices.
            if (pChoice == "Rock" && eChoice == "Scissors")
                whoWon = "Player";
            else if (pChoice == "Rock" && eChoice == "Paper")
                whoWon = "CPU";
            else if (pChoice == "Paper" && eChoice == "Rock")
                whoWon = "Player";
            else if (pChoice == "Paper" && eChoice == "Scissors")
                whoWon = "CPU";
            else if (pChoice == "Scissors" && eChoice == "Paper")
                whoWon = "Player";
            else if (pChoice == "Scissors" && eChoice == "Rock")
                whoWon = "CPU";
            else
                whoWon = "Tie";

            //Call Update score method taking the whoWon variable as an argument
            UpdateScore(ref whoWon);
        }

        //UpdateScore method updates the player and CPU scores;
        private void UpdateScore(ref String whoWon)
        {
            if (whoWon == "Player") //If Player wins
            {
                //increase player score and update the form
                playerScore += 1;
                playerScoreLabel.Text = playerScore.ToString();
                computerScoreLabel.Text = cpuScore.ToString();

                //If the player has won 2 out of 3, Let them know they can play again.
                if (playerScore == 3 && cpuScore < 3)
                {
                    MessageBox.Show("You have beaten the CPU in a best two out of three match.\n" +
                        "If you want to play again, Press the play again button.");
                }

            }
            else if (whoWon == "CPU")   //If CPU wins
            {
                //increase player score and update the form
                cpuScore += 1;
                playerScoreLabel.Text = playerScore.ToString();
                computerScoreLabel.Text = cpuScore.ToString();

                //If the CPU has won 2 out of 3, Let them know they can play again.
                if (cpuScore == 3 && playerScore < 3)
                {
                    MessageBox.Show("The CPU have beaten you in a best two out of three match.\n" +
                        "If you want to play again, Press the play again button.");
                }
            }
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            //Variables
            String playerChoice, enemyChoice;
            Random Rand = new Random();
            int ecRand = Rand.Next(3) + 1;

            //If either of the two players has a score of three, the player must click try again.
            if (playerScore == 3 || cpuScore == 3)
            {
                MessageBox.Show("You must click the play again button to restart the game.");
            }
            else
            {
                //Player Chooses Rock
                playerChoice = "Rock";

                //Compare the random number to choices and set it to that choice.
                if (ecRand == 1)
                    enemyChoice = "Rock";
                else if (ecRand == 2)
                    enemyChoice = "Paper";
                else
                    enemyChoice = "Scissors";

                //Set labels to the choices of both the players.
                playerChoiceLabel.Text = playerChoice;
                enemyChoiceLabel.Text = enemyChoice;

                //Call whoWins taking playerChoice and enemyChoice as arguments.
                WhoWins(ref playerChoice, ref enemyChoice);
            }
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            //Variables
            String playerChoice, enemyChoice;
            Random Rand = new Random();
            int ecRand = Rand.Next(3) + 1;

            //If either of the two players has a score of three, the player must click try again.
            if (playerScore == 3 || cpuScore == 3)
            {
                MessageBox.Show("You must click the play again button to restart the game.");
            }
            else
            {
                //Player Chooses Paper
                playerChoice = "Paper";

                //Compare the random number to choices and set it to that choice.
                if (ecRand == 1)
                    enemyChoice = "Rock";
                else if (ecRand == 2)
                    enemyChoice = "Paper";
                else
                    enemyChoice = "Scissors";

                //Set labels to the choices of both the players.
                playerChoiceLabel.Text = playerChoice;
                enemyChoiceLabel.Text = enemyChoice;

                //Call whoWins taking playerChoice and enemyChoice as arguments.
                WhoWins(ref playerChoice, ref enemyChoice);
            }
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            //Variables
            String playerChoice, enemyChoice;
            Random Rand = new Random();
            int ecRand = Rand.Next(3) + 1;

            //If either of the two players has a score of three, the player must click try again.
            if (playerScore == 3 || cpuScore == 3)
            {
                MessageBox.Show("You must click the play again button to restart the game.");
            }
            else
            {
                //Player Chooses Scissors
                playerChoice = "Scissors";

                //Compare the random number to choices and set it to that choice.
                if (ecRand == 1)
                    enemyChoice = "Rock";
                else if (ecRand == 2)
                    enemyChoice = "Paper";
                else
                    enemyChoice = "Scissors";

                //Set labels to the choices of both the players.
                playerChoiceLabel.Text = playerChoice;
                enemyChoiceLabel.Text = enemyChoice;

                //Call whoWins taking playerChoice and enemyChoice as arguments.
                WhoWins(ref playerChoice, ref enemyChoice);
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //If either the player or the enemy has a score of 3.
            if (playerScore == 3 || cpuScore == 3)
            {
                //Clear/reset all labels and scores.
                playerScore = 0;
                cpuScore = 0;
                playerChoiceLabel.Text = "";
                enemyChoiceLabel.Text = "";
                playerScoreLabel.Text = "0";
                computerScoreLabel.Text = "0";
            }
            else
            {
                //Tell player that they must finish their current game before starting a new one.
                //Choice labels will be cleared.
                playerChoiceLabel.Text = "";
                enemyChoiceLabel.Text = "";
                MessageBox.Show("You must finish current match to play again.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
