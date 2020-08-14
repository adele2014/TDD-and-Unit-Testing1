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
            //Test for the welcome message and if it returns the expected message

            var foolApp = new Program();
            string depo = foolApp.Deposit("Segun", 2000, 100, 5);
            Assert.AreEqual($"(Welcome Segun, your total amount of #12000 should be ready in January. Thanks)", depo);
        }

        [TestMethod]
        public void NetInterestTest()
        {
            //Test if net interest is as expected

            var foolApp = new Program();
            decimal intT = foolApp.NetInterest(1000, 40, 6);
            Assert.AreEqual(2400, intT);
        }

        [TestMethod]
        public void TotalTest()
        {
            //Test if Total interest is as expected

            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            Assert.AreEqual(3400, total);
        }

        [TestMethod]
        public void TwoTotalTest()
        {
            //Checks for two times the duration

            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.AreEqual(6800, doubleTotal);
        }
    }
}
