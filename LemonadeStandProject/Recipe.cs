using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Recipe
    {
        public int numberOfLemons;
        public int amountOfIceCubes;
        public int amountOfSugar;
        public bool inventoryToMake;
        public double price;

        public Recipe()
        {
            numberOfLemons = 5;
            amountOfIceCubes = 5;
            amountOfSugar = 5;
            price = .50;
        }

        public bool ChangeRecipe()
        {
            Console.WriteLine("Would you like to make changes to the recipe? y/n");
            string makeChanges = Console.ReadLine().ToLower();
            if (makeChanges == "yes" || makeChanges == "y")
            {
                Console.WriteLine("Would you like to adjust the recipe? 'lemon' ('l'), 'ice' ('i'), or 'sugar' ('s')? or the 'price' ('p')?");
                string ingredientChange = Console.ReadLine().ToLower();
                switch (ingredientChange)
                {
                    case "lemon":
                    case "l":
                        Console.WriteLine("How many lemons would you like in the recipe?");
                        numberOfLemons = Convert.ToInt32(Console.ReadLine());
                        return true;
                    case "ice":
                    case "i":
                        Console.WriteLine("How many ice cubes would you like in the recipe?");
                        amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
                        return true;
                    case "sugar":
                    case "s":
                        Console.WriteLine("How much sugar would you like in the recipe?");
                        amountOfSugar = Convert.ToInt32(Console.ReadLine());
                        return true;
                    case "price":
                    case "p":
                        Console.WriteLine("What would you like the price to be?");
                        price = Convert.ToInt32(Console.ReadLine());
                        return true;
                    default:
                        Console.WriteLine("please make a valid selection - lemon (l), ice (i), or sugar (s)");
                        return ChangeRecipe();
                }
            }
            else if (makeChanges == "no" || makeChanges == "n")
            {
                Console.WriteLine("You will begin the day with the following mixture:");
                UserInterface.DisplayCurrentRecipe(this);
                return false;
            }
            else
            {
                Console.WriteLine("You made an invalid selection. please choose yes (y) or no (n)");
                return ChangeRecipe();
            }
        }
    }
}
