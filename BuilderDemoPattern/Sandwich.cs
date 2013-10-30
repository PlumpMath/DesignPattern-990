using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemoPattern.Enum;

namespace BuilderDemoPattern
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }        
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", BreadType);
            var toastedStatus = IsToasted ? ("Toasted") : string.Empty;
            Console.WriteLine(toastedStatus);
            var mayoStatus = IsToasted ? ("With Mayo") : string.Empty;
            Console.WriteLine(mayoStatus);
            Console.WriteLine("Meat: {0}",MeatType);
            Console.WriteLine("Cheese: {0}",CheeseType);
            Console.WriteLine("Veggies:");
            Vegetables.ForEach(x => Console.WriteLine("  {0}", x));
        }

    }
}
