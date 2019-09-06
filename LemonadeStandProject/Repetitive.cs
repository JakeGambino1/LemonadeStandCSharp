using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class Repetitive
    {
        public static void MakeCustomerList(int howManyTimes, List<Customer> customers)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                customers.Add(new Customer(RandomGenerator.PriceGenerator(), RandomGenerator.IntegerGenerator()));
            }
        }
        public static void MakeWeatherList(int howManyTimes, List<Weather> weatherList)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                weatherList.Add(new Weather(Game.dayCount, RandomGenerator.BoolGenerator(), RandomGenerator.IntegerGenerator()));
            }
        }
    }
}
