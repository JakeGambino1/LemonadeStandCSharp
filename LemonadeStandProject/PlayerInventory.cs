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
        public void IncreaseInventory(int amountOfIngredient, Player player)
        {
            lemons += amountOfIngredient;
            UserInterface.InitializeInterface(player);
            Console.ReadLine();
        }
    }
}
