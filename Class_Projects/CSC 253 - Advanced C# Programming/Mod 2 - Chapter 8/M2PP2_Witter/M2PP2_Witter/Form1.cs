/**
* 9/17/17
* CSC 253
* Shawn Witter
* This program asks the user to input a string. The program will detemine the word count 
* and the average number of characters of all the words.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2PP2_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] GetWordCount(string input)
        {
            //Create a temp input variable to hold the string.
            input = stringTextBox.Text;

            //Get rid of any periods.
            input = input.Replace(".", "");

            //Split the string into an array to be counted.
            string[] wordArray = input.Split(' ');

            //accumulator for word counting.
            int wordCount = 0;

            //Loop to count the number of words. Each word is set to an element.
            for (int i = 0; i < wordArray.Length; i++)
                wordCount++;

            //Display the number of words to the screen.
            wordCountLabel.Text = wordCount.ToString();

            return wordArray;
        }

        private void GetAverageCharacterCount(string[] array)
        {
            //Local variables
            int charCount = 0;
            int count = 0;
            float average;

            //Calculate how many characters total and total number of words.
            for (int i = 0; i < array.Length; i++)
            {
                charCount += array[i].Length;
                count += 1;
            }

            //Calculate Average
            average = ((float)charCount / (float)count);

            //Display average to the screen.
            averageCharCountLabel.Text = average.ToString();

        }

        private void getWordCountButton_Click(object sender, EventArgs e)
        {
            //Call the GetWordCount Method.
            string[] inputArray = GetWordCount(stringTextBox.Text);

            //call GetAverageCharacterCount Method.
            GetAverageCharacterCount(inputArray);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
