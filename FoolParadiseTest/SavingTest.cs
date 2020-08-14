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
            //Arrange
            var foolApp = new Program();

            //Act
            string depo = foolApp.Deposit("Segun", 2000, 100, 5);

            //Assert
            Assert.AreEqual($"Welcome Segun, your total should be ready in January. Thanks", depo);
        }

        [TestMethod]
        public void NetInterestTest()
        {
            //Arrange
            var foolApp = new Program();

            //Act
            decimal intT = foolApp.NetInterest(1000, 40, 6);

            //Assert
            Assert.AreEqual(2400, intT);
        }

        [TestMethod]
        public void TotalTest()
        {
            //Arrange
            var foolApp = new Program();

            //Act
            decimal total = foolApp.Total(1000, 40, 6);

            //Assert
            Assert.AreEqual(8400, total);
        }

        [TestMethod]
        public void TwoTotalTest()
        {
            //Arrange
            var foolApp = new Program();

            //Act
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;

            //Assert
            Assert.AreEqual(16800, doubleTotal);
        }
    }
}