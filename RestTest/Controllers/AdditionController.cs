using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    /// <summary>
    /// Controller for performing addition operation.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AdditionController : ControllerBase
    {

        private readonly ILogger<AdditionController> _logger;

        public AdditionController(ILogger<AdditionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Adds two integers from each other.
        /// </summary>
        /// <param name="a">The first integer for the addition.</param>
        /// <param name="b">The second integer for the addition.</param>
        /// <returns>The sum of the two integers.</returns>
        [HttpGet(Name = "AddGet")]
        public int Get(int a, int b)
        {
            return a + b;
        }
    }
}
