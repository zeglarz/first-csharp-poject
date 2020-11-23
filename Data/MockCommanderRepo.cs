using System.Collections.Generic;
using Commander.DataTypes;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "knife and chopping board" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Boil water & prepare a teabag of your prefering", Platform = "Kettle & cup" },
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil woter", Platform = "Kettle & Pan" };
        }
    }
}