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
            //var foolApp = new Program();

            var depot = new FoolParadiseCalculator("Segun", 2000, 100, 5);
            string depo = depot.Deposit(depot.Name, depot.Amount, depot.Interest, depot.Months);
            Assert.Equal($"Welcome Segun, your total should be ready in January. Thanks", depo);
        }

        [Fact]
        public void NetInterestTest()
        {
            //var foolApp = new Program();
            var sut = new FoolParadiseCalculator("Tosin", 1000, 40, 6);
            decimal intT = sut.NetInterest(sut.Interest, sut.Months);
            Assert.Equal(2400, intT);
        }

        [Fact]
        public void TotalTest()
        {
            //var foolApp = new Program();
            var sut = new FoolParadiseCalculator("Tosin", 1000, 40, 6);
            decimal total = sut.Total(sut.Amount, sut.Interest, sut.Months);
            Assert.Equal(8400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            //var foolApp = new Program();
            var sut = new FoolParadiseCalculator("Tosin", 1000, 40, 6);
            decimal total = sut.Total(sut.Amount, sut.Interest, sut.Months);
            var doubleTotal = total * 2;
            Assert.Equal(16800, doubleTotal);
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
