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
            var name = "Segun";
            var amt = 2000;
            var percent = 100;
            var month = 5;
            var foolApp = new FoolParadiseCalculator(name, amt, percent, month);
            string depo = foolApp.Deposit(foolApp.Name, foolApp.Amount, foolApp.Interest, foolApp.Months);
            Assert.Equal($"Welcome Segun, your total should be ready in January. Thanks", depo);
        }

        [Fact]
        public void NetInterestTest()
        {
            var name = "Mathais";
            var amt = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new FoolParadiseCalculator(name, amt, percent, month);
            //string depo = foolApp.Deposit(foolApp.Name, foolApp.Amount, foolApp.Interest, foolApp.Months);
            decimal intT = foolApp.NetInterest(foolApp.Interest, foolApp.Months);
            Assert.Equal(2400, intT);
        }

        [Fact]
        public void TotalInterestTest()
        {
            var name = "Samuel";
            var amt = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new FoolParadiseCalculator(name, amt, percent, month);
            //var foolApp = new FoolParadiseCalculator();
            decimal total = foolApp.TotalInterest(foolApp.Amount, foolApp.Interest, foolApp.Months);
            Assert.Equal(8400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            var name = "Fredrick";
            var amt = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new FoolParadiseCalculator(name, amt, percent, month);
            //var foolApp = new FoolParadiseCalculator();
            decimal total = foolApp.TotalInterest(foolApp.Amount, foolApp.Interest, foolApp.Months);
            var doubleTotal = total * 2;
            Assert.Equal(16800, doubleTotal);
        }

        //[Theory]
        //[InlineData(5000)]
        //[InlineData(10000)]
        //[InlineData(20000)]
        //public void VaryingInterest(decimal threshold)
        //{
        //    var foolApp = new FoolParadiseCalculator();
        //    decimal interestAccrued = foolApp.Accrued(threshold, 3000);
        //    Assert.Equal(3125, interestAccrued);
        //}
    }
}
