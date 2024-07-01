using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    /// <summary>
    /// Controller for performing multiplication operation.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class MultiplicationController : ControllerBase
    {

        private readonly ILogger<MultiplicationController> _logger;

        public MultiplicationController(ILogger<MultiplicationController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        /// <param name="a">The first integer to multiply.</param>
        /// <param name="b">The second integer to multiply.</param>
        /// <returns>The product of the two integers.</returns>
        [HttpGet(Name = "Mul")]
        public int Get(int a, int b)
        {
            return a * b;
        }
    }
}
