using System;
using System.Collections.Generic;
using System.Text;

namespace FoolParadiseApp
{
    public class foolApp
    {

        public string Name { get; set; }
        public int Months { get; set; }
        public decimal Interest { get; set; }
        public decimal Amount { get; set; }


        public foolApp(string name, decimal amount, decimal interest, int months)
        {

            Name = name;
            Months = months;
            Interest = interest;
            Amount = amount;


        }

        // deposit cash
        public string Deposit(string name, decimal amount, decimal interest, int months)
        {


            if (months <= 0 || months > 12)
            {

                throw new InvalidOperationException("Invalid Month");

            }

            var date = DateTime.Now.AddMonths(months);

            return $"Welcome {name}, your total should be ready in {(Months)date.Month }. Thanks";
        }

        // total interest
        public decimal TotalInterest(decimal amount, decimal interest, int months)
        {

            if (amount < 0 || interest < 0 || months < 1)
            {

                throw new ArgumentOutOfRangeException(" Invalid detail");

            }

            decimal interestTotal = (((interest / 100) * amount) * months) + (months * amount);

            return interestTotal;

        }

        // net interest
        public decimal NetInterest(decimal interest, int months)
        {

            if (interest < 0 || months < 1)
            {

                throw new ArgumentOutOfRangeException("Invalid detail");

            }

            decimal netInterst = (((interest / 100) * Amount) * months);

            return netInterst;


        }
    }
}
