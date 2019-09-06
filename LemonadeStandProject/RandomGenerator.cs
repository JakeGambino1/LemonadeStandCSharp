using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public static class RandomGenerator
    {
        public static Random integerGenerator = new Random();
        public static Random boolGenerator = new Random();
        public static Random priceGenerator = new Random();
        public static double decimalNumber;

        public static int IntegerGenerator()
        {
            return integerGenerator.Next(40, 111);
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
            decimalNumber = Convert.ToDouble(Convert.ToDecimal(integerGenerator.Next(20, 100)) / 100);
            return decimalNumber;  
        }
    }
}
