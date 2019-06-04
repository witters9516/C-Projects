using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PlayerClass : BaseBattlerClass
    {
        public PlayerClass()
        {
            BattlerName = "";
            BattlerPassword = "";
            BattlerMaxHP = 20;
            BattlerCurrentHP = 20;
            Weapon = new PotWeapon();
            AddDefaultItems();
        }

        public PlayerClass(string name, string password, BaseWeapon weapon)
        {
            BattlerName = name;
            BattlerPassword = password;
            BattlerMaxHP = 20;
            BattlerCurrentHP = 20;
            Weapon = weapon;
            AddDefaultItems();

        }

        public PlayerClass(string name, string password, int maxHP, int currentHP, BaseWeapon weapon)
        {
            BattlerName = name;
            BattlerPassword = password;
            BattlerMaxHP = maxHP;
            BattlerCurrentHP = currentHP;
            Weapon = weapon;
            AddDefaultItems();
        }

        public void AddDefaultItems()
        {
            //Add default inventory
            this.PlayerItems.Add(new Food());
            this.PlayerItems.Add(new MedicalSupplies());
            this.PlayerItems.Add(new Clothes());

            this.PlayerTreasures.Add(new Hammer());
            this.PlayerTreasures.Add(new Flashlight());
            this.PlayerTreasures.Add(new KeyToSafeZone());
            this.PlayerTreasures.Add(new HiddenPathToMarathon());

        }

    }
}
