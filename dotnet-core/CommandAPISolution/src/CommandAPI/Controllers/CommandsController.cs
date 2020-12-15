using System.Collections.Generic;

using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;

using CommandAPI.Data;
using CommandAPI.Dtos;
using CommandAPI.Models;

namespace CommandAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {
        private readonly ICommandAPIRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommandAPIRepo repo, IMapper mapper) 
        {
            _repository = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands() 
        {
            var commands = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }

        [HttpGet("{id}", Name="GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);
            if(null == command) return NotFound();
            return Ok(_mapper.Map<CommandReadDto>(command));
        }

        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto createDto)
        {
            var cmd = _mapper.Map<Command>(createDto);
            _repository.CreateCommand(cmd);
            _repository.SaveChanges();

            var ret = _mapper.Map<CommandReadDto>(cmd);
            return CreatedAtRoute(nameof(GetCommandById), new { Id = ret.Id }, ret);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDto updateDto)
        {
            var cmdFromRepo = _repository.GetCommandById(id);
            if(null == cmdFromRepo) return NotFound();
            _mapper.Map(updateDto, cmdFromRepo);
            _repository.UpdateCommand(cmdFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<CommandUpdateDto> patchDoc)
        {
            var cmdFromRepo = _repository.GetCommandById(id);
            if(null == cmdFromRepo) return NotFound();
            var cmdToPatch = _mapper.Map<CommandUpdateDto>(cmdFromRepo);
            patchDoc.ApplyTo(cmdToPatch, ModelState);

            if(!TryValidateModel(cmdToPatch)) return ValidationProblem(ModelState);
            _mapper.Map(cmdToPatch, cmdFromRepo);
            _repository.UpdateCommand(cmdFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult CommandDelete(int id)
        {
            var cmdFromRepo = _repository.GetCommandById(id);
            if(null == cmdFromRepo) return NotFound();
            _repository.DeleteCommand(cmdFromRepo)            ;
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
