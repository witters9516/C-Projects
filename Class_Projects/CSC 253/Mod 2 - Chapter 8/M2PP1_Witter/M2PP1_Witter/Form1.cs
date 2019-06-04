/**
* 9/11/2017
* CSC 253
* Shawn Witter
* This program takes a string and splits it into an array. 
* It then counts the number of elements to get the total word count.
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

namespace M2PP1_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetWordCount(string input)
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
        }

        private void getWordCountButton_Click(object sender, EventArgs e)
        {
            //Call the GetWordCount Method.
            GetWordCount(stringTextBox.Text);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }
    }
}
