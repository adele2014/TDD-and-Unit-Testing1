using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace FoolParadiseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var prog = new Program();
            Console.WriteLine("Enter your name below");
            var name = Console.ReadLine();
            Console.WriteLine("Enter amount");
            var amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest");
            var interest = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter duration in months");
            var months = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hello Customer");

            Console.WriteLine(prog.Deposit(name, amount, interest, months));
            Console.Read();
            Console.WriteLine("Total expected amount is " + prog.Total(amount, interest, months));

        }

        public string Deposit(string name, decimal amount, decimal interest, int months)
        {
            //getting the current month as at the time of the deposit
            DateTime dt = DateTime.Now;

            //Adding the current month to the number of months given for the investment           
            DateTime dueMonth = dt.AddMonths(months);


            decimal total = Total(amount, interest, months);
            return $"Welcome {name}, your {total} should be ready in {dueMonth.ToString("MMMM")}. Thanks";

        }

        public decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal total = 0;
                //----- ur logic
                decimal amountExpected = (amount * months);
                total = amountExpected + (amountExpected * (interest / 100));


                return total;

            }
            catch (Exception ex)
            {

                return -1;
            }

        }

        public decimal NetInterest(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal netInterest = 0;
                //----- ur logic
                netInterest = (interest / 100) * amount * months;

                return netInterest;

            }
            catch (Exception ex)
            {

                return -1;
            }

        }

        //public decimal Accrued(decimal amount,decimal interest, int months)
        //{
        //    try
        //    {
        //        decimal netInterest = 0;
        //        //----- ur logic
        //        if (amount <= 5000)
        //        {
        //            return netInterest = amount + 125;
        //        }

        //        if (amount < 5000 && amount <= 10000 )
        //        {
        //            return netInterest = amount + 200;
        //        }
        //        if (amount < 10000 && amount <= 20000)
        //        {
        //            return netInterest = amount + 250;
        //        }

        //        return netInterest;

        //    }
        //    catch (Exception ex)
        //    {

        //        return -1;
        //    }

        //}
    }

    //public class BankingObject
    //{
    //    public int months { get; set; }
    //    public string name { get; set; }
    //    public decimal interest { get; set; }
    //    public decimal amount { get; set; }
    //}
}
