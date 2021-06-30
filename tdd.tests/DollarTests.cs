using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd.tests
{
    [TestClass]
    public class DollarTests
    {
        [TestMethod]
        public void testMultiplication()
        {
            DollarTests five = new Dollar(5);
            five.times(2);
            Assert.AreEqual(10, five.amount);
        }
    }
}
