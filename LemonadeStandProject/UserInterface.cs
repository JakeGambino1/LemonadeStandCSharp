using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class UserInterface
    {
        // member variables

        // constructor

        // member methods
        public void InitializeInterface(Player player)
        {
            DisplayMoney(player);
            DisplayInventory(player);
            DisplayCurrentDay();
            DisplayRemainingDays();
            DisplayCurrentWeather();
            DisplayForecast();
            Console.ReadLine();
        }
        public void DisplayMoney(Player player)
        {
            Console.WriteLine(player.name + " has $" + player.money + " remaining");
        }
        public void DisplayInventory(Player player)
        {
            Console.WriteLine("Their remaining inventory:\n" + 
                player.playerInventory.lemons + " lemons\n" + 
                player.playerInventory.ice + " ice\n" + 
                player.playerInventory.sugar + " sugar\n");
        }
        public void DisplayCurrentDay()
        {

        }
        public void DisplayRemainingDays()
        {

        }
        public void DisplayCurrentWeather()
        {

        }
        public void DisplayForecast()
        {

        }
    }
}
