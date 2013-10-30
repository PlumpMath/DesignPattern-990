using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Autos
{
    public class BMW335Xi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("BMW turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("BMW turn off");
        }
    }
}
