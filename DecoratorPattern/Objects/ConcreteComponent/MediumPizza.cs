
namespace DecoratorPattern
{
    public class MediumPizza: Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }

        public override string GetDesription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 6.00;
        } 
    }
}