using Microsoft.AspNetCore.Mvc;

namespace AwesomeAPI.Api.Routes.ping
{
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet]
        [Route("/ping")]
        public ContentResult Get()
        {
            var result = new ContentResult()
            {
                Content = "pong"
            };

            return result;
        }
    }
}
