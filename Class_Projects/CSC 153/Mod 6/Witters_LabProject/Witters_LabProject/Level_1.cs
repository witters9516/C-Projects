using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_LabProject
{
    public partial class Level_1 : Form
    {
        public Level_1()
        {
            InitializeComponent();
        }

        int matchChecker = 0;
        int firstPicture;
        int secondPicture;
        //Match Bool Variables
        bool moogle = false;    //Moogle Match
        bool Tama = false;      //Tama Match
        bool Moomba = false;    //Moomba Match
        bool Chocobo = false;   //Chocobo Match
        bool Cactaur = false;   //Cactaur Match
        bool Pupu = false;      //Pupu Match

        private void CheckMatch(int picture1, int picture2)
        {
            //Variables
            bool MTR = false;   //Matches This Round?

            //Check for any of the designated matches
            //Moogle - 1 & 7
            if (picture1 == 1 && picture2 == 7 || picture1 == 7 && picture2 == 1)
            {
                if (moogle == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    moogle = true;
                    MTR = true;
                }
            }

            //Tama - 2 & 11
            if (picture1 == 2 && picture2 == 11 || picture1 == 11 && picture2 == 2)
            {
                if (Tama == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Tama = true;
                    MTR = true;
                }
            }

            //Mooba - 3 & 10
            if (picture1 == 3 && picture2 == 10 || picture1 == 10 && picture2 == 3)
            {
                if (Moomba == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Moomba = true;
                    MTR = true;
                }
            }

            //Chocobo - 4 & 6
            if (picture1 == 4 && picture2 == 6 || picture1 == 6 && picture2 == 4)
            {
                if (Chocobo == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Chocobo = true;
                    MTR = true;
                }
            }

            //Cactuar - 5 & 12
            if (picture1 == 5 && picture2 == 12 || picture1 == 12 && picture2 == 5)
            {
                if (Cactaur == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Cactaur = true;
                    MTR = true;
                }
            }

            //Pupu - 8 & 9
            if (picture1 == 8 && picture2 == 9 || picture1 == 9 && picture2 == 8)
            {
                if (Pupu == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Pupu = true;
                    MTR = true;
                }
            }

            //runs if no matches are made.
            if (MTR == false)
            {
                NoMatches();
            }

            //WinGame Method call
            WinGame();

            //Set globals to 0.
            firstPicture = 0;
            secondPicture = 0;
            matchChecker = 0;

        }

        private void NoMatches()
        {
            MessageBox.Show("That was not a match. Keep trying!");
            if (moogle == false)
            {
                card1FrontpictureBox.Visible = false;
                card7FrontpictureBox.Visible = false;
                card1BackpictureBox.Visible = true;
                card7BackpictureBox.Visible = true;
            }
            if (Tama == false)
            {
                card2FrontpictureBox.Visible = false;
                card11FrontpictureBox.Visible = false;
                card2BackpictureBox.Visible = true;
                card11BackpictureBox.Visible = true;
            }
            if (Moomba == false)
            {
                card3FrontpictureBox.Visible = false;
                card10FrontpictureBox.Visible = false;
                card3BackpictureBox.Visible = true;
                card10BackpictureBox.Visible = true;
            }
            if (Chocobo == false)
            {
                card4FrontpictureBox.Visible = false;
                card6FrontpictureBox.Visible = false;
                card4BackpictureBox.Visible = true;
                card6BackpictureBox.Visible = true;
            }
            if (Cactaur == false)
            {
                card5FrontpictureBox.Visible = false;
                card12FrontpictureBox.Visible = false;
                card5BackpictureBox.Visible = true;
                card12BackpictureBox.Visible = true;
            }
            if (Pupu == false)
            {
                card8FrontpictureBox.Visible = false;
                card9FrontpictureBox.Visible = false;
                card8BackpictureBox.Visible = true;
                card9BackpictureBox.Visible = true;
            }
        }

        //Checks to see if all matches have been made.
        //If so, then it displays a win message and 
        //then closes the form.
        private void WinGame()
        {
            if (moogle == true && Tama == true && Moomba == true && Chocobo == true)
                if (Cactaur == true && Pupu == true)
                {
                    //Display win message
                    MessageBox.Show("You Win! On to the next level!");

                    //Close this Form
                    this.Close();
                }
        }

        //Checks what picture was clicked on and based on whether it was the 
        //first button or the second, it sets it to either firstPicture or secondPicture
        private void PictureChecker(int pictureNumber)
        {
            //Set number equal to picture selected on form.
            if (matchChecker == 0)
                firstPicture = pictureNumber;
            else if (matchChecker == 1)
                secondPicture = pictureNumber;

            //Increment MatchChecker
            matchChecker++;

            //If the second number is set, this function is called.
            if (matchChecker == 2)
                CheckMatch(firstPicture, secondPicture);
        }

        //This function Checks to see if all of the matches in this level have been made.
        //If yes, then it returns true. If no, it returns false.
        public bool LevelFinished()
        {
            if (moogle == true && Tama == true && Moomba == true && Chocobo == true)
                if (Cactaur == true && Pupu == true)
                {
                    return true;
                }
            return false;
        }


        //-------------------------------------------------------------------
        //PictureBox Click Functions
        //-------------------------------------------------------------------
        private void card1BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card1FrontpictureBox.Visible = true;
            card1BackpictureBox.Visible = false;

            PictureChecker(1);
        }

        private void card2BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card2FrontpictureBox.Visible = true;
            card2BackpictureBox.Visible = false;

            PictureChecker(2);
        }

        private void card3BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card3FrontpictureBox.Visible = true;
            card3BackpictureBox.Visible = false;

            PictureChecker(3);
        }

        private void card4BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card4FrontpictureBox.Visible = true;
            card4BackpictureBox.Visible = false;

            PictureChecker(4);
        }

        private void card5BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card5FrontpictureBox.Visible = true;
            card5BackpictureBox.Visible = false;

            PictureChecker(5);
        }

        private void card6BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card6FrontpictureBox.Visible = true;
            card6BackpictureBox.Visible = false;

            PictureChecker(6);
        }

        private void card7BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card7FrontpictureBox.Visible = true;
            card7BackpictureBox.Visible = false;

            PictureChecker(7);
        }

        private void card8BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card8FrontpictureBox.Visible = true;
            card8BackpictureBox.Visible = false;

            PictureChecker(8);
        }

        private void card9BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card9FrontpictureBox.Visible = true;
            card9BackpictureBox.Visible = false;

            PictureChecker(9);
        }

        private void card10BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card10FrontpictureBox.Visible = true;
            card10BackpictureBox.Visible = false;

            PictureChecker(10);
        }

        private void card11BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card11FrontpictureBox.Visible = true;
            card11BackpictureBox.Visible = false;

            PictureChecker(11);
        }

        private void card12BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card12FrontpictureBox.Visible = true;
            card12BackpictureBox.Visible = false;

            PictureChecker(12);
        }
        //-------------------------------------------------------------------
    }
}
