using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Player
    {
        public string name;
        public double money;
        public PlayerInventory inventory = new PlayerInventory();
        public Recipe recipe = new Recipe();
        public double dailyCostOfGoodsSold;
        public double totalCostOfGoodsSold;
        public double dailyProfit;
        public double totalDailyProfits;
        public int pitcherOfLemonade;
        // pitcherOfLemonade should be its own object, with cups as a parameter.
        public int cupsOfLemonade;

        public Player()
        {
            Console.WriteLine("what would you like the player name to be?");
            name = Console.ReadLine();
            money = 20;
        }

        public bool AdjustRecipe()
        {
            UI.ShowInformation($"Your current lemonade mixture is {recipe.numberOfLemons} lemons, { recipe.amountOfIceCubes } ice cubes, and { recipe.amountOfSugar } cups of sugar. The recommended/starting sale price is ${recipe.price}.");
            return recipe.ChangeRecipe();
        }
        public void MakeLemonadePitcher(Recipe recipe, PlayerInventory inventory)
        {
            if (inventory.lemons >= recipe.numberOfLemons && inventory.ice >= recipe.amountOfIceCubes && inventory.sugar >= recipe.amountOfSugar)
            {
            inventory.lemons -= recipe.numberOfLemons;
            inventory.ice -= recipe.amountOfIceCubes;
            inventory.sugar -= recipe.amountOfSugar;
            UI.ShowInformation("You made a new pitcher of lemonade. Your remaining inventory is:\n" + inventory.lemons + " lemons, " + inventory.ice + " ice, and " + inventory.sugar + " sugar. Hopefully you can make it through day!");
            pitcherOfLemonade += 1;
            cupsOfLemonade += 6;
            }
            else
            {
                UI.ShowInformation("You don't have enough inventory to make a pitcher of lemonade. Visit the shop or adjust your recipe!");
            }
        }
        // Single Responsibility #2 - The only purpose of this method is to determine whether the player will visit the shop or not.
        public bool VisitShop()
        {
            UI.ShowInformation("Would you like to visit the shop again? 'yes' ('y') or 'no' ('n')");
            string userInput = Console.ReadLine();
            if (userInput == "yes" || userInput == "y")
            {
                return true;
            }
            else if (userInput == "no" || userInput == "n")
            {
                return false;
            }
            else
            {
                UI.ShowInformation("Invalid option. Please type 'yes' ('y') or 'no' ('n')");
                return VisitShop();
            }
        }
        public bool CanBuy(double totalCost)
        {
            if (money >= totalCost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PurchaseIngredients(double amountSpent)
        {
            money -= amountSpent;
            dailyCostOfGoodsSold += amountSpent;
        }
        public void DailyInventoryAdjustment(Player player)
        {
            UI.DisplayProfit(player);
            money += dailyProfit;
            totalDailyProfits += dailyProfit;
            dailyProfit = 0;
            totalCostOfGoodsSold += dailyCostOfGoodsSold;
            dailyCostOfGoodsSold = 0;
            UI.ShowInformation("You now have $" + money + " available.");
            cupsOfLemonade = 0;
        }
    }
}
