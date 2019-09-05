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
        public string name;
        public double maxPrice;
        public int temperaturePreference;
        public bool precipitationPreference;

        // constructor
        public Customer(string name, double maxPrice, int temperaturePreference)
        {
            this.name = name;
            this.maxPrice = maxPrice;
            this.temperaturePreference = temperaturePreference;
        }
        // member methods
        public bool IsLemonadeInBudget(Player player)
        {
            if (maxPrice >= player.recipe.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsTemperatureRight(Weather weather)
        {
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
            if (player.cupsOfLemonade == 0)
            {
                player.MakeLemonadePitcher(player.recipe, player.inventory);
            }
            else if (LemonadePurchaseDecision(player, weather) && player.cupsOfLemonade > 0) { 
                player.dailyProfit += player.recipe.price;
                Console.WriteLine(name + " has purchased your lemonade for $" + player.recipe.price + ".");
                player.cupsOfLemonade -= 1;
            }
            else if (LemonadePurchaseDecision(player, weather) && player.cupsOfLemonade <=0)
            {
                Console.WriteLine("Customer wanted to buy product, but you ran out.");
            }
        }
    }
}
