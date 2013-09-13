using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Autos
{
    public class AudiTTS: IAutomobile
    {
        public void TurnOn()
        {
            Console.WriteLine("Audi turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Audi turn off");
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
