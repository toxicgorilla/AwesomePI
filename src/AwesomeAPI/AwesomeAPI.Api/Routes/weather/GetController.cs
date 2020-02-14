using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeAPI.Api.Routes.weather
{
    [ApiController]
    public class GetController : ControllerBase
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly Random randomNumberGenerator;

        static GetController()
        {
            randomNumberGenerator = new Random();
        }

        [HttpGet]
        [Route("/weather")]
        public IEnumerable<WeatherForecastModel> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = randomNumberGenerator.Next(-20, 55),
                Summary = Summaries[randomNumberGenerator.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
