using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Weather
    {
        public int day;
        public bool precipitation;
        public int temperature;

        public Weather(int day, bool precipitation, int temperature)
        {
            this.day = day;
            this.precipitation = IsRaining();
            this.temperature = SetTemperature();
        }

        public int SetTemperature()
        {
            return RandomGenerator.IntegerGenerator();
        }
        public bool IsRaining()
        {
            return RandomGenerator.BoolGenerator();
        }
    }
}
