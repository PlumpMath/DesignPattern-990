using System;
using LazyInitializationLazyLoadPattern;
using LazyInitializationLazyTPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LazyLoadPatternUnitTest
{
    [TestClass]
    public class LazyInitLazyTOrderShould
    {
        [TestMethod]
        public void PrintLabelWithBadOrder()
        {
            var order = new OrderLazy();

            var result = order.PrintLabel();

            Assert.AreEqual("Company Name\nDefault Address", result);
        }

        //[TestMethod]
        //public void PrintLabelWithGoodOrder()
        //{
        //    var order = new OrderGood();

        //    var result = order.PrintLabel();

        //    Assert.AreEqual("Company Name\nDefault Address", result);
        //}
    }
}
