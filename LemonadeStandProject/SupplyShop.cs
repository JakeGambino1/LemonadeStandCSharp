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
        public double pricePerLemon;
        public double pricePerTwentyFiveIceCubes;
        public double pricePerSugarCup;
        public string supplyPurchase;

        // constructor
        public SupplyShop()
        {
            pricePerLemon = 0.75;
            pricePerTwentyFiveIceCubes = .50;
            pricePerSugarCup = .30;
        }

        // member methods
        public void IniitializeShop()
        {
            
        }
        public string WhatToBuy(string supplyPurchase)
        {
            Console.WriteLine("What product would you like to buy?");
            supplyPurchase = Console.ReadLine();
            switch (supplyPurchase)
            {
                case "lemon":
                case "l":
                    Console.WriteLine("purchasing " + supplyPurchase);
                    return supplyPurchase = "lemon";
                case "ice":
                case "i":
                    Console.WriteLine("purchasing " + supplyPurchase);
                    return supplyPurchase = "ice";
                case "sugar":
                case "s":
                    Console.WriteLine("purchasing " + supplyPurchase);
                    return supplyPurchase = "sugar";
                default:
                    Console.WriteLine("please make a valid selection - lemon (l), ice (i), or sugar (s)");
                    return WhatToBuy(supplyPurchase);
            }
        }
    }
}
