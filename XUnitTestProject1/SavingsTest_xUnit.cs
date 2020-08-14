using FoolParadiseApp;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class SavingsTest_xUnit
    {
        [Fact]
        public void DepositTest()
        {
            string depo = Calculations.Deposit("Segun", 4);
            Assert.Equal($"(Welcome Segun, your total should be ready in December. Thanks.)", depo);
        }

        [Fact]
        public void NetInterestTest()
        {
            decimal intT = Calculations.NetInterest(1000, 40, 6);
            Assert.Equal(2400, intT);
        }

        [Fact]
        public void TotalTest()
        {
            decimal total = Calculations.Total(1000, 40, 6);
            Assert.Equal(8400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            decimal total = Calculations.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.Equal(16800, doubleTotal);
        }

        [Theory]
        [InlineData(5000, 18750)]
        [InlineData(10000, 18750)]
        [InlineData(20000, 18750)]
        public void VaryingInterest(decimal threshold, int expected)
        {
            decimal interestAccrued = Calculations.Accrued(threshold, 25);
            Assert.Equal(expected, interestAccrued);
        }
    }
}
