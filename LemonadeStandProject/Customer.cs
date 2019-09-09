using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Customer
    {
        public double maxPrice;
        public int temperaturePreference;
        public bool precipitationPreference;

        public Customer()
        {
            maxPrice = RandomGenerator.PriceGenerator();
            temperaturePreference = RandomGenerator.IntegerGenerator();
            precipitationPreference = RandomGenerator.BoolGenerator();
        }

        public bool IsLemonadeInBudget(Player player)
        {
            if (maxPrice >= player.recipe.price)
            {
                return true;
            }
            else
            {
                UI.ShowInformation($"Customer can't afford the lemonade. Their max price was {this.maxPrice}");
                return false;
            }
        }
        public bool IsTemperatureRight(Weather weather)
        {
            if (temperaturePreference >= weather.temperature - 15 && temperaturePreference <= weather.temperature + 15)
            { 
                return true;
            }
            UI.ShowInformation("Customer is not in the mood for lemonade in this weather.\n");
            return false;
        } 
        public bool IsPrecipitationRight()
        {
            if (precipitationPreference)
            {
                return true;
            }
            UI.ShowInformation("Customer don't want shit in this weather.");
            return false;
        }
        public bool LemonadePurchaseDecision(Player player, Weather weather)
        { 
            if (IsLemonadeInBudget(player) && IsTemperatureRight(weather) && IsPrecipitationRight())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void BuyLemonade(Player player, Day day)
        {
            if (player.cupsOfLemonade == 0)
            {
                player.MakeLemonadePitcher(player.recipe, player.inventory);
            }
            else if (LemonadePurchaseDecision(player, day.weather) && player.cupsOfLemonade > 0) { 
                player.dailyProfit += player.recipe.price;
                UI.ShowInformation($"A customer has purchased your lemonade for ${player.recipe.price}.");
                player.cupsOfLemonade -= 1;
            }
            else if (LemonadePurchaseDecision(player, day.weather) && player.cupsOfLemonade <=0)
            {
                UI.ShowInformation($"Customer wanted to buy product, but you ran out.");
            }

        }
    }
}
