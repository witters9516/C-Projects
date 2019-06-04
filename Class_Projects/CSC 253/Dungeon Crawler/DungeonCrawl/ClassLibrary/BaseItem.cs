using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary
{
    public class BaseItem
    {
        private string itemName;
        private string itemDescription;
        private int healValue;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        public int HealValue
        {
            get { return healValue; }
            set { healValue = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
