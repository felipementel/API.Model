using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Model.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> GetAsync()
        {
            var value = Assembly.GetExecutingAssembly().GetName().Version;

            return Ok(value);
        }
    }
}