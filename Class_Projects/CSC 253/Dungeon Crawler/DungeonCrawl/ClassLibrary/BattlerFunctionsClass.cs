using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BattlerFunctionsClass
    {
        private string enemyAttackedName;                     // to hold which enemy is attacking
        float variance = .15f;                               // holds a value between .05 and .20
        public static List<BaseBattlerClass> battlerList;

        public string EnemyAttackedName
        {
            get { return enemyAttackedName; }
            set { enemyAttackedName = value; }
        }

        public List<BaseBattlerClass> BattlerList
        {
            get { return battlerList; }
            set { battlerList = value; }
        }

        //BattleProcess Function - To find the current battler and have them attack, then the next person goes.
        public List<BaseBattlerClass> BattleProcess(string playerName, string targetName)
        {
            BaseBattlerClass attacker = null;
            bool battlerAttacked = false;
            Random rand = new Random();
            //1. Loop to determine who goes first.
            //if(player)
            //2. Nested Loop to find target
            //3. Deal Damage
            //if(enemy)
            //2. find player
            //3. DealDamage
            //4. Check for enemies whose HP hit 0 or less and remove them after the battle.
            //5. After Loop is done, return List to game
            
            for (int attackerIndex = 0; attackerIndex < battlerList.Count; attackerIndex++)
            {
                // Look for attacker
                attacker = battlerList[attackerIndex];

                //Set battlerAttacked back to true.
                battlerAttacked = false;

                //2. Nested Loop to find target
                if(attacker.BattlerName == playerName)
                    for (int damageIndex = 0; damageIndex < battlerList.Count; damageIndex++)
                    {
                        if (battlerAttacked == false)
                            if (battlerList[damageIndex].BattlerName == targetName)
                            {
                                battlerList[damageIndex].BattlerCurrentHP -= (int)Math.Round((attacker.Weapon.WeaponDamage + GetRandomNumber(variance, attacker.Weapon.WeaponDamage)));
                                battlerAttacked = true;
                            }

                    }
                else
                    for (int damageIndex = 0; damageIndex < battlerList.Count; damageIndex++)
                    {
                        if (battlerAttacked == false)
                            if (battlerList[damageIndex].BattlerName == playerName)
                            {
                                battlerList[damageIndex].BattlerCurrentHP -= (int)Math.Round((attacker.Weapon.WeaponDamage + GetRandomNumber(variance, attacker.Weapon.WeaponDamage)));
                                battlerAttacked = true;
                            }
                    }
            }

            //Check For EnemyDestruction.
            EnemyDestruction(battlerList);

            return battlerList;
        }

        public double GetRandomNumber(double dVar, int attackDamage)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0,3); //Make Negative or not
            int randomNumber2 = rand.Next(0, 16);//Add or subtract this many times.
            
            //Set dVar to negative or positive based on random number
            if (randomNumber <= 1)
                dVar *= -1; 
            else
                dVar *= 1;

            //Change variance based on random number
            for (int i = randomNumber2; i < randomNumber2; i++)
                if (dVar < 0)
                    dVar -= .05;
                else
                    dVar += .05;

            //return dVar
            return dVar;// * attackDamage;
        }


        //for (int i = 0; i < BattlerList.Count; i++)
        //    BaseBattlerClass attacker = new BaseBattlerClass(); // Create the attacker object



        //// Create the attacked object
        //BaseBattlerClass attacked = new BaseBattlerClass();

        public List<BaseBattlerClass> EnemyDestruction(List<BaseBattlerClass> list)
        {
            //If anyone in the list has 0 HP, Remove them.
            for (int i = 0; i < list.Count; i++)
                if (list[i].BattlerCurrentHP <= 0)
                    list.RemoveAt(i);
            return list;
        }
    }
}
