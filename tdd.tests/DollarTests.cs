﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd.infrastructure;

namespace tdd.tests
{
    [TestClass]
    public class DollarTests
    {
        [TestMethod]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.AreEqual(new Dollar(10), product);
            product = five.times(3);
            Assert.AreEqual(new Dollar(15), product);
        }

        [TestMethod]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
