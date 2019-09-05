using System;
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
        public bool BudgetForLemonade;
        public int temperaturePreference;
        public bool precipitationPreference;
        public string name;

        // constructor
        public Customer()
        {
            name = "First Customer";
            maxPrice = 0.30;
            temperaturePreference = 60;
        }
        // member methods
        public bool IsLemonadeInBudget(Player player)
        {
            BudgetForLemonade = true;
            if (maxPrice >= player.recipe.price)
            {
                return BudgetForLemonade = true;
            }
            else
            {
                return false;
            }
        }
        public bool IsTemperatureRight(Weather weather)
        {
            weather.temperature = 60;
            if (temperaturePreference >= weather.temperature - 7 && temperaturePreference <= weather.temperature + 7)
            { 
                return true;
            }
            Console.WriteLine(name + " is not in the mood for lemonade in this weather.\n");
            return false;
        } 
        public bool IsPrecipitationRight(Weather weather)
        {
            precipitationPreference = true;
            if (precipitationPreference)
            {
                return true;
            }
            return false;
        }
        public bool LemonadePurchaseDecision(Player player, Weather weather)
        { 
            if (IsLemonadeInBudget(player) && IsTemperatureRight(weather) && IsPrecipitationRight(weather))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void BuyLemonade(Player player, Weather weather)
        {
            if (LemonadePurchaseDecision(player, weather) && player.cupsOfLemonade > 0) { 
                player.dailyProfit += player.recipe.price;
                Console.WriteLine(name + " has purchased your lemonade for $" + player.recipe.price + ".");
                player.cupsOfLemonade -= 1;
            }
            else if (LemonadePurchaseDecision(player, weather) && player.cupsOfLemonade <=0)
            {
                Console.WriteLine("Customer wanted to buy product, but you ran out of product.");
            }
        }
    }
}
