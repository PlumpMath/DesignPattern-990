namespace DecoratorPattern
{
    public class LargePizza: Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }

        public override string GetDesription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 9.00;
        } 
    }
}
