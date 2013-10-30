using System;

namespace BridgePattern.Strutcture
{
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    internal class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}