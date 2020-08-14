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
            var foolApp = new Fool("Segun", 1000, 6, 5);
            string depo = foolApp.Deposit("Segun", 2000, 100, 5);
            Assert.Equal($"(Welcome Segun, your total should be ready in January. Thanks)", depo);
        }

        [Fact]
        public void NetInterestTest()
        {
            var foolApp = new Fool("Segun", 1000, 6, 5);
            decimal intT = foolApp.NetInterest(40, 6);
            Assert.Equal(2400, intT);
        }

        [Fact]
        public void TotalTest()
        {
            var foolApp = new Fool("Segun", 1000, 6, 5);
            decimal total = foolApp.Total(1000, 40, 6);
            Assert.Equal(8400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            var foolApp = new Fool("Segun", 1000, 6, 5);
            decimal total = foolApp.Total(1000, 40, 6);
            var doubleTotal = total * 2;
            Assert.Equal(16800, doubleTotal);
        }

        /*        [Theory]
                [InlineData(5000)]
                [InlineData(10000)]
                [InlineData(20000)]
                public void VaryingInterest(decimal threshold)
                {
                    var foolApp = new Program();
                    decimal interestAccrued = foolApp.Accrued(threshold, 3000);
                    Assert.Equal(3125, interestAccrued);
                }*/
    }
}
