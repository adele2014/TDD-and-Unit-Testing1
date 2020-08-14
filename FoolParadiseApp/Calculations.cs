using System;
using System.Globalization;

namespace FoolParadiseApp
{
    public static class Calculations
    {
        /// <summary>
        /// This calculates the month of maturity of the deposited amount
        /// </summary>
        /// <param name="name"></param>
        /// <param name="months"></param>
        /// <returns>a string containing name of customer and maturity month</returns>
        public static string Deposit(string name, int months)
        {
            var dueMonth = DateTime.Today.AddMonths(months).Month;
            var month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dueMonth);
            return $"(Welcome {name}, your total should be ready in {month}. Thanks.)";
        }
        /// <summary>
        /// Total amount after maturity period
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="interest"></param>
        /// <param name="months"></param>
        /// <returns>the total amount at maturity period</returns>
        public static decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal total = 0;
                total += amount * months + NetInterest(amount, interest, months);
                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An {ex} error was encountered");
                return -1;
            }
        }
        /// <summary>
        /// Calculates the total interest during investment
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="interest"></param>
        /// <param name="months"></param>
        /// <returns>total interest</returns>
        public static decimal NetInterest(decimal amount, decimal interest, int months)
        {
            try
            {
                return amount * interest / 100 * months;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An {ex} error was encountered");
                return -1;
            }
        }
        /// <summary>
        /// A Special method to calculate total interest
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="month"></param>
        /// <returns>net interest</returns>
        public static decimal Accrued(decimal amount, int month)
        {
            var interest = 40;
            try
            {
                if (amount >= 5000)
                {
                    return NetInterest(5000, (decimal)15, month);
                }
                return NetInterest(amount, interest, month);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An {ex} error was encountered");
                return -1;
            }
        }
    }
}
