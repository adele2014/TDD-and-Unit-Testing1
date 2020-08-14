using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoolParadiseApp;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace FoolParadiseTest
{
    [TestClass]
    public class SavingTest
    {
        [TestMethod]
        public void DepositTest()
        {
            // user details  arrange 
            var name = "Segun";
            var amount = 1000;
            var percent = 6;
            var month = 5;
            var foolApp = new foolApp(name, amount, percent, month);
            //act
            string depo = foolApp.Deposit(name, amount, percent, month);
            // assert test
            Assert.AreEqual($"Welcome Segun, your total should be ready in January. Thanks", depo);

          
        }
      
        [TestMethod]
        public void NetInterestTest()
        {   
            // user detail 
            var name = "Segun";
            var amount = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new foolApp(name, amount, percent, month);
            // act 
            decimal intT = foolApp.NetInterest(foolApp.Interest, foolApp.Months);
            // assert test
            Assert.AreEqual(2400, intT);
        }

        [TestMethod]
        public void TotalInterest()
        {   
            //user details
            var name = "Segun";
            var amount = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new foolApp(name, amount, percent, month);
            // act
            decimal total = foolApp.TotalInterest(1000, 40, 6);
            // assert
            Assert.AreEqual(8400, total);
        }

        [TestMethod]
        public void TwoTotalTest()
        {   
            // user detail
            var name = "Segun";
            var amount = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new foolApp(name, amount, percent, month);
            decimal total = foolApp.TotalInterest(1000, 40, 6);
            // act 
            var doubleTotal = total * 2;
            // assert
            Assert.AreEqual(16800, doubleTotal);
        }
    }
}
