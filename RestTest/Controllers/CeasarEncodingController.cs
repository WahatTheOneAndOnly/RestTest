using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    /// <summary>
    /// Controller for performing Ceasar encoding.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CeasarEncodingController : ControllerBase
    {
        private readonly ILogger<CeasarEncodingController> _logger;

        public CeasarEncodingController(ILogger<CeasarEncodingController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Encodes a message with the Ceasar-Cipher using a given key.
        /// </summary>
        /// <param name="key">The letter to which A is changed on Encoding.</param>
        /// <param name="message">The message.</param>
        /// <returns>Encoded Message.</returns>
        [HttpGet(Name = "Encode")]
        public string Get(char key, string message)
        {
            return CeasarCipher.Encode(key, message);
        }
    }
}
