using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DungeonCrawl1_Witter
{
    public partial class EnemyForm : Form
    {
        //Global Variables.
        const int SIZE = 5;
        Mob[] mobList = new Mob[SIZE];

        public EnemyForm()
        {
            InitializeComponent();
        }

        #region EnemyData

        struct Mob
        {
            public string MobName;
            public string MobDesc;
            public int MobMaxHP;
            public int MobMaxMP;
            public int MobCurrentHP;
            public int MobCurrentMP;
            public int MobATK;
            public int MobDEF;
            public int MobMAG;
            public int MobMAGDEF;
            public int MobSPD;
            public int MobEXP;
        };

        private Mob CreateMob(string filename)
        {
            //Create a temp struct that will be returned later.
            Mob temp = new Mob();

            //Variables
            string fileName = filename;
            string str = "";
            
            //Use a streamReader to get Enemy Contents
            StreamReader inFile = File.OpenText(fileName);

            //Create the string to split
            while (!inFile.EndOfStream)
                str += inFile.ReadLine() + " ";

            //Close the file
            inFile.Close();

            //Split str into an array
            string[] strArray = str.Split(null);

            //Set values to struct variables.
            for (int i = 0; i < strArray.Length; i++)
            {
                if(i == 0)
                    temp.MobName = strArray[i].Replace(",", " ");
                if(i == 1)
                    temp.MobDesc = strArray[i].Replace(",", " ");
                if (i == 2)
                    temp.MobMaxHP = int.Parse(strArray[i]);
                if (i == 3)
                    temp.MobMaxMP = int.Parse(strArray[i]);
                if (i == 4)
                    temp.MobCurrentHP = int.Parse(strArray[i]);
                if (i == 5)
                    temp.MobCurrentMP = int.Parse(strArray[i]);
                if (i == 6)
                    temp.MobATK = int.Parse(strArray[i]);
                if (i == 7)
                    temp.MobDEF = int.Parse(strArray[i]);
                if (i == 8)
                    temp.MobMAG = int.Parse(strArray[i]);
                if (i == 9)
                    temp.MobMAGDEF = int.Parse(strArray[i]);
                if (i == 10)
                    temp.MobSPD = int.Parse(strArray[i]);
                if (i == 11)
                    temp.MobEXP = int.Parse(strArray[i]);
            }

            //Return temp struct.
            return temp;
        }
        #endregion

        private void EnemyForm_Load(object sender, EventArgs e)
        {
            //Create 1 instance of each Mob and set their values.
            Mob Grunt = CreateMob("Grunt.txt");
            Mob Captain = CreateMob("Captain.txt");
            Mob General = CreateMob("General.txt");
            Mob KingsGuard = CreateMob("KingsGuard.txt");
            Mob King = CreateMob("King.txt");
            
            //Create an array to hold the structs
            mobList[0] = Grunt;
            mobList[1] = Captain;
            mobList[2] = General;
            mobList[3] = KingsGuard;
            mobList[4] = King;

            //Add structs to listbox.
            foreach (Mob m in mobList)
                eListBox.Items.Add(m.MobName);

            //Set selected index to 0.
            eListBox.SelectedIndex = 0;
        }

        private void eListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEnemyInfo(mobList);  //Display current index
        }

        private void DisplayEnemyInfo(Mob[] eArray)
        {
            //Set temp equal to the name of the selected index.
            string temp = eListBox.Items[eListBox.SelectedIndex].ToString();
            
            //Change display info based on the new index.
            for (int i = 0; i < eArray.Length; i++)
                if (eArray[i].MobName == temp)
                {
                    eNameLabel.Text = eArray[i].MobName;
                    eDescLabel.Text = eArray[i].MobDesc;
                    eHPLabel.Text = eArray[i].MobMaxHP.ToString();
                    eMPLabel.Text = eArray[i].MobMaxMP.ToString();

                    eATKLabel.Text = eArray[i].MobATK.ToString();
                    eDEFLabel.Text = eArray[i].MobDEF.ToString();
                    eMAGLabel.Text = eArray[i].MobMAG.ToString();
                    eMAGDEFLabel.Text = eArray[i].MobMAGDEF.ToString();
                    eSPDLabel.Text = eArray[i].MobSPD.ToString();
                    eEXPLabel.Text = eArray[i].MobEXP.ToString();
                }
        }
    }
}
