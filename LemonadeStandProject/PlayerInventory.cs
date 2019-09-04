using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class PlayerInventory
    {
        // member variables
        public int lemons;
        public int ice;
        public int sugar;
        public double increaseInInventory;

        // constructor
        public PlayerInventory()
        {
            lemons = 0;
            ice = 0;
            sugar = 0;
        }

        // member methods
        public void IncreaseInventory(int amountPurchased, IngredientsForPurchase ingredient)
        {
            if (ingredient.name == "lemon")
            {
                lemons += amountPurchased;
            }
            else if (ingredient.name == "ice cubes")
            {
                ice += amountPurchased;
            }
            else if (ingredient.name == "sugar")
            {
                sugar += amountPurchased;
            }
        }
    }
}
