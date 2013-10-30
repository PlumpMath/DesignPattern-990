using System.Collections;

namespace CommandPatternStockTrade
{
    /// <summary>
    /// Invoker class used by the client to execute the operations for each of the command
    /// </summary>
    public class Agent
    {
        private readonly  ArrayList _ordersQueue = new ArrayList();

        public void PlaceOrder(IOrder order)
        {
            _ordersQueue.Add(order);
            order.Execute();
        }
    }
}