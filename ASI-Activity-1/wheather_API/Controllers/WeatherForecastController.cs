using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace wheather_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        int Zipcode = 1;
        string countryCode = "pt";

        private const string API_KEY = "fff3f50648f18ab69e1e18fd46225dc0";
        private const string CurrentUrl = "http://api.openweathermap.org/data/2.5/weather?" +
    "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        //private const string CurrentTest = "http://api.openweathermap.org/data/2.5/weather?zip" + Zipcode + "pt&AAPID=" + API_KEY;
    

[HttpGet]
        /*
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        */

        public WeatherForecast Get()
        {
            var cidade = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 22,
                Summary = "Sunny"
            };

            return cidade;
        }

        [Route("~/api/test")]
        [HttpPost]
        public WeatherForecast Test(int zipCode)
        {
            var CurrentTest= "http://api.openweathermap.org/data/2.5/weather?zip=" + zipCode + "pt&AAPID=" + API_KEY;

            Console.WriteLine(CurrentTest);

            var cidade = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 21,
                Summary = "Sunny"
            };

            return cidade;
        }
        
    }
}
