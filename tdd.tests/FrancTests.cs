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
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.times(2));
            Assert.AreEqual(new Franc(15), five.times(3));
        }
    }
}
