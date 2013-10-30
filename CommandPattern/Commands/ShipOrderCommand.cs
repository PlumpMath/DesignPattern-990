using System;

namespace CommandPattern.Commands
{
    public class ShipOrderCommand :ICommand, ICommandFactory
    {
        public string CommandName { get { return "ShipOrderCommand"; } }
        public string Description { get { return "ShipOrderCommand Number"; } }
        public ICommand MakeCommand(string[] arguments)
        {
            return new ShipOrderCommand
                       {

                       };
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}