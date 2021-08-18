using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(new Dollar(10), five.times(2));
            Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [TestMethod]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            
            Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
        }
    }
}
