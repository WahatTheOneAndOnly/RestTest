using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubtractionController : ControllerBase
    {

        private readonly ILogger<SubtractionController> _logger;

        public SubtractionController(ILogger<SubtractionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Sub")]
        public int Get(int a, int b)
        {
            return a - b;
        }
    }
}
