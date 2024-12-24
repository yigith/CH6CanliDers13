using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MGMService : IWeatherService
    {
        public double GetTemperature(string cityName)
        {
            cityName = cityName.ToLower();

            if (cityName == "ankara")
                return 9.6;
            if (cityName == "izmir")
                return 10.1;
            if (cityName == "istanbul")
                return 11.4;
            if (cityName == "tokat")
                return 13.1;

            return new Random().Next(-7, 28);
        }
    }
}
