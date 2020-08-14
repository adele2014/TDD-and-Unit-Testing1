using System;
using System.Collections.Generic;

namespace FoolParadiseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<BankingObject> allData = new List<BankingObject>();

            Console.WriteLine("Hello World!");

            var prog = new Program();
            Console.WriteLine("Enter your name below");
            var name = Console.ReadLine();                /**** Collecting user data ****/
            Console.WriteLine("Enter amount");
            var amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest");
            var interest = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter duration in months");
            var months = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hello Customer");

            BankingObject obj = new BankingObject();

            obj.amount = amount;
            obj.interest = interest;
            obj.months = months;
            obj.name = name;

            allData.Add(obj); // Stores an instance or an object of BankObject class in a generic list of type BankingObject

            Console.WriteLine(prog.Deposit(name, amount, interest, months));
            Console.Read();
            Console.WriteLine("Total expected amount is " + prog.Total(amount, interest, months)); // Returns the total expected amount;
        }

        public string Deposit(string name, decimal amount, decimal interest, int months)
        {
            if (name == null && amount <= 0 && interest <= 0 && months <= 0)
            {
                throw new NullReferenceException("Please enter valid values");
            }
            else
            {
                DateTime finalMonth = DateTime.Now.AddMonths(months);

                return $"(Welcome {name}, your total should be ready in {finalMonth.ToString("MMMM")}. Thanks)";
            }
        }

        public decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                if (amount <= 0 && interest <= 0 && months <= 0) // Checks for invalid values
                {
                    throw new NullReferenceException("Please enter valid values");
                }
                else
                {
                    decimal total = 0;

                    total = (amount * months / 100) * interest; // Calculating the total
                    total += amount * 6;
                    return total;
                }
            }
            catch (NullReferenceException ex) // throws an Exception if the values are invalid
            {
                Console.WriteLine(ex);
                return -1;
            }
        }

        public decimal NetInterest(decimal amount, decimal interest, int months)
        {
            try
            {
                if (amount <= 0 && interest <= 0 && months <= 0)
                {
                    throw new NullReferenceException("Please enter valid values"); // throws an exception if interest, amount months is less or equal to zero
                }
                else
                {
                    decimal netInterest = (amount * months / 100) * interest; // Calculating the net interest

                    return netInterest; // returns the net interest
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }

        public decimal Accrued(decimal interest, int months)
        {
            try
            {
                // decimal netInterest = 0;

                return 125 + months;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }
    }

    public class BankingObject
    {
        public int months { get; set; }
        public string name { get; set; }
        public decimal interest { get; set; }
        public decimal amount { get; set; }
    }
}