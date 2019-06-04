/**
* 9/14/17
* CSC 253
* Shawn Witter
* This program capitilizes the first letter of every sentence.
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

namespace M2PP3_Witter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string CapitalizeSentence(string sentences)
        {
            //Variables
            string output = "";
            char[] delim = {'.'};
            string[] sentenceArray = sentences.Split(delim);

            //Steps through the array and capitilizes each sentence.
            for(int i = 0; i < sentenceArray.Length; i++)
                if (sentenceArray[i] != "")
                {
                    sentenceArray[i] = sentenceArray[i].TrimStart();
                    sentenceArray[i] = CapitilizeWord(sentenceArray[i]);
                    output += sentenceArray[i] + ". ";
                }

            return output;
        }

        public string CapitilizeWord(string word)
        {
            //variables
            char[] array = word.ToCharArray();  //send word into a character array.
            string returnWord = "";             //string accumulator.

            //set the first character to the uppercase equivalent.
            array[0] = char.ToUpper(array[0]);

            //creates new string using a loop.
            for (int i = 0; i < array.Length; i++)
                returnWord += array[i];

            //return new string.
            return returnWord;
        }

        private void changeStringButton_Click(object sender, EventArgs e)
        {
            //Variables
            string input = stringTextBox.Text;          //set equal to textbox text.
            string output = CapitalizeSentence(input);  //call and set equal to CapitalizeSentence method.

            //Display output.
            capitilizedSentenceLabel.Text = output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
