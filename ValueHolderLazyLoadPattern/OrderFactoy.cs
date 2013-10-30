using System.Collections.Generic;

namespace ValueHolderLazyLoadPattern
{
    public class OrderFactory
    {
        public OrderVh CreateFromId(int id)
        {
            var order = new OrderVh(id);
            order.SetItems(new ValueHolder<List<OrderItem>>(new OrderItemLoader(id)));
            return order;
        }
    }
}