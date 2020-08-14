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
            string depo = foolApp.Deposit("Segun", 2000, 100, 4);
            Assert.Equal($"Welcome Segun, your 16000 should be ready in December. Thanks", depo);
        }

        [Fact]
        public void NetInterestTest()
        {
            var foolApp = new Program();
            decimal intT = foolApp.NetInterest(1000, 40, 6);
            Assert.Equal(2400, intT);
        }

        [Fact]
        public void TotalTest()
        {
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            Assert.Equal(8400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            var foolApp = new Program();
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.Equal(16800, doubleTotal);
        }

        [Theory]
        [InlineData(5000, 80)]
        [InlineData(10000, 40)]
        [InlineData(20000, 20)]
        public void VaryingInterest(decimal threshold, decimal interest)
        {
            var foolApp = new Program();
            decimal interestAccrued = foolApp.Accrued(threshold, interest, 6);
            Assert.Equal(24000, interestAccrued);

        }
    }
}
