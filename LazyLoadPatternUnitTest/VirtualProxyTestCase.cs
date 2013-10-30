using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualProxyLazyLoadPattern;

namespace LazyLoadPatternUnitTest
{
    [TestClass]
    public class VirtualProxyTestCase
    {
        [TestMethod]
        public void PrintLabelWithOrderProxy()
        {
            const int testOrderId = 123;

            var order = new OrderFactory().CreateFromId(testOrderId);

            Assert.AreEqual(testOrderId,order.Id);

            var result = order.PrintLabel();

            Assert.AreEqual("Company Name\nDefault Address", result);
        }
    }
}
