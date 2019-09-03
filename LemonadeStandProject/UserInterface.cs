using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class UserInterface
    {
        // member variables

        // constructor

        // member methods
        public static void InitializeInterface(Player player)
        {
            DisplayMoney(player);
            DisplayInventory(player);
            DisplayCurrentDay();
            DisplayRemainingDays();
            DisplayCurrentWeather();
            DisplayForecast();
        }
        public static void DisplayMoney(Player player)
        {
            Console.WriteLine(player.name + " has $" + player.money + " remaining");
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine("Their remaining inventory:\n" + 
                player.playerOneInventory.lemons + " lemons\n" + 
                player.playerOneInventory.ice + " ice\n" + 
                player.playerOneInventory.sugar + " sugar\n");
        }
        public static void DisplayCurrentDay()
        {

        }
        public static void DisplayRemainingDays()
        {

        }
        public static void DisplayCurrentWeather()
        {

        }
        public static void DisplayForecast()
        {

        }
    }
}
