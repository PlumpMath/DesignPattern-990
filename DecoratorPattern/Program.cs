using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Objects.ConcreteComponent;


namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();

            //decorators taking the old pizza class 
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Peppers(largePizza);

            string accountNumber = "0000228010000228";

            Console.WriteLine(accountNumber.Substring(2, 6));            

            Console.WriteLine(accountNumber.Substring(0, 6) + "xxxxxx" + accountNumber.Substring(12, 4));


            Console.WriteLine(largePizza.GetDesription());

            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
