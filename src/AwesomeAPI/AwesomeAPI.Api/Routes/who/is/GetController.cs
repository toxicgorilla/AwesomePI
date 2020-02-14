using Microsoft.AspNetCore.Mvc;

namespace AwesomeAPI.Api.Routes.who.@is
{
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet]
        [Route("/who/is")]
        public ContentResult Get()
        {
            var result = new ContentResult()
            {
                Content = "who is what?"
            };

            return result;
        }
    }
}
