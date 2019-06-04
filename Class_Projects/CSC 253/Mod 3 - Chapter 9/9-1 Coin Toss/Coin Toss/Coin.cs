using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coin_Toss
{
    class Coin
    {
        //Field to represent the side facing up
        private string sideUp;
        Random rand = new Random();

        // constructor
        public Coin()
        {
            sideUp = "Heads";
        }

        //The toss method simulates tossing the coin
        public void toss()
        {
            //Create a Random Object
            //Random rand = new Random();

            //use a random number to determine
            //the side of the coin that is facing up
            //0 = heads, 1 = tails
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }

        //The GetSideUp method returns the value
        //of the sideUpfield
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
