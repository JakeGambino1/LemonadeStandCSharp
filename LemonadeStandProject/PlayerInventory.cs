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
        public void IncreaseInventory(int amountOfIngredient, IngredientsForPurchase typeOfIngredient)
        {
            if (typeOfIngredient.name == "lemon")
            {

                lemons += amountOfIngredient;
            }
            else if (typeOfIngredient.name == "ice cubes")
            {

                ice += amountOfIngredient;
            }
            else if (typeOfIngredient.name == "sugar")
            {

                sugar += amountOfIngredient;
            }
        }
    }
}
