using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class RandomGenerator
    {
        public static Random temperatureGenerator = new Random();
        public static Random boolGenerator = new Random();
        public static Random priceGenerator = new Random();

        public static int TemperatureGenerator()
        {
            return temperatureGenerator.Next(40, 111);
        }
        public static bool BoolGenerator()
        {
            int coinFlip = boolGenerator.Next(1, 3);
            if (coinFlip == 1)
            {
                return true;
            }
            else if (coinFlip == 2)
            {
                return false;
            }
            return false;
        }
        public static double PriceGenerator()
        {
            return priceGenerator.Next(.25, .75);
        }
    }
}
