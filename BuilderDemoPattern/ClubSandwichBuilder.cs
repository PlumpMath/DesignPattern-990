using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemoPattern.Enum;

namespace BuilderDemoPattern
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> {"Potatoes", "Peas"};
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Chicken;
            sandwich.CheeseType = CheeseType.Cheddar;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.Wheat;
            sandwich.IsToasted = false;
        }
    }
}
