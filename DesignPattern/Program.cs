using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            string carName = args[0];

            //Caller knows about the concrete factory type here
            //Meaning the caller knows which factory type to be called 
            Autofactory factory = new Autofactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();

            Console.ReadKey();
        }
    }
}
