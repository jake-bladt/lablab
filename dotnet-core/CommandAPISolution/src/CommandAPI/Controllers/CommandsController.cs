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

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands() 
        {
            var commands = _repository.GetAllCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);
            if(null == command) return NotFound();
            return Ok(command);
        }
    }
}
