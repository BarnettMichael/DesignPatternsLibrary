using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands) => this.availableCommands = availableCommands;

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];

            var command = FindRequestedCommand(requestedCommandName);

            return command == null ? new NotFoundCommand() { Name = requestedCommandName }
                                   : command.MakeCommand(args);
        }

        ICommandFactory FindRequestedCommand(string commandName)
        {
            return availableCommands.FirstOrDefault(c => c.CommandName == commandName);
        }
    }
}
