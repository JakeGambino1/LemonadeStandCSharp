using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class UserInterface
    {
        public static void InitializeInterface(Player player, List<Weather> weatherList)
        {
            DisplayRules(player);
            DisplayInventory(player);
            DisplayCurrentWeather(weatherList);
            DisplayForecast(weatherList);
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine("Their remaining inventory:\n" + 
                player.inventory.lemons + " lemons\n" + 
                player.inventory.ice + " ice\n" + 
                player.inventory.sugar + " sugar\n" +
                "$" + player.money);
        }
        public static void DisplayCurrentWeather(List<Weather> weatherList)
        {
            Console.WriteLine("The temperature today is " + weatherList.First().temperature + " degrees Fahrenheit.");
        }
        public static void DisplayForecast(List<Weather> weatherList)
        {
            Console.WriteLine("The forecast for tomorrow is " + weatherList[1].temperature + " degrees Fahrenheit.");
        }
        public static void DisplayProfit(Player player)
        {
            Console.WriteLine("Your daily profit of $" + player.dailyProfit + " has been added to your wallet. Your expenses for today was $" + player.dailyCostOfGoodsSold + ". Your net profit for today was $" + (player.dailyProfit - player.dailyCostOfGoodsSold) + ".");
        }
        public static void DisplayRules(Player player)
        {
            Console.WriteLine("You are an aspiring Lemonade Stand Tycoon. The Jeff Bezos of Lemonade Sales. But you need to work your way up.\n\n Let's start with the basics:\n\nYou start with $" + player.money + ". You need to purchase ice, sugar, and lemons. Afterwards, create a recipe for your lemonade. Colonel Sanders had a special recipe for his chicken. Get that magic number for your lemonade.\n\nThings that affect sales:\n\nCustomers have purchase preferences including temperature, precipitation, and their maximum budget for lemonade.\n\n");
        }
        public static void DisplayDayCount()
        {
            Console.WriteLine("Welcome to Day " + Game.dayCount);
        }
        public static void DisplayCurrentRecipe(Recipe recipe)
        {
            Console.WriteLine("Your current lemonade mixture is " + recipe.numberOfLemons + " lemons, " + recipe.amountOfIceCubes + " ice cubes, and " + recipe.amountOfSugar + " cups of sugar. The recommended/starting sale price is $" + recipe.price + ".");
        }
    }
}
