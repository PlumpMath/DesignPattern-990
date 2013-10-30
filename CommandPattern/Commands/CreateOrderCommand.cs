using System;

namespace CommandPattern.Commands
{
    internal class CreateOrderCommand : ICommand,  ICommandFactory
    {
        public string CommandName { get; private set; }
        public string Description { get; private set; }
        public ICommand MakeCommand(string[] arguments)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}