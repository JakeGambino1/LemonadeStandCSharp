using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class SupplyShop
    {
        // member variables
        public static IngredientsForPurchase ingredient;


        // constructor
        public SupplyShop()
        {
        }

        // member methods
        public void InitializeShop(Player player)
        {
            WhatToBuy();
            int amountOfIngredient = ingredient.BuyXUnits(ingredient);
            double totalCost = ingredient.CalculateTotalCost(ingredient);
            if (player.CanBuy(totalCost))
            {
                player.inventory.IncreaseInventory(amountOfIngredient, ingredient);
                player.AdjustMoney(totalCost, player);
            }
            else
            {
                Console.WriteLine("You don't have enough money for that! You only have $" + player.money + " available");
            }

        }
        public static IngredientsForPurchase WhatToBuy()
        {
            Console.WriteLine("What product would you like to buy? lemon (l), ice cubes (i), or sugar cups (s)");
            string supplyPurchase = Console.ReadLine();
            switch (supplyPurchase)
            {
                case "lemon":
                case "l":
                    Console.WriteLine("purchasing lemons");
                    return ingredient = new Lemon();
                case "ice":
                case "i":
                    Console.WriteLine("purchasing ice cubes");
                    return ingredient = new IceCubes();
                case "sugar":
                case "s":
                    Console.WriteLine("purchasing sugar");
                    return ingredient = new Sugar();
                default:
                    Console.WriteLine("please make a valid selection - lemon (l), ice (i), or sugar (s)");
                    return WhatToBuy();
            }
        }
    }
}
