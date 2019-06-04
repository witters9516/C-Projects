using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaseBattler
    {
        //Private variables
        private string battlerName;
        private string battlerDescription;
        private int battlerMaxHP;
        private int battlerMaxMP;
        private int battlerCurrentHP;
        private int battlerCurrentMP;
        private int battlerATK;
        private int battlerDEF;
        private int battlerMAG;
        private int battlerMAGDEF;
        private int battlerSPD;
        private int battlerCurrentSPD;
        private int battlerEXP;
        private int battlerMoney;

        //Public Getters and Setters
        public string BattlerName
        {
            get { return battlerName; }
            set { battlerName = value; }
        }

        public string BattlerDescription
        {
            get { return battlerDescription; }
            set { battlerDescription = value; }
        }

        public int BattlerMaxHP
        {
            get { return battlerMaxHP; }
            set { battlerMaxHP = value; }
        }

        public int BattlerMaxMP
        {
            get { return battlerMaxMP; }
            set { battlerMaxMP = value; }
        }

        public int BattlerCurrentHP
        {
            get { return battlerCurrentHP; }
            set { battlerCurrentHP = value; }
        }

        public int BattlerCurrentMP
        {
            get { return battlerCurrentMP; }
            set { battlerCurrentMP = value; }
        }

        public int BattlerATK
        {
            get { return battlerATK; }
            set { battlerATK = value; }
        }

        public int BattlerDEF
        {
            get { return battlerDEF; }
            set { battlerDEF = value; }
        }

        public int BattlerMAG
        {
            get { return battlerMAG; }
            set { battlerMAG = value; }
        }

        public int BattlerMAGDEF
        {
            get { return battlerMAGDEF; }
            set { battlerMAGDEF = value; }
        }

        public int BattlerSPD
        {
            get { return battlerSPD; }
            set { battlerSPD = value; }
        }

    }
}
