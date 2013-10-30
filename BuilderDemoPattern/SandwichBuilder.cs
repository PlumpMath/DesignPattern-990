using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemoPattern
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void AddCondiments();
        public abstract void ApplyVegetables();
        public abstract void ApplyMeatAndCheese();
        public abstract void PrepareBread();
    }
}
