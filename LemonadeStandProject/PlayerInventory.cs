using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class PlayerInventory
    {
        // member variables // has a
        public int lemons;
        public int ice;
        public int sugar;

        // constructor
        public PlayerInventory()
        {
            lemons = 0;
            ice = 0;
            sugar = 0;
        }

        // member methods // can do
        public int AdjustInventory()
        {
            return lemons -= 1;
        }
    }
}
