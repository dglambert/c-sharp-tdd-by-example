using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd.infrastructure;

namespace tdd.tests
{
    [TestClass]
    public class FrancTests
    {
        [TestMethod]
        public void testFrancMultiplication()
        {
            Money five = Money.franc(5);
            Assert.AreEqual(Money.franc(10), five.times(2));
            Assert.AreEqual(Money.franc(15), five.times(3));
        }

        [TestMethod]
        public void testEquality()
        {
            Assert.IsTrue(Money.franc(5).Equals(Money.franc(5)));
            Assert.IsFalse(Money.franc(5).Equals(Money.franc(6)));
        }

        [TestMethod]
        public void testDifferentClassEquality()
        {
            Assert.IsTrue(new Money(10, "CHF").Equals(new Franc(10, "CHF")));
        }
    }
}
