//CSC 153 Lab Project
//Witters_Lab Project
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

namespace Witters_LabProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //LevelCheck Variables
        bool level_1_Complete = false;
        bool level_2_Complete = false;
        bool level_3_Complete = false;

        private void beginGameButton_Click(object sender, EventArgs e)
        {
            //Create an instance each game level
            Level_1 level_1 = new Level_1();
            Level_2 level_2 = new Level_2();
            Level_3 level_3 = new Level_3();

            //Hide this screen and its control from user.
            this.Hide();

            //Check to see if level 1 has been beaten, if so it moves on.
            //If not, it opens level 1.
            if (level_1_Complete == false)
            {
                //Bring up level one
                level_1.ShowDialog();
                if (level_1.LevelFinished() == true)
                    Level1Finished();
                else
                    LevelReset();
            }

            //Check to see if level 1 has been beaten first and then checks level 2. 
            //If so, it moves on. If not, it opens level 2.
            if (level_1_Complete == true && level_2_Complete == false)
            {
                level_2.ShowDialog();
                if (level_2.LevelFinished() == true)
                    Level2Finished();
                else
                    LevelReset();
            }

            //Check to see if level 2 has been beaten first and then checks level 3. 
            //If so, it moves on. If not, it opens level 3.
            if (level_2_Complete == true && level_3_Complete == false)
            {
                level_3.ShowDialog();
                if (level_3.LevelFinished() == true)
                    Level3Finished();
                else
                    LevelReset();
            }

            //Resets the game if the user has gone through every level and completed it.
            if (level_1_Complete == true && level_2_Complete == true && level_3_Complete == true)
                LevelReset();
        }

        //Sets level 1 complete to true
        public void Level1Finished()
        {
            level_1_Complete = true;
        }

        //Sets level 2 complete to true
        public void Level2Finished()
        {
            level_2_Complete = true;
        }

        //Sets level 3 complete to true
        public void Level3Finished()
        {
            level_3_Complete = true;
        }

        //Resets the game by setting all of the level complete variables to false and showing Form1.
        public void LevelReset()
        {
            level_1_Complete = false;
            level_2_Complete = false;
            level_3_Complete = false;
            this.Show();
        }

    }
}
