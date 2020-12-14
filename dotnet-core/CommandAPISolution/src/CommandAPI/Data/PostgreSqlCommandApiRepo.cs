using System.Collections.Generic;
using System.Linq;

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
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}