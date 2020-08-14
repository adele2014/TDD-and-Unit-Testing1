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
            //var foolApp = new Program();
            var depot = new FoolParadiseCalculator("Segun", 2000, 100, 5);
            string depo = depot.Deposit(depot.Name, depot.Amount, depot.Interest, depot.Months);
            Assert.AreEqual($"Welcome Segun, your total should be ready in January. Thanks", depo);
        }

        [TestMethod]
        public void NetInterestTest()
        {
            //var foolApp = new Program();
            var sut = new FoolParadiseCalculator("Tunde", 1000, 40, 6);
            decimal intT = sut.NetInterest(sut.Interest, sut.Months);
            Assert.AreEqual(2400, intT);
        }

        [TestMethod]
        public void TotalTest()
        {
            // var foolApp = new Program();
            var sut = new FoolParadiseCalculator("chinazor", 1000, 40, 6);
            decimal tot = sut.Total(sut.Amount, sut.Interest, sut.Months);
            Assert.AreEqual(8400, tot);
        }

        [TestMethod]
        public void TwoTotalTest()
        {
            //var foolApp = new Program();
            var sut = new FoolParadiseCalculator("Nato", 1000, 40, 6);
            decimal total = sut.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.AreEqual(16800, doubleTotal);
        }
    }
}
