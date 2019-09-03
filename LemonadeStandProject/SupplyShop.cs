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
        public static IngredientsForPurchase ingredientSelected;


        // constructor
        public SupplyShop()
        {
        }

        // member methods
        public void InitializeShop(Player player)
        {
            WhatToBuy();
            int amountOfIngredient = ingredientSelected.BuyXUnits(ingredientSelected);
            double totalCost = ingredientSelected.CalculateTotalCost(ingredientSelected);
            player.playerOneInventory.IncreaseInventory(amountOfIngredient, ingredientSelected);
            player.AdjustMoney(totalCost, player);
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
                    return ingredientSelected = new Lemon();
                case "ice":
                case "i":
                    Console.WriteLine("purchasing ice cubes");
                    return ingredientSelected = new IceCubes();
                case "sugar":
                case "s":
                    Console.WriteLine("purchasing sugar");
                    return ingredientSelected = new Sugar();
                default:
                    Console.WriteLine("please make a valid selection - lemon (l), ice (i), or sugar (s)");
                    return WhatToBuy();
            }
        }
    }
}
