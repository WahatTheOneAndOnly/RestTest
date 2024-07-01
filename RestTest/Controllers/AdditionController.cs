using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdditionController : ControllerBase
    {

        private readonly ILogger<AdditionController> _logger;

        public AdditionController(ILogger<AdditionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "AddGet")]
        public int Get(int a, int b)
        {
            return a + b;
        }
    }
}
