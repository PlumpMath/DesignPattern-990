using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Autos
{
    public class MiniCooper334Xl : IAutomobile
    {
        public void TurnOn()
        {
            Console.WriteLine("MiniCooper334Xl turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("MiniCooper334Xl turn off");
        }

        public string Name
        {
            get;
            private set;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
