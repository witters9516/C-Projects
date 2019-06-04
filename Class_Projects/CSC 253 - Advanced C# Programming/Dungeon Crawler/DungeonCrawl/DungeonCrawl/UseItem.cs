using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace DungeonCrawl
{
    public partial class UseItem : Form
    {
        //Variables
        public BaseBattlerClass player;
        public List<BaseItem> currentItems;
        int index;

        public UseItem()
        {
            InitializeComponent();
        }

        private void UseItem_Load(object sender, EventArgs e)
        {
            //Add Items from list to listbox.
            foreach (BaseItem i in currentItems)
                currentItemsListBox.Items.Add(i.ItemName);

            //Set a selectedindex for the list.
            currentItemsListBox.SelectedIndex = 0;
            index = currentItemsListBox.SelectedIndex;
        }

        private void currentItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = currentItemsListBox.SelectedIndex;  //Set current index of currentItemsListBox
            DisplayItemInfo();                          //Display Current index Item info.
        }

        private void useItemButton_Click(object sender, EventArgs e)
        {
            BaseItem temp = null;       //Create an empty Item.

            //Find the item being chosen and set it to temp.
            for (int i = 0; i < currentItems.Count; i++)
                if (currentItemsListBox.Items[currentItemsListBox.SelectedIndex].ToString() == currentItems[i].ItemName)
                    temp = currentItems[i];

            //If the item isn't null, call the method that uses the item.
            if (temp != null)
                UseItemOnPlayer(temp, player);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        //The UseItemOnPlayer method accepts a BaseItem and a BaseBattlerClass object as an argument.
        //This function uses the item to heal the player and then removes the item from the list and listbox.
        private void UseItemOnPlayer(BaseItem item, BaseBattlerClass battler)
        {
            if (item.Quantity != 0)
            {
                //Item found?
                bool itemFound = false;

                //Find item used in the standard list and remove it.
                for (int i = 0; i < currentItems.Count; i++)
                    if (itemFound == false)
                        if (item.ItemName == currentItems[i].ItemName)
                        {
                            currentItems[i].Quantity -= 1;                  //Reduce Quantity by 1
                            battler.BattlerCurrentHP += item.HealValue;     //Heal Player
                            itemFound = true;                               //Prevent Using 2 or more of the same Item.
                        }

                //Handle battlerHP that is over it's Max Value
                if (battler.BattlerCurrentHP >= battler.BattlerMaxHP)
                    battler.BattlerCurrentHP = battler.BattlerMaxHP;

                //Set list in main game to the new list.
                DungeonCrawlGame.tItems = currentItems;
                //Set Player Object in main game to the new HP of this player object.
                DungeonCrawlGame.player.BattlerCurrentHP = battler.BattlerCurrentHP;
                //Close this Dialog.
                this.Close();
            }
            else
                MessageBox.Show("There are no more " + item.ItemName + " items to use!");
        }

        private void DisplayItemInfo()
        {
            //Set temp equal to the name of the selected index.
            string temp = currentItemsListBox.Items[currentItemsListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < currentItems.Count; i++)
                if (currentItems[i].ItemName == temp)
                {
                    itemNameLabel.Text = currentItems[i].ItemName;
                    itemDescriptionLabel.Text = currentItems[i].ItemDescription;
                    healValueLabel.Text = currentItems[i].HealValue.ToString();
                    quanLabel.Text = currentItems[i].Quantity.ToString();
                }
        }
    }
}
