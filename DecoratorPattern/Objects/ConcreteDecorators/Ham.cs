namespace DecoratorPattern
{
    public class Ham: PizzaDecorator
    {
        public Ham(Pizza pizza)
            : base(pizza)
        {
            Description = "Ham";
        }
        public override string GetDesription()
        {
            return string.Format("{0},{1}", _pizza.GetDesription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.00;
        }
    }
}