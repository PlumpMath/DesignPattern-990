namespace DecoratorPattern
{
    public class Peppers: PizzaDecorator
    {
        public Peppers(Pizza pizza)
            : base(pizza)
        {
            Description = "Peppers";
        }
        public override string GetDesription()
        {
            return string.Format("{0},{1}", _pizza.GetDesription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
    }
}