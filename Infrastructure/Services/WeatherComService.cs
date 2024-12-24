using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class WeatherComService : IWeatherService
    {
        public double GetTemperature(string cityName)
        {
            switch (cityName.ToLower())
            {
                case "ankara":
                    return 10;
                case "izmir":
                    return 10;
                case "istanbul":
                    return 11;
                case "tokat":
                    return 13;
                default:
                    return new Random().Next(-10, 36);
            }
        }
    }
}
