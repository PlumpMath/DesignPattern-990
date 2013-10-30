using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemoPattern
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder _sandwichBuilder;

        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void BuildSandwich()
        {
            _sandwichBuilder.CreateNewSandwich();
            _sandwichBuilder.PrepareBread();
            _sandwichBuilder.ApplyMeatAndCheese();
            _sandwichBuilder.ApplyVegetables();
            _sandwichBuilder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return _sandwichBuilder.GetSandwich();
        }
    }
}
