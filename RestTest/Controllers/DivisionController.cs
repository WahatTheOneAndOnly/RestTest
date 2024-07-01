using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionController : ControllerBase
    {

        private readonly ILogger<DivisionController> _logger;

        public DivisionController(ILogger<DivisionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Div")]
        public int Get(int a, int b)
        {
            return a / b;
        }
    }
}
