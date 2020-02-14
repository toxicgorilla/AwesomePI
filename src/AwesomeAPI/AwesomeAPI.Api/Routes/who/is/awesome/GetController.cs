using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeAPI.Api.Routes.who.@is.awesome
{
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet]
        [Route("/who/is/awesome")]
        public List<string> Get()
        {
            var people = new List<string>
            {
                "STEVE",
                "DAN",
                "JACK"
            };

            return people;
        }
    }
}
