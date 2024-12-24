using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Dtos;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public ActionResult<WeatherDataDto> GetTemperatureByCityName(string city)
        {
            var dto = new WeatherDataDto()
            {
                CityName = city,
                TemperatureCelcius = _weatherService.GetTemperature(city)
            };

            return dto;
        }
    }
}
