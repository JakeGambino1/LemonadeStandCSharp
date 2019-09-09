using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class UI
    {
        public static void InitializeInterface(Player player, List<Day> day, int dayCount)
        {
            DisplayRules(player);
            DisplayInventory(player);
            DisplayCurrentWeather(day[dayCount]);
            DisplayForecast(day[dayCount+1]);
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine("Their remaining inventory:\n" + 
                player.inventory.lemons + " lemons\n" + 
                player.inventory.ice + " ice\n" + 
                player.inventory.sugar + " sugar\n" +
                "$" + player.money);
        }
        public static void DisplayCurrentWeather(Day day)
        {
            Console.WriteLine($"The temperature today is {day.weather.temperature} degrees Fahrenheit.");
        }
        public static void DisplayForecast(Day day)
        {
            Console.WriteLine($"The forecast for tomorrow is {day.weather.temperature} degrees Fahrenheit.");
        }
        public static void DisplayProfit(Player player)
        {
            Console.WriteLine($"Your daily profit of ${player.dailyProfit} has been added to your wallet. Your expenses for today was ${player.dailyCostOfGoodsSold}. Your net profit for today was ${player.dailyProfit - player.dailyCostOfGoodsSold}.");
        }
        public static void DisplayRules(Player player)
        {
            Console.WriteLine($"You are an aspiring Lemonade Stand Tycoon. \n You have been called the Jeff Bezos of Lemonade Sales. But you need to put in the work to become the potential.\n\n Let's start with the basics:\n\nYou are starting from humble beginnings with only ${player.money} in the bank. You need to purchase ice, sugar, and lemons. Afterwards, create a recipe for your lemonade. Colonel Sanders had a special recipe for his chicken. Get that magic number for your lemonade.\n\nThings that affect sales:\n\nCustomers have purchase preferences including temperature, precipitation, and their maximum budget for lemonade.\n\n");
        }
        
        public static int GetUserNumberInput(string questionToAsk)
        {
            Console.WriteLine(questionToAsk);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static void ShowInformation(string str)
        {
            Console.WriteLine(str);
        }

        public static void GameSummary(Player player, int dayCount, int gameLength)
        {
            if (dayCount == gameLength)
            {
                ShowInformation($"Thanks for playing. You ended Day {dayCount} with {player.totalDailyProfits} in profit and ${player.money} in the bank!");
                Console.ReadLine();
            }
            Console.WriteLine(dayCount);
        }

    }
}
