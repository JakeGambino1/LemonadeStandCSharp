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

        }

        // member methods
        public void ShopLoop(Player player)
        {
            while (true) 
            {
                stopShopping = PurchaseMoreIngredients(player);
                if (stopShopping)
                {
                    break;
                }
                WhatToBuy();
                VerifyPurchase(player);
            }
            Console.WriteLine("Time to get the day started!");
        }
        public static IngredientsForPurchase WhatToBuy()
        {
            Console.WriteLine("What product would you like to buy? 'lemon' ('l'), 'ice' ('i'), or 'sugar' ('s'). You may also 'close' ('c') to close the shop.");
            string ingredientChoice = Console.ReadLine();
            switch (ingredientChoice)
            {
                case "close":
                case "c":
                    Console.WriteLine("Skipping the shop");
                    return ingredient;
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
                    Console.WriteLine("please make a valid selection - 'lemon' ('l'), 'ice' ('i'), 'sugar' ('s'), or 'close' ('c').");
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
        public bool PurchaseMoreIngredients(Player player)
        {
            Console.WriteLine("would you like to purchase more products? 'yes' ('y') or 'no' ('n')");
            string continueShopping = Console.ReadLine();
            if (continueShopping == "y" || continueShopping == "yes")
            {
                return false;
            }
            else if (continueShopping == "n" || continueShopping == "no")
            {
                Console.WriteLine("The shop has closed for the day!");
                return true;
            }
            else
            {
                Console.WriteLine("Please make a proper choice -- 'yes' ('y') or 'no' ('n')");
                return PurchaseMoreIngredients(player);
            }
        }
    }
}
