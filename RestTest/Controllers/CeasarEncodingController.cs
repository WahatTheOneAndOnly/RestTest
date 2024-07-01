using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CeasarEncodingController : ControllerBase
    {
        private readonly ILogger<CeasarEncodingController> _logger;

        public CeasarEncodingController(ILogger<CeasarEncodingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Encode")]
        public string Get(char chiffre, string message)
        {
            return string.Join("", message.Select(x => CeasarCode.EncodeLetter(chiffre, x)));
        }
    }
}
