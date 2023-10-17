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

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var value = Assembly.GetExecutingAssembly().GetName().Version;

            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdAsync(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] string id)
        {
            return Ok();
        }

        [HttpPatch]
        public async Task<IActionResult> PathAsync()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            return Ok();
        }
    }
}