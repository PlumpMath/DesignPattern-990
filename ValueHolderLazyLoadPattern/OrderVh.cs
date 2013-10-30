using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueHolderLazyLoadPattern
{
    public class OrderVh
    {
        public int Id { get; set; }

        public OrderVh(int id)
        {
            Id = id;
        }

        private ValueHolder<List<OrderItem>> _items;

        public List<OrderItem> Items
        {
            get { return _items.Value; }
        }

        internal void SetItems(ValueHolder<List<OrderItem>> valueHolder)
        {
            _items = valueHolder;
        }
    }
}
