using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Recipe
    {
        // member variables
        public int numberOfLemons;
        public int numberOfIce;
        public int numberOfSugar;
        public bool inventoryToMake;

        // constructor
        public Recipe()
        {
            numberOfLemons = 5;
            numberOfIce = 5;
            numberOfSugar = 5;
        }
        // member methods
        public void NumberOfPitchers()
        {

        }
        public void DisplayCurrentRecipe()
        {
            Console.WriteLine("Your current lemonade mixture is " + numberOfLemons + " lemons, " + numberOfIce + " ice cubes, and " + numberOfSugar + " cups of sugar.");
        }

        public void MakeChangesToRecipe()
        {
            Console.WriteLine("Would you like to make changes to the recipe? y/n");
            string makeChanges = Console.ReadLine().ToLower();
            if (makeChanges == "yes" || makeChanges == "y")
            {
                Console.WriteLine("Which ingredient would you like to adjust? lemon (l), ice cubes (i), or sugar cups (s)");
                string ingredientChange = Console.ReadLine().ToLower();

                switch (ingredientChange)
                {
                    case "lemon":
                    case "l":
                        Console.WriteLine("Adjusting amount of lemons\nHow many would you like in the recipe?");
                        numberOfLemons = Convert.ToInt32(Console.ReadLine());
                        return;
                    case "ice":
                    case "i":
                        Console.WriteLine("Adjusting amount of ice cubes\nHow many would you like in the recipe?");
                        numberOfIce = Convert.ToInt32(Console.ReadLine());
                        return;
                    case "sugar":
                    case "s":
                        Console.WriteLine("Adjusting amount of sugar\nHow many would you like in the recipe?");
                        numberOfSugar = Convert.ToInt32(Console.ReadLine());
                        return;
                    default:
                        Console.WriteLine("please make a valid selection - lemon (l), ice (i), or sugar (s)");
                        MakeChangesToRecipe();
                        return;
                }
                
            }
            else if (makeChanges == "no" || makeChanges == "n")
            {
                return;
            }
            Console.WriteLine("You will begin the day with the following mixture:");
            DisplayCurrentRecipe();
            Console.ReadLine();
        }
    }
}
