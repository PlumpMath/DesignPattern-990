using System;

namespace CommandPatternStockTrade
{

    /// <summary>
    /// Receiver Class is the class which client is supposed to pass in and 
    /// gets the command pattern relevat information to execute further 
    /// </summary>
    public class StockTrade
    {
        public void Buy()
        {
            Console.WriteLine("You want to buy stocks");
        }

        public void Sell()
        {
            Console.WriteLine("You want to sell stocks");
        }
    }
}