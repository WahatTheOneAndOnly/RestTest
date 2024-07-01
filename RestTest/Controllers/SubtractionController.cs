using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    /// <summary>
    /// Controller for performing subtraction operation.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class SubtractionController : ControllerBase
    {

        private readonly ILogger<SubtractionController> _logger;

        public SubtractionController(ILogger<SubtractionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Subtracts two integers from each other.
        /// </summary>
        /// <param name="a">The first integer for subtraction.</param>
        /// <param name="b">The second integer for subtraction.</param>
        /// <returns>The difference of the two integers.</returns>
        [HttpGet(Name = "Sub")]
        public int Get(int a, int b)
        {
            return a - b;
        }
    }
}
