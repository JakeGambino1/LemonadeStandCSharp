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
        public bool hasBudgetForLemonade;
        public double money;
        public bool temperaturePreference;
        public bool precipitationPreference;

        // constructor
        public Customer()
        {
        }

        // member methods
        public bool BuyLemonade()
        {
            hasBudgetForLemonade = false;
            if (true)
            {
                return hasBudgetForLemonade = true;
            }
        }
    }
}
