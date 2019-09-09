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
            price = .25;
        }

        public bool ChangeRecipe()
        {
            UI.ShowInformation("Would you like to make changes to the recipe? y/n");
            string makeChanges = Console.ReadLine().ToLower();
            if (makeChanges == "yes" || makeChanges == "y")
            {
                UI.ShowInformation("Would you like to adjust the recipe? 'lemon' ('l'), 'ice' ('i'), or 'sugar' ('s')? or the 'price' ('p')?");
                string ingredientChange = Console.ReadLine().ToLower();
                switch (ingredientChange)
                {
                    case "lemon":
                    case "l":
                        UI.ShowInformation("How many lemons would you like in the recipe?");
                        numberOfLemons = Convert.ToInt32(Console.ReadLine());
                        return true;
                    case "ice":
                    case "i":
                        UI.ShowInformation("How many ice cubes would you like in the recipe?");
                        amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
                        return true;
                    case "sugar":
                    case "s":
                        UI.ShowInformation("How much sugar would you like in the recipe?");
                        amountOfSugar = Convert.ToInt32(Console.ReadLine());
                        return true;
                    case "price":
                    case "p":
                        UI.ShowInformation("What would you like the price to be?");
                        price = Convert.ToDouble(Console.ReadLine());
                        return true;
                    default:
                        UI.ShowInformation("please make a valid selection - lemon (l), ice (i), or sugar (s)");
                        return ChangeRecipe();
                }
            }
            else if (makeChanges == "no" || makeChanges == "n")
            {
                UI.ShowInformation("You will begin the day with the following mixture:");
                UI.ShowInformation($"Your current lemonade mixture is {numberOfLemons} lemons, { amountOfIceCubes } ice cubes, and { amountOfSugar } cups of sugar. The recommended/starting sale price is ${price}.");
                return false;
            }
            else
            {
                UI.ShowInformation("You made an invalid selection. please choose yes (y) or no (n)");
                return ChangeRecipe();
            }
        }
    }
}
