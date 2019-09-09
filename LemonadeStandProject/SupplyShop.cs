using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class SupplyShop
    {
        public static IngredientsForPurchase ingredient;
        public bool stopShopping;

        public void ShopLoop(Player player)
        {
            while (true) 
            {
                stopShopping = PurchaseMoreIngredients(player);
                if (stopShopping)
                {
                    break;
                }
                WhatToBuy(player);
                VerifyPurchase(player);
            }
            UI.ShowInformation("Time to get the day started!");
        }
        public static IngredientsForPurchase WhatToBuy(Player player)
        {
            UI.ShowInformation("What product would you like to buy? 'lemon' ('l'), 'ice' ('i'), or 'sugar' ('s'). You may also 'close' ('c') to close the shop.");
            string ingredientChoice = Console.ReadLine();
            switch (ingredientChoice)
            {
                case "close":
                case "c":
                    UI.ShowInformation("Skipping the shop\n");
                    UI.DisplayInventory(player);
                    return ingredient;
                case "lemon":
                case "l":
                    UI.ShowInformation("purchasing lemons");
                    UI.DisplayInventory(player);
                    return ingredient = new Lemon();
                case "ice":
                case "i":
                    UI.ShowInformation("purchasing ice cubes");
                    UI.DisplayInventory(player);
                    return ingredient = new IceCubes();
                case "sugar":
                case "s":
                    UI.ShowInformation("purchasing sugar");
                    UI.DisplayInventory(player);
                    return ingredient = new Sugar();
                default:
                    UI.ShowInformation("please make a valid selection - 'lemon' ('l'), 'ice' ('i'), 'sugar' ('s'), or 'close' ('c').");
                    UI.DisplayInventory(player);
                    return WhatToBuy(player);
            }
        }
        public void VerifyPurchase(Player player)
        {
            int quantityOfIngredient = ingredient.BuyXUnits(ingredient);
            double totalCost = ingredient.CalculateTotalCost(ingredient);
            if (player.CanBuy(totalCost))
            {
                player.inventory.IncreaseInventory(quantityOfIngredient, ingredient);
                player.PurchaseIngredients(totalCost);
            }
            else
            {
                UI.ShowInformation($"You don't have enough money for that! You only have ${player.money} available.");
            }
        }
        public bool PurchaseMoreIngredients(Player player)
        {
            UI.ShowInformation($"would you like to purchase more products? 'yes' ('y') or 'no' ('n')");
            string continueShopping = Console.ReadLine();
            if (continueShopping == "y" || continueShopping == "yes")
            {
                return false;
            }
            else if (continueShopping == "n" || continueShopping == "no")
            {
                UI.ShowInformation($"The shop is now closed for the day!");
                return true;
            }
            else
            {
                UI.ShowInformation($"Please make a proper choice -- 'yes' ('y') or 'no' ('n')");
                return PurchaseMoreIngredients(player);
            }
        }
    }
}
