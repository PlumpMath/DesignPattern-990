using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Commands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableCommands = GetAvailableCommands();
            if(args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);
            
            //Removed the null check because introduced the logic of returning the NullCommand object if the command is invalid
            //if (command != null)
            
            command.Execute();

        }

        private static void PrintUsage(object availableCommands)
        {
            Console.WriteLine("Usage: Logging Demo CommandName Arguments");
            Console.WriteLine("Commands");

            foreach (var command in (IEnumerable<ICommandFactory>) availableCommands)
            {
                Console.WriteLine(" {0}", command.Description);
            }
        }


        private static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
                       {
                           new CreateOrderCommand(),
                           new UpdateQuantityCommand(),
                           new ShipOrderCommand(), 
                       };
        }
    }
}

