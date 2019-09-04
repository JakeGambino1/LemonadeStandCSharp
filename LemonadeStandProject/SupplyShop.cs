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
        public bool stopShopping;

        // constructor
        public SupplyShop()
        {
            stopShopping = false;
        }

        // member methods
        public void ShopLoop(Player player)
        {
            while (stopShopping == false) 
            {
                WhatToBuy();
                VerifyPurchase(player);
                ContinueShopping(player);
            }
            Console.WriteLine("Time to get the day started!");
        }
        public static IngredientsForPurchase WhatToBuy()
        {
            Console.WriteLine("What product would you like to buy? lemon (l), ice cubes (i), or sugar cups (s)");
            string ingredientChoice = Console.ReadLine();
            switch (ingredientChoice)
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
        public void VerifyPurchase(Player player)
        {
            int quantityOfIngredient = ingredient.BuyXUnits(ingredient);
            double totalCost = ingredient.CalculateTotalCost(ingredient);

            if (player.CanBuy(totalCost))
            {
                player.inventory.IncreaseInventory(quantityOfIngredient, ingredient);
                player.AdjustMoney(totalCost, player);
            }
            else
            {
                Console.WriteLine("You don't have enough money for that! You only have $" + player.money + " available");
            }
        }
        public bool ContinueShopping(Player player)
        {
            Console.WriteLine("would you like to purchase more products? y/n");
            string continueShopping = Console.ReadLine();
            if (continueShopping == "y" || continueShopping == "yes")
            {
                // StartShopLoop(player);
                return stopShopping = false;
            }
            else if (continueShopping == "n" || continueShopping == "no")
            {
                Console.WriteLine("The shop has closed for the day!");
                return stopShopping = true;
            }
            else
            {
                Console.WriteLine("Please make a proper choice -- yes (y) or no (no)");
                return ContinueShopping(player);
            }
        }
    }
}
