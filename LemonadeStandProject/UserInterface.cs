using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class UserInterface
    {
        // member variables

        // constructor

        // member methods
        public void InitializeInterface()
        {
            DisplayMoney();
            DisplayInventory();
            DisplayCurrentDay();
            DisplayRemainingDays();
            DisplayCurrentWeather();
            DisplayForecast();
        }
        public void DisplayMoney()
        {
            Console.WriteLine("player has $" + money + " remaining");
        }
        public void DisplayInventory()
        {
            Console.WriteLine();
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
