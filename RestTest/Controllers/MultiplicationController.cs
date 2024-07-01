using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplicationController : ControllerBase
    {

        private readonly ILogger<MultiplicationController> _logger;

        public MultiplicationController(ILogger<MultiplicationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Mul")]
        public int Get(int a, int b)
        {
            return a * b;
        }
    }
}
