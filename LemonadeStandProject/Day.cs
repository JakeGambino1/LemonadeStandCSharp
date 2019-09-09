using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
        // member variables
        public Weather weather;
        public List<Customer> customers = new List<Customer>();

        // constructor
        public Day()
        {
            weather = new Weather(RandomGenerator.BoolGenerator(), RandomGenerator.IntegerGenerator());
            customers = new List<Customer>(MakeCustomersForDay(weather.temperature));
        }
        public List<Customer> MakeCustomersForDay(int temperature)
        {
            if (temperature <= 50)
            {
                return Repetitive.MakeCustomer(15, customers);
            }
            else if (temperature > 50 && temperature <= 80)
            {
                return Repetitive.MakeCustomer(25, customers);
            }
            else if (temperature > 80 && temperature <= 100)
            {
                return Repetitive.MakeCustomer(50, customers);
            }
            else if (temperature > 100)
            {
                return Repetitive.MakeCustomer(100, customers);
            }
            return MakeCustomersForDay(temperature);
        }
    }
}
