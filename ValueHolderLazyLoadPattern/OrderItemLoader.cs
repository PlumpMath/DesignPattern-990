using System.Collections.Generic;
using System.Diagnostics;

namespace ValueHolderLazyLoadPattern
{
    public class OrderItemLoader : IValueLoader<List<OrderItem>>
    {
        private readonly int _orderId;
        public OrderItemLoader(int orderId)
        {
            _orderId = orderId;
        }

        #region IValueLoader<List<OrderItem>> Members

        public List<OrderItem> Load()
        {
            Debug.Print("Fetching OrderItems from Database");
            return new List<OrderItem>();
        }

        #endregion
    }
}