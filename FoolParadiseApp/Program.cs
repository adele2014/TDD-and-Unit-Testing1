using System;
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
        public enum Months
        {
            January = 1,
            Febuary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December = 0

        }
        //Returns Welcome Customer and the amount expected in certain period of time
        public string Deposit(string name, decimal amount, decimal interest, int months)
        {


            var now = DateTime.Now;
            var ready = (now.Month + months) % 12;

            return $"(Welcome {name}, your total amount of #{Total(amount, interest, months)} should be ready in {(Months)ready}. Thanks)";
        }


        //Calculates the total amount of money at certain interest and given amount of time

        public decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal total = (amount + ((interest / 100) * months * amount));
                //----- ur logic


                return total;

            }
            catch
            {

                return -1;
            }

        }
        //Returns the net Interest on certain amount in a given period of time
        public decimal NetInterest(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal netInterest = ((interest / 100) * months * amount);
                //----- ur logic


                return netInterest;

            }
            catch
            {

                return -1;
            }

        }

        public decimal Accrued(decimal interest, int months)
        {
            try
            {
                decimal netInterest = 0;
                //----- ur logic


                return netInterest;

            }
            catch
            {

                return -1;
            }

        }
    }

    //public class BankingObject
    //{
    //    public int months { get; set; }
    //    public string name { get; set; }
    //    public decimal interest { get; set; }
    //    public decimal amount { get; set; }
    //}
}
