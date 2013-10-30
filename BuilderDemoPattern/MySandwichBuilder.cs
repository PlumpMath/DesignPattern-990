using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemoPattern.Enum;

namespace BuilderDemoPattern
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> {"Tomatoes", "Onion"};
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Salami;
            sandwich.CheeseType = CheeseType.American;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;
        }
    }
}
