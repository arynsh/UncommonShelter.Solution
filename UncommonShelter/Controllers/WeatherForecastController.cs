using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UncommonShelter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AnimalController> _logger;

        public AnimalController(ILogger<AnimalController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Animal
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
