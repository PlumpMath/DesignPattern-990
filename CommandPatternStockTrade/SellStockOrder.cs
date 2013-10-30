namespace CommandPatternStockTrade
{
    /// <summary>
    /// ConcreteCommand Class implementation which will be created by client and given to the invoker 
    /// Ideally this should not be created by the client too it can be created through the factory based on the necessity
    /// </summary>
    public class SellStockOrder : IOrder
    {
        private readonly StockTrade _stock;

        public SellStockOrder(StockTrade stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Sell();
        }
    }
}