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
            // user detail
            var name = "Segun";
            var amount = 1000;
            var percent = 6;
            var month = 5;
            var foolApp = new foolApp(name, amount, percent, month);
            // act
            string depo = foolApp.Deposit(name, amount, percent, month);
            // assert
            Assert.Equal($"Welcome Segun, your total should be ready in January. Thanks", depo);
        }

        [Fact]
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
            // assert
            Assert.Equal(2400, intT);
        }

        [Fact]
        public void TotalInterestTest()
        {   
            // user detail
            var name = "Segun";
            var amount = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new foolApp(name, amount, percent, month);
            // act
            decimal total = foolApp.TotalInterest(1000, 40, 6);
            // assert
            Assert.Equal(8400, total);
        }

        [Fact]
        public void TwoTotalTest()
        {
            // user detail
            var name = "Segun";
            var amount = 1000;
            var percent = 40;
            var month = 6;
            var foolApp = new foolApp(name, amount, percent, month);
            // act
            decimal total = foolApp.TotalInterest(1000, 40, 6);
            var doubleTotal = total * 2;
            // assert
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
