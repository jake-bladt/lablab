using System;
using System.Collections.Generic;
using System.Linq;

using CommandAPI.Dtos;
using CommandAPI.Models;

namespace CommandAPI.Data 
{
    public class PostgreSqlCommandApiRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;

        public PostgreSqlCommandApiRepo(CommandContext context) 
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(null == cmd) throw new ArgumentNullException(nameof(cmd));
            _context.CommandItems.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(null == cmd) throw new ArgumentNullException(nameof(cmd));
            _context.CommandItems.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int Id)
        {
            return _context.CommandItems.FirstOrDefault(i => i.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            // No code required
        }
    }
}