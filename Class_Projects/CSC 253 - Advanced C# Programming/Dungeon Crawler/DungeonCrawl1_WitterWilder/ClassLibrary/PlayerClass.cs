using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PlayerClass : BaseBattler
    {
        public PlayerClass()
        {
            BattlerName = "Player";
            BattlerDescription = "";
            BattlerMaxHP = 0;
            BattlerMaxMP = 0;
            BattlerCurrentHP = 0;
            BattlerCurrentMP = 0;
            BattlerATK = 0;
            BattlerDEF = 0;
            BattlerMAG = 0;
            BattlerMAGDEF = 0;
            BattlerSPD = 0;
        }
    }
}
