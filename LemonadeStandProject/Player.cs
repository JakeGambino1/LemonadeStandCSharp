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
        public bool canBuy;
        public bool adjustRecipe;
        public bool purchaseMore;
        public Recipe recipe = new Recipe();

        // constructor
        public Player()
        {
            Console.WriteLine("what would you like the player name to be?");
            name = Console.ReadLine();
            money = 20;
            canBuy = false;
        }

        // member methods // can do
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
        public void AdjustMoney(double amountSpent, Player player)
        {
            money -= amountSpent;
            Console.WriteLine(money);
            UserInterface.InitializeInterface(player);
        }

        public bool RecipeAdjustment()
        {
            return recipe.ChangeRecipe();
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
    }
}
