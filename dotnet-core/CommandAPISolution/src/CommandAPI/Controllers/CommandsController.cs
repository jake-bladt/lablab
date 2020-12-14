using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {
        public ActionResult<IEnumerable<string>> Get() 
        {
            return new string[] {"fnord", "beetlebrox", "was", "here"};
        }
    }
}
