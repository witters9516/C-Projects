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
    public partial class CurrentKeyItems : Form
    {
        //Variables
        public List<BaseTreasure> currentTreasures;

        int index;

        public CurrentKeyItems()
        {
            InitializeComponent();
        }

        private void CurrentKeyItems_Load(object sender, EventArgs e)
        {
            index = currentTreasuresListBox.SelectedIndex;

            foreach (BaseTreasure i in currentTreasures)
                if (i.Quantity != 0)
                    currentTreasuresListBox.Items.Add(i.TreasureName);
        }

        private void currentTreasuresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = currentTreasuresListBox.SelectedIndex;  //Set current index of currentItemsListBox
            DisplayItemInfo();
        }

        private void DisplayItemInfo()
        {
            //Set temp equal to the name of the selected index.
            string temp = currentTreasuresListBox.Items[currentTreasuresListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < currentTreasures.Count; i++)
                if (currentTreasures[i].TreasureName == temp)
                {
                    treasureNameLabel.Text = currentTreasures[i].TreasureName;
                    treasureDescriptionLabel.Text = currentTreasures[i].TreasureDescription;
                    treasureUseLabel.Text = currentTreasures[i].TreasureUse.ToString();
                }
        }
    }
}
