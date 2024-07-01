using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    /// <summary>
    /// Controller for performing division operation.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class DivisionController : ControllerBase
    {

        private readonly ILogger<DivisionController> _logger;

        public DivisionController(ILogger<DivisionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Divides two integers from each other.
        /// </summary>
        /// <param name="a">The first integer for the division.</param>
        /// <param name="b">The second integer for the division.</param>
        /// <returns>The division of the two integers without rest.</returns>
        [HttpGet(Name = "Div")]
        public IActionResult Get(int a, int b)
        {
            // Example validation check: both values must be positive
            if (b == 0)
            {
                return BadRequest("Second value can not be 0.");
            }
            int result = a / b;
            return Ok(result);
        }
    }
}
