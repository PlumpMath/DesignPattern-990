namespace CommandPatternStockTrade
{
    class Program
    {
        static void Main(string[] args)
        {

            var stock = new StockTrade();

            var bsc = new BuysStockOrder(stock);
            var ssc = new SellStockOrder(stock);

            var agent = new Agent();

            agent.PlaceOrder(bsc);
            agent.PlaceOrder(ssc);
        }
    }
}
