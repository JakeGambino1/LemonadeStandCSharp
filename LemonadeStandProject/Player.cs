using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Player
    {
        // member variables // has a
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

        // constructor
        public Player()
        {
            Console.WriteLine("what would you like the player name to be?");
            name = Console.ReadLine();
            money = 20;
        }

        // member methods // can do
        public bool RecipeAdjustment()
        {
            recipe.DisplayCurrentRecipe();
            return recipe.ChangeRecipe();
        }
        public void MakeLemonadePitcher(Recipe recipe, PlayerInventory inventory)
        {
            if (inventory.lemons >= recipe.numberOfLemons && inventory.ice >= recipe.amountOfIceCubes && inventory.sugar >= recipe.amountOfSugar)
            {
            inventory.lemons -= recipe.numberOfLemons;
            inventory.ice -= recipe.amountOfIceCubes;
            inventory.sugar -= recipe.amountOfSugar;
            Console.WriteLine("You made a new pitcher of lemonade. Your remaining inventory is:\n" + inventory.lemons + " lemons, " + inventory.ice + " ice, and " + inventory.sugar + " sugar. Hopefully you can make it through day!");
            pitcherOfLemonade += 1;
            cupsOfLemonade += 6;
            }
            else
            {
                Console.WriteLine("You don't have enough inventory to make a pitcher of lemonade. Visit the shop or adjust your recipe!");
            }
        }
        public bool VisitShop()
        {
            Console.WriteLine("Would you like to visit the shop again? 'yes' ('y') or 'no' ('n')");
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
                Console.WriteLine("Invalid option. Please type 'yes' ('y') or 'no' ('n')");
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
        public void PurchaseIngredients(double amountSpent, Player player)
        {
            money -= amountSpent;
            dailyCostOfGoodsSold += amountSpent;
            Console.WriteLine(money);
            UserInterface.InitializeInterface(player);
        }
        public int DailyInventoryAdjustment(int dayCount)
        {
            double dailyNetProfit = dailyProfit - dailyCostOfGoodsSold;
            Console.WriteLine("Your daily profit of $" + dailyProfit + " has been added to your wallet. Your expenses for today was $" + dailyCostOfGoodsSold + ". Your net profit for today was $" + dailyNetProfit + ".") ;
            money += dailyProfit;
            totalDailyProfits += dailyProfit;
            dailyProfit = 0;
            totalCostOfGoodsSold += dailyCostOfGoodsSold;
            dailyCostOfGoodsSold = 0;
            Console.WriteLine("You now have $" + money + " available.");
            cupsOfLemonade = 0;
            return dayCount++;
        }
    }
}
