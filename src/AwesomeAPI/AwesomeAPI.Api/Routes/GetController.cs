using Microsoft.AspNetCore.Mvc;

namespace AwesomeAPI.Api.Routes
{
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Get()
        {
            var result = new ContentResult
            {
                Content = "LOOOOOL HELLO \"JACK\""
            };

            return result;
        }
    }
}
