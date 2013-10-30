using System.Collections.Generic;
using System.Linq;
using CommandPattern.Commands;

namespace CommandPattern
{
    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> _availableCommands; 

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this._availableCommands = availableCommands;
        }

        public ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];
            var commandName = FindRequestedCommandName(requestedCommandName);

            //Instead of returning null in case the command is not available we return 
            // a special object which helps the clients to operate correctly
            if (null == commandName)
                return new NotFoundCommand{Name = requestedCommandName};
            
            return commandName.MakeCommand(args);
        }

        private ICommandFactory FindRequestedCommandName(string requestedCommandName)
        {
            return _availableCommands.FirstOrDefault(cmd => cmd.CommandName == requestedCommandName);
        }
    }
}