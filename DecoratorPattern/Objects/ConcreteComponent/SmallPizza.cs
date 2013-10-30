
namespace DecoratorPattern.Objects.ConcreteComponent
{
    public class SmallPizza: Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }

        public override string GetDesription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 3.00;
        }
    }
}