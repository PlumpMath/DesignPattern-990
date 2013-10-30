namespace DecoratorPattern
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza): base(pizza)
        {
            Description = "Cheese";
        }
        public override string GetDesription()
        {
            return string.Format("{0},{1}", _pizza.GetDesription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.25;
        }
    }

    
}