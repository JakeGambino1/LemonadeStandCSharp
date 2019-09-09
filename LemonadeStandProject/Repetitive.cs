using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class Repetitive
    {
        public static List<Day> InstantiateDaysForGameDuration(int gameLength, List<Day> day)
        {
            for (int i = 0; i < gameLength; i++)
            {
                day.Add(new Day());
            }
            return day;
        }
        public static List<Customer> MakeCustomer(int howManyTimes, List<Customer> customers)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                //customers.Add(new Customer(RandomGenerator.PriceGenerator(), RandomGenerator.IntegerGenerator()));
                customers.Add(new Customer(RandomGenerator.PriceGenerator(), RandomGenerator.IntegerGenerator()));
            }
            return customers;
        }
        public static void MakeWeatherList(int howManyTimes, List<Weather> weatherList)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                weatherList.Add(new Weather(RandomGenerator.BoolGenerator(), RandomGenerator.IntegerGenerator()));
            }
        }
    }
}
