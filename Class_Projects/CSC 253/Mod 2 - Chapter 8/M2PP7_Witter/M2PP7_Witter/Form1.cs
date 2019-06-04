/**
* 9/21/2017
* CSC 253
* Shawn Witter
* This program translates english to Pig Latin.
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

namespace M2PP7_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The TranslateToPigLatin method accepts a string as an argument.
        //This method takes the input of the user and creates a sentence 
        //that has been translated to pig latin and returns it.
        private string TranslateToPigLatin(string str)
        {
            //Variables
            char[] delim = { '.', ' ', '!', '?'};
            char tempPunc = str[str.Length - 1];
            string output = "";
            string[] tokens = str.Split(delim);

            //Loop to create a sentence that is in Pig Latin.
            for (int i = 0; i < tokens.Length; i++)
                if (tokens[i] != "")
                    output += TranslateWords(tokens[i]);

            //Trim Output.
            output = output.Trim();

            //Return sentence.
            return output += tempPunc.ToString();
        }

        //The TranslateWords method accepts a string as an argument. 
        //It takes a word and translates that word to pig latin. 
        //It then returns it back to the previous function.
        private string TranslateWords(string word)
        {
            //Variables
            char[] letters = word.ToCharArray();    //Create char array to hold characters of the word.
            char tempLetter = letters[0];           //set this variable to the first letter of the word.
            string completedWord = "";              //Accumulator word. Will be returned.

            //Loop to change word.
            for (int i = 0; i < letters.Length; i++)
            {
                if (i != (letters.Length - 1))
                    letters[i] = letters[i + 1];    //first letter becomes the second.
                else
                    letters[i] = tempLetter;        //Last letter becomes first original letter.
            }

            //Loop to create the new word.
            foreach (char c in letters)
                completedWord += c.ToString();

            //Add "ay " to the accumulated word.
            completedWord += "ay ";

            //Return the final word.
            return completedWord.ToUpper();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            //Variables
            string input = englishTextBox.Text;
            string output = TranslateToPigLatin(input);

            //Display newly translated sentence.
            pigLatinLabel.Text = output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
