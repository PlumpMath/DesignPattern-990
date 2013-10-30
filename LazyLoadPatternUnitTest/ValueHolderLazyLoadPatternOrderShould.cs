using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueHolderLazyLoadPattern;

namespace LazyLoadPatternUnitTest
{
    [TestClass]
    public class ValueHolderLazyLoadPatternOrderShould
    {
        [TestMethod]
        public void NotLoadItemsUntilReferenced()
        {
            int orderId = 123;
            var order = new OrderFactory().CreateFromId(orderId);

            Assert.AreEqual(orderId, order.Id);

            var items = order.Items;

            Assert.AreEqual(0,items.Count);
        }
    }
}