﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Customer
    {
        // member variables
        public double maxPrice;
        public bool hasBudgetForLemonade;
        public bool temperaturePreference;
        public bool precipitationPreference;
        public string name;

        // constructor
        public Customer()
        {
            name = "First Customer";
            maxPrice = 0.30;
        }
        // member methods
        public bool IsLemonadeInBudget(Player player)
        {
            hasBudgetForLemonade = true;
            if (maxPrice >= player.recipe.price)
            {
                Console.WriteLine(name + " has enough money to buy a cup of lemonade.");
                return hasBudgetForLemonade = true;
            }
            else
            { 
                return false;
            }
        }
        public bool IsTemperatureRight()
        {
            temperaturePreference = true;
            if (temperaturePreference)
            {
                return true;
            }
            return false;
        }
        public bool IsPrecipitationRight()
        {
            precipitationPreference = true;
            if (precipitationPreference)
            {
                return true;
            }
            return false;
        }
        public bool LemonadePurchaseDecision(Player player)
        {
            if (IsLemonadeInBudget(player) && IsTemperatureRight() && IsPrecipitationRight())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void BuyLemonade(Player player)
        {
            if (LemonadePurchaseDecision(player)) { 
                player.money += player.recipe.price;
                Console.WriteLine(name + " has purchased your lemonade for $" + player.recipe.price + ". " + player.name + " now has $" + player.money + " available." );
                Console.ReadLine();
            }
        }
    }
}
