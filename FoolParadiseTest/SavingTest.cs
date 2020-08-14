using FoolParadiseApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoolParadiseTest
{
    [TestClass]
    public class SavingTest
    {
        [TestMethod]
        public void DepositTest()
        {
            var foolApp = new Program();
            string depo = foolApp.Deposit("Segun", 2000, 100, 5);
            Assert.AreEqual($"(Welcome Segun, your total should be ready in January. Thanks)", depo);
        }

        [TestMethod]
        public void NetInterestTest()
        {
            var foolApp = new Program();
            decimal intT = foolApp.NetInterest(1000, 40, 6);
            Assert.AreEqual(2400, intT);
        }

        [TestMethod]
        public void TotalTest()
        {
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            Assert.AreEqual(8400, total);
        }

        [TestMethod]
        public void TwoTotalTest()
        {
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.AreEqual(16800, doubleTotal);
        }
    }
}