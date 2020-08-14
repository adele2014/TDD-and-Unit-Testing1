using System;
using System.Collections.Generic;
using System.Text;

namespace FoolParadiseApp
{
    public class Fool
    {
        //properties for the class
        #region properties
        public int months { get; set; }
        public string name { get; set; }
        public decimal interest { get; set; }
        public decimal amount { get; set; }
        #endregion

        #region constructor
        // initialize the fool object
        public Fool(string name, decimal amount, decimal interest, int months)
        {
            this.months = months;
            this.name = name;
            this.interest = interest;
            this.amount = amount;
        }
        #endregion

        #region Deposit
        public string Deposit(string name, decimal amount, decimal interest, int months)
        {
            //check for invalid months
            if (months > 12 || months < 1)
            {
                throw new ArgumentOutOfRangeException("Please keep months between 1 and 12");
            }
            // get time in months
            var times = DateTime.Now.AddMonths(months);

            return $"(Welcome {name}, your total should be ready in {(Months)times.Month}. Thanks)";
        }
        #endregion


        #region Total
        public decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                //check for invlid inputs
                if (months > 12 || months < 1 || amount < 0 || interest < 0)
                {
                    throw new ArgumentOutOfRangeException("One or more invalid inputs");
                }

                decimal total = 0;
                //----- ur logic
                decimal added = (interest / 100) * amount;
                total = (amount * months) + (added * months);

                return total;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid Inputs" + ex);
                return -1;
            }

        }
        #endregion

        #region NetInterest
        public decimal NetInterest(decimal interest, int months)
        {
            try
            {
                //check for wrong inputs
                if (months > 12 || months < 1 || interest < 1)
                {
                    throw new ArgumentOutOfRangeException("Wrong Input");
                }
                decimal nInt = (interest / 100) * this.amount * months;
                return nInt;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid Input" + ex);
                return -1;
            }

        }
        #endregion
    }
}
