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
    public partial class Level_3 : Form
    {
        public Level_3()
        {
            InitializeComponent();
        }

        int matchChecker = 0;
        int firstPicture;
        int secondPicture;
        //Match Bool Variables
        bool moogle = false;        //Moogle Match
        bool Tama = false;          //Tama Match
        bool Moomba = false;        //Moomba Match
        bool Chocobo = false;       //Chocobo Match
        bool Cactaur = false;       //Cactaur Match
        bool Pupu = false;          //Pupu Match
        bool Serafie = false;       //Serafie Match
        bool Zapt = false;          //Zapt Match
        bool Fritt = false;         //Fritt Match
        bool Bablizz = false;       //Bablizz Match
        bool Mu = false;            //Mu Match
        bool ReaverMu = false;      //ReaverMu Match
        bool Quacho = false;        //Quacho Match
        bool WhiteNakk = false;     //WhiteNakk Match
        bool BlackNakk = false;     //BlackNakk Match

        private void CheckMatch(int picture1, int picture2)
        {
            //Variables
            bool MTR = false;   //Matches This Round?

            //Check for any of the designated matches
            //Moogle - 2 & 22
            if (picture1 == 2 && picture2 == 22 || picture1 == 22 && picture2 == 2)
            {
                if (moogle == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    moogle = true;
                    MTR = true;
                }
            }

            //Tama - 4 & 7
            if (picture1 == 4 && picture2 == 7 || picture1 == 7 && picture2 == 4)
            {
                if (Tama == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Tama = true;
                    MTR = true;
                }
            }

            //Mooba - 12 & 15
            if (picture1 == 12 && picture2 == 15 || picture1 == 15 && picture2 == 12)
            {
                if (Moomba == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Moomba = true;
                    MTR = true;
                }
            }

            //Chocobo - 10 & 26
            if (picture1 == 10 && picture2 == 26 || picture1 == 26 && picture2 == 10)
            {
                if (Chocobo == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Chocobo = true;
                    MTR = true;
                }
            }

            //Cactuar - 5 & 13
            if (picture1 == 5 && picture2 == 13 || picture1 == 13 && picture2 == 5)
            {
                if (Cactaur == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Cactaur = true;
                    MTR = true;
                }
            }

            //Pupu - 23 & 27
            if (picture1 == 23 && picture2 == 27 || picture1 == 27 && picture2 == 23)
            {
                if (Pupu == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Pupu = true;
                    MTR = true;
                }
            }

            //Serafie - 8 & 30
            if (picture1 == 8 && picture2 == 30 || picture1 == 30 && picture2 == 8)
            {
                if (Serafie == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Serafie = true;
                    MTR = true;
                }
            }

            //Zapt - 3 & 20
            if (picture1 == 3 && picture2 == 20 || picture1 == 20 && picture2 == 3)
            {
                if (Zapt == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Zapt = true;
                    MTR = true;
                }
            }

            //Fritt - 17 & 25
            if (picture1 == 17 && picture2 == 25 || picture1 == 25 && picture2 == 17)
            {
                if (Fritt == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Fritt = true;
                    MTR = true;
                }
            }

            //Bablizz - 11 & 14
            if (picture1 == 11 && picture2 == 14 || picture1 == 14 && picture2 == 11)
            {
                if (Bablizz == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Bablizz = true;
                    MTR = true;
                }
            }

            //Mu - 1 & 24
            if (picture1 == 1 && picture2 == 24 || picture1 == 24 && picture2 == 1)
            {
                if (Mu == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Mu = true;
                    MTR = true;
                }
            }

            //ReaverMu - 18 & 19
            if (picture1 == 18 && picture2 == 19 || picture1 == 19 && picture2 == 18)
            {
                if (ReaverMu == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    ReaverMu = true;
                    MTR = true;
                }
            }

            //Quacho - 6 & 28
            if (picture1 == 6 && picture2 == 28 || picture1 == 28 && picture2 == 6)
            {
                if (Quacho == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    Quacho = true;
                    MTR = true;
                }
            }

            //WhiteNakk - 9 & 29
            if (picture1 == 9 && picture2 == 29 || picture1 == 29 && picture2 == 9)
            {
                if (WhiteNakk == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    WhiteNakk = true;
                    MTR = true;
                }
            }

            //BlackNakk - 16 & 21
            if (picture1 == 16 && picture2 == 21 || picture1 == 21 && picture2 == 16)
            {
                if (BlackNakk == false)
                {
                    MessageBox.Show("Congratulations! That was a match!");
                    BlackNakk = true;
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
                card2FrontpictureBox.Visible = false;
                card22FrontpictureBox.Visible = false;
                card2BackpictureBox.Visible = true;
                card22BackpictureBox.Visible = true;
            }
            if (Tama == false)
            {
                card4FrontpictureBox.Visible = false;
                card7FrontpictureBox.Visible = false;
                card4BackpictureBox.Visible = true;
                card7BackpictureBox.Visible = true;
            }
            if (Moomba == false)
            {
                card12FrontpictureBox.Visible = false;
                card15FrontpictureBox.Visible = false;
                card12BackpictureBox.Visible = true;
                card15BackpictureBox.Visible = true;
            }
            if (Chocobo == false)
            {
                card10FrontpictureBox.Visible = false;
                card26FrontpictureBox.Visible = false;
                card10BackpictureBox.Visible = true;
                card26BackpictureBox.Visible = true;
            }
            if (Cactaur == false)
            {
                card5FrontpictureBox.Visible = false;
                card13FrontpictureBox.Visible = false;
                card5BackpictureBox.Visible = true;
                card13BackpictureBox.Visible = true;
            }
            if (Pupu == false)
            {
                card23FrontpictureBox.Visible = false;
                card27FrontpictureBox.Visible = false;
                card23BackpictureBox.Visible = true;
                card27BackpictureBox.Visible = true;
            }
            if (Serafie == false)
            {
                card8FrontpictureBox.Visible = false;
                card30FrontpictureBox.Visible = false;
                card8BackpictureBox.Visible = true;
                card30BackpictureBox.Visible = true;
            }
            if (Zapt == false)
            {
                card3FrontpictureBox.Visible = false;
                card20FrontpictureBox.Visible = false;
                card3BackpictureBox.Visible = true;
                card20BackpictureBox.Visible = true;
            }
            if (Fritt == false)
            {
                card17FrontpictureBox.Visible = false;
                card25FrontpictureBox.Visible = false;
                card17BackpictureBox.Visible = true;
                card25BackpictureBox.Visible = true;
            }
            if (Bablizz == false)
            {
                card11FrontpictureBox.Visible = false;
                card14FrontpictureBox.Visible = false;
                card11BackpictureBox.Visible = true;
                card14BackpictureBox.Visible = true;
            }
            if (Mu == false)
            {
                card1FrontpictureBox.Visible = false;
                card24FrontpictureBox.Visible = false;
                card1BackpictureBox.Visible = true;
                card24BackpictureBox.Visible = true;
            }
            if (ReaverMu == false)
            {
                card18FrontpictureBox.Visible = false;
                card19FrontpictureBox.Visible = false;
                card18BackpictureBox.Visible = true;
                card19BackpictureBox.Visible = true;
            }
            if (Quacho == false)
            {
                card6FrontpictureBox.Visible = false;
                card28FrontpictureBox.Visible = false;
                card6BackpictureBox.Visible = true;
                card28BackpictureBox.Visible = true;
            }
            if (WhiteNakk == false)
            {
                card9FrontpictureBox.Visible = false;
                card29FrontpictureBox.Visible = false;
                card9BackpictureBox.Visible = true;
                card29BackpictureBox.Visible = true;
            }
            if (BlackNakk == false)
            {
                card16FrontpictureBox.Visible = false;
                card21FrontpictureBox.Visible = false;
                card16BackpictureBox.Visible = true;
                card21BackpictureBox.Visible = true;
            }
        }

        //Checks to see if all matches have been made.
        //If so, then it displays a win message and 
        //then closes the form.
        private void WinGame()
        {
            if (moogle == true && Tama == true && Moomba == true && Chocobo == true)
                if (Cactaur == true && Pupu == true && Serafie == true && Zapt == true)
                    if (Fritt == true && Bablizz == true && Mu == true && ReaverMu == true)
                        if(Quacho == true && WhiteNakk == true && BlackNakk == true)
                        {
                            //Display win message
                            MessageBox.Show("You Win! Thanks for playing!");

                            //Close this form
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
                if (Cactaur == true && Pupu == true && Serafie == true && Zapt == true)
                    if (Fritt == true && Bablizz == true && Mu == true && ReaverMu == true)
                        if (Quacho == true && WhiteNakk == true && BlackNakk == true)
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

        private void card13BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card13FrontpictureBox.Visible = true;
            card13BackpictureBox.Visible = false;

            PictureChecker(13);
        }

        private void card14BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card14FrontpictureBox.Visible = true;
            card14BackpictureBox.Visible = false;

            PictureChecker(14);
        }

        private void card15BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card15FrontpictureBox.Visible = true;
            card15BackpictureBox.Visible = false;

            PictureChecker(15);
        }

        private void card16BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card16FrontpictureBox.Visible = true;
            card16BackpictureBox.Visible = false;

            PictureChecker(16);
        }

        private void card17BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card17FrontpictureBox.Visible = true;
            card17BackpictureBox.Visible = false;

            PictureChecker(17);
        }

        private void card18BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card18FrontpictureBox.Visible = true;
            card18BackpictureBox.Visible = false;

            PictureChecker(18);
        }

        private void card19BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card19FrontpictureBox.Visible = true;
            card19BackpictureBox.Visible = false;

            PictureChecker(19);
        }

        private void card20BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card20FrontpictureBox.Visible = true;
            card20BackpictureBox.Visible = false;

            PictureChecker(20);
        }

        private void card21BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card21FrontpictureBox.Visible = true;
            card21BackpictureBox.Visible = false;

            PictureChecker(21);
        }

        private void card22BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card22FrontpictureBox.Visible = true;
            card22BackpictureBox.Visible = false;

            PictureChecker(22);
        }

        private void card23BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card23FrontpictureBox.Visible = true;
            card23BackpictureBox.Visible = false;

            PictureChecker(23);
        }

        private void card24BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card24FrontpictureBox.Visible = true;
            card24BackpictureBox.Visible = false;

            PictureChecker(24);
        }

        private void card25BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card25FrontpictureBox.Visible = true;
            card25BackpictureBox.Visible = false;

            PictureChecker(25);
        }

        private void card26BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card26FrontpictureBox.Visible = true;
            card26BackpictureBox.Visible = false;

            PictureChecker(26);
        }

        private void card27BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card27FrontpictureBox.Visible = true;
            card27BackpictureBox.Visible = false;

            PictureChecker(27);
        }

        private void card28BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card28FrontpictureBox.Visible = true;
            card28BackpictureBox.Visible = false;

            PictureChecker(28);
        }

        private void card29BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card29FrontpictureBox.Visible = true;
            card29BackpictureBox.Visible = false;

            PictureChecker(29);
        }

        private void card30BackpictureBox_Click(object sender, EventArgs e)
        {
            //Change visibility
            card30FrontpictureBox.Visible = true;
            card30BackpictureBox.Visible = false;

            PictureChecker(30);
        }
        //-------------------------------------------------------------------
    }
}
