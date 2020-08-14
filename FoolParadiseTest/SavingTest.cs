using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoolParadiseApp;
namespace FoolParadiseTest
{
    [TestClass]
    public class SavingTest
    {
        [TestMethod]
        public void DepositTest()
        {
            var foolApp = new Fool("Segun", 1000, 6, 5); ;
            string depo = foolApp.Deposit("Segun", 2000, 100, 5);
            Assert.AreEqual($"(Welcome Segun, your total should be ready in January. Thanks)", depo);
        }

        [TestMethod]
        public void NetInterestTest()
        {
            var foolApp = new Fool("Segun", 1000, 6, 5);
            decimal intT = foolApp.NetInterest(40, 6);
            Assert.AreEqual(2400, intT);
        }

        [TestMethod]
        public void TotalTest()
        {
            var foolApp = new Fool("Segun", 1000, 6, 5);
            decimal total = foolApp.Total(1000, 40, 6);
            Assert.AreEqual(8400, total);
        }

        [TestMethod]
        public void TwoTotalTest()
        {
            var foolApp = new Fool("Segun", 1000, 6, 5);
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.AreEqual(16800, doubleTotal);
        }
    }
}
