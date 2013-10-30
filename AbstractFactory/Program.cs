using System;
using System.Reflection;
using FactoryMethodPattern;

namespace DesignPattern
{
    public class Program
    {
        static void Main()
        {
            IAutoFactory autoFactory = LoadFactory();

            //Caller just delegates the pobject creation to a specific factory
            //which takes the a configuration based approach to decide which factory to return and 
            //which in turn decides which concrete class to return
            //Here the factory is known but the creation is centralised to specific factory
            //Also more customized objects can be created.
            IAutomobile car = autoFactory.CreateSportsCar();

            car.TurnOn();
            car.TurnOff();
                        
            Console.ReadKey();
        }

        private static IAutoFactory LoadFactory()
        {
            string factoryName = Settings1.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;

        }
    }
}
