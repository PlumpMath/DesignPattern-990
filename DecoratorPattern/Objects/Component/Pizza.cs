using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Pizza
    {
        public string Description { get; set; }

        public abstract string GetDesription();

        public abstract double CalculateCost();
    }
}
