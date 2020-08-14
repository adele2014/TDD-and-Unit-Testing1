using FoolParadiseApp;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DepositTest()
        {
            //Test for the welcome message and if it returns the expected message
            var foolApp = new Program();
            string depo = foolApp.Deposit("Segun", 2000, 100, 5);
            Assert.Equal($"(Welcome Segun, your total amount of #12000 should be ready in January. Thanks)", depo);
        }

        [Fact]
        public void NetInterestTest()
        {
            //Test if net interest is as expected
            var foolApp = new Program();
            decimal intT = foolApp.NetInterest(1000, 40, 6);
            Assert.Equal(2400, intT);
        }

        [Fact]
        public void TotalTest()
        {
            //Checks if total interest is as expected
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            Assert.Equal(3400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            //Checks for two times the duration
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.Equal(6800, doubleTotal);
        }

        //[Theory]
        //[InlineData(5000)]
        //[InlineData(10000)]
        //[InlineData(20000)]
        //public void VaryingInterest(decimal threshold)
        //{
        //    var foolApp = new Program();
        //    decimal interestAccrued = foolApp.Accrued(threshold, 3000);
        //    Assert.Equal(3125, interestAccrued);
        //}
    }
}
