using Microsoft.AspNetCore.Mvc;

namespace RestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CeasarDecodingController : ControllerBase
    {



        private readonly ILogger<CeasarDecodingController> _logger;

        public CeasarDecodingController(ILogger<CeasarDecodingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Decode")]
        public string Get(char chiffre, string message)
        {
            return string.Join("", message.Select(x => CeasarCode.DecodeLetter(chiffre, x)));
        }
    }
}
