using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sanwich Maker is the Director here and the director is called by the client. 
            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich = sandwichMaker.GetSandwich();
            sandwich.Display();
            //var builder = new MySandwichBuilder();
            //var builder2 = new ClubSandwichBuilder();

            //builder.CreateSandwich();
            //var sandwich = builder.GetSandwich();

            //StringBuilder is not a Builder Pattern
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello");
            stringBuilder.Append("World");
            
            Console.ReadKey();
        }
    }
}
