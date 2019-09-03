using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Customer
    {
        // member variables
        public int maxPrice;
        public bool willBuy;

        // constructor
        public Customer()
        {
            willBuy = false;
        }

        // member methods
        public bool BuyLemonade()
        {
            willBuy = false;
            if (true)
            {
                return willBuy = true;
            }
        }
    }
}
