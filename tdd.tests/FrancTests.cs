using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd.tests
{
    [TestClass]
    public class FrancTests
    {
        [TestMethod]
        public void testFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.Equals(new Franc(10), five.times(2));
            Assert.Equals(new Franc(15), five.times(3));
        }
    }
}
