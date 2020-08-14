using FoolParadiseApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoolParadiseTest
{
    [TestClass]
    public class SavingsTest_MSTest
    {
        [TestMethod]
        public void DepositTest()
        {
            string depo = Calculations.Deposit("Segun", 4);
            Assert.AreEqual($"(Welcome Segun, your total should be ready in December. Thanks.)", depo);
        }

        [TestMethod]
        public void NetInterestTest()
        {
            decimal intT = Calculations.NetInterest(1000, 40, 6);
            Assert.AreEqual(2400, intT);
        }

        [TestMethod]
        public void TotalTest()
        {
            decimal total = Calculations.Total(1000, 40, 6);
            Assert.AreEqual(8400, total);
        }

        [TestMethod]
        public void TwoTotalTest()
        {
            decimal total = Calculations.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.AreEqual(16800, doubleTotal);
        }

        [DataTestMethod]
        [DataRow(5000, 18750)]
        [DataRow(10000, 18750)]
        [DataRow(20000, 18750)]
        public void VaryingInterest(int threshold, int expected)
        {
            decimal interestAccrued = Calculations.Accrued((decimal)threshold, 25);
            Assert.AreEqual(expected, interestAccrued);
        }
    }
}
