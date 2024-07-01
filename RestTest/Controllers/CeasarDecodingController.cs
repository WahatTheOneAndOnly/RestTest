using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    /// <summary>
    /// Controller for performing Ceasar-Cipher encoding.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CeasarDecodingController : ControllerBase
    {

        private readonly ILogger<CeasarDecodingController> _logger;

        public CeasarDecodingController(ILogger<CeasarDecodingController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Decodes a message encoded with the Ceasar-Cipher using a given key.
        /// </summary>
        /// <param name="key">The letter to which A is changed on Encoding.</param>
        /// <param name="message">The message.</param>
        /// <returns>Decoded Message.</returns>
        [HttpGet(Name = "Decode")]
        public string Get(char key, string message)
        {
            return CeasarCipher.Decode(key, message);
        }
    }
}
