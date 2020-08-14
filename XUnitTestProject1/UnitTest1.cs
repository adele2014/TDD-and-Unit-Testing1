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
            var foolApp = new Program();
            string depo = foolApp.Deposit("Segun", 2000, 100, 5);
            Assert.Equal($"Welcome Segun, your total 12000 should be ready in January. Thanks", depo);
        }

        [Fact]
        public void NetInterestTest()
        {
            var foolApp = new Program();
            decimal intT = foolApp.NetInterest(1000, 50, 6);
            Assert.Equal(3000, intT);
        }

        [Fact]
        public void TotalTest()
        {
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            Assert.Equal(3400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.Equal(6800, doubleTotal);
        }

        [Theory]
        [InlineData(5000, 30, 4, 6000)]
        [InlineData(10000, 40, 5, 20000)]
        [InlineData(20000, 50, 6, 60000)]
        public void VaryingInterest(decimal threshold, int interest, int months, decimal expected)
        {
            var foolApp = new Program();
            decimal interestAccrued = foolApp.Accrued(threshold, interest, months);
            Assert.Equal(expected, interestAccrued);
        }
    }
}
