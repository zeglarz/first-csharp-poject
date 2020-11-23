using System.Collections.Generic;
using Commander.Models;

namespace Commander.DataTypes
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}