using Microsoft.AspNetCore.Mvc;

namespace AwesomeAPI.Api.Routes.who
{
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet]
        [Route("/who")]
        public ContentResult Get()
        {
            var result = new ContentResult()
            {
                Content = "who what?"
            };

            return result;
        }
    }
}
