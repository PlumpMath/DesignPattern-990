using System;

namespace CommandPattern.Commands
{
    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("Couldn't find command: " + Name);
        }        
    }
}