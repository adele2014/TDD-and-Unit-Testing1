using System;
using System.Collections.Generic;
using System.Text;

namespace FoolParadiseApp
{
    public class FoolParadiseCalculator
    {
        public int Months { get; set; }
        public string Name { get; set; }
        public decimal Interest { get; set; }
        public decimal Amount { get; set; }

        public FoolParadiseCalculator(string name, decimal amount, decimal interest, int months)
        {
            Name = name;
            Amount = amount;
            Interest = interest;
            Months = months;
        }

        public string Deposit(string name, decimal amount, decimal interest, int months)
        {
            if (months <= 0 || months > 12)
            {
                throw new InvalidOperationException("Enter a valid month number: from 1 - 12");
            }
            var expectedDate = DateTime.Now.AddMonths(months);
            return $"Welcome {name}, your total should be ready in {(Months)expectedDate.Month }. Thanks";
        }

        public decimal TotalInterest(decimal amount, decimal interest, int months)
        {
            if (amount < 0 || interest < 0 || months < 1)
            {
                throw new ArgumentOutOfRangeException("Invalid parameters");
            }
            decimal result = ((((interest / 100) * amount) * months) + (months * amount));
            return result;
        }

        public decimal NetInterest(decimal interest, int months)
        {
            if (interest < 0 || months < 1)
            {
                throw new ArgumentOutOfRangeException("Invalid parameters");
            }
            decimal result = (((interest / 100) * Amount) * months);
            return result;

        }

        //public decimal Accrued(decimal interest, int months)
        //{
        //    try
        //    {
        //        decimal netInterest = 0;
        //        //----- ur logic


        //        return netInterest;

        //    }
        //    catch (Exception ex)
        //    {

        //        return -1;
        //    }

        //}
    }
}
