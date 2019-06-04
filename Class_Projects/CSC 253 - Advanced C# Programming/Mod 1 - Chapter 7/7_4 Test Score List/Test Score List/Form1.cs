﻿/**
* 8/21/2017
* CSC 253
* Shawn Witter
* This program generates an average from a list of scores. The program also displays scores that are above and below this average.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The ReadScores Method reads the scores from the
        //TestScores.txt file into the scoresList Parameter
        private void ReadScores(List<int> scoresList)
        {
            try
            {
                //Open the testScores.txt file
                StreamReader inputFile = File.OpenText("TestScores.txt");

                //Read the scores into the list.
                while (!inputFile.EndOfStream)
                {
                    scoresList.Add(int.Parse(inputFile.ReadLine()));
                }

                //Close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //Display the error message
                MessageBox.Show(ex.Message);
            }
        }

        //The DisplayScores method displays the contents of the
        //scoreslist parameter in the ListBox control
        private void DisplayScores(List<int> scoresList)
        {
            foreach (int score in scoresList)
            {
                testScoresListBox.Items.Add(score);
            }
        }

        //The Average method returns the average of the values
        //in the scoresList Parameter.
        private double Average(List<int> scoresList)
        {
            int total = 0;  //Accumulator
            double average; //To hold the average

            //Calculate the total of the scores.
            foreach (int score in scoresList)
            {
                total += score;
            }

            //Calculate the average of the scores
            average = (double)total / scoresList.Count;

            //Return the average
            return average;
        }

        //The AboveAverage method returns the number of
        //above average scores in scoreList.
        private int AboveAverage(List<int> scoresList)
        {
            int numAbove = 0;

            //Get the average score
            double avg = Average(scoresList);

            //Count the number of the above average scores.
            foreach (int score in scoresList)
            {
                if (score > avg)
                {
                    numAbove++;
                }
            }

            //Return the number of above average scores.
            return numAbove;
        }


        private int BelowAverage(List<int> scoresList)
        {
            int numBelow = 0;

            //Get the average score
            double avg = Average(scoresList);

            //Count the number of the Below average scores.
            foreach (int score in scoresList)
            {
                if (score < avg)
                {
                    numBelow++;
                }
            }

            //Return the number of Below average scores.
            return numBelow;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    //To hold the average score
            int numAboveAverage;    //Number of above average scores
            int numBelowAverage;    //Number of below average scores

            //Create a List to hold the score
            List<int> scoresList = new List<int>();

            //Read the scores from the file into the List
            ReadScores(scoresList);

            //Display the scores
            DisplayScores(scoresList);

            //Display the average score.
            averageScore = Average(scoresList);
            AverageLabel.Text = averageScore.ToString("n1");

            //Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            //Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
