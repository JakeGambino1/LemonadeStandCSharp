using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Weather
    {
        // member variables
        public bool precipitation;
        public int temperature;

        // constructor
        public Weather()
        {
        }
        // member methods
        public int AdjustTemperature()
        {
            return temperature = 65;
        }
        public bool IsRaining()
        {
            return precipitation = true;
        }
    }
}
