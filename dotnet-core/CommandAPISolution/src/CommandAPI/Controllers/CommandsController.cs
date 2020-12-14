using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {
        private readonly ICommandAPIRepo _repository;

        public CommandsController(ICommandAPIRepo repo) 
        {
            _repository = repo;
        }

        public ActionResult<IEnumerable<Command>> Get() 
        {
            var commands = _repository.GetAllCommands();
            return Ok(commands);
        }
    }
}
