using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Autos
{
    public class BMW335Xi : IAutomobile
    {
        //Let's say you don't want to call in the SetName then the workaround is to have parameterized constructor


        public BMW335Xi(string _name)
        {
            Name = _name;
        }

        public void TurnOn()
        {
            Console.WriteLine("BMW turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("BMW turn off");
        }

        public string Name
        {
            get;
            private set;
        }

        public void SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
        }
    }
}
