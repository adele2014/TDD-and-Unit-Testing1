using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoolParadiseApp
{
    public class FoolParadiseCalculator
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal Interest { get; set; }
        public int Months { get; set; }

        public FoolParadiseCalculator(string name, decimal amount, decimal interest, int months)
        {
            this.Name = name;
            this.Amount = amount;
            this.Interest = interest;
            this.Months = months;
        }


        public string Deposit(string name, decimal amount, decimal interest, int months)
        {

            if (months <= 0 || months > 12)
            {
                throw new IndexOutOfRangeException("Enter a number between from 1 and 12");
            }
            var Maturity = DateTime.Now.AddMonths(months);
            //Console.WriteLine(Maturity.Month);
            return $"Welcome {name}, your total should be ready in {(Months)Maturity.Month}. Thanks";

        }

        public decimal Total(decimal amount, decimal interest, int months)
        {
            if (amount < 0 || interest < 0 || months < 0)
            {
                throw new ArithmeticException("You cannot put Negative values");
            }
            decimal result = ((((interest / 100) * amount) * months) + (months * amount));
            return result;
            //try
            //{

            //    decimal result = ((((interest / 100) * amount) * months) + (months * amount));


            //    return result;

            //}
            //catch (Exception ex)
            //{

            //    return -1;
            //}

        }

        public decimal NetInterest(decimal interest, int months)
        {
            if (interest < 0 || months < 0)
            {
                throw new ArithmeticException("You can't enter a negative number");
            }
            decimal result = (((interest / 100) * Amount) * months);
            return result;
            //try
            //{
            //    decimal netInterest = 0;
            //    //----- ur logic


            //    return netInterest;

            //}
            //catch (Exception ex)
            //{

            //    return -1;
            //}

        }

        public decimal Accrued(decimal interest, int months)
        {
            try
            {
                decimal netInterest = 0;
                //----- ur logic


                return netInterest;

            }
            catch (Exception ex)
            {

                return -1;
            }


        }
    }
}
