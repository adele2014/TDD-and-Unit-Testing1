using FoolParadiseApp;
using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace FoolParadiseuser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello customer!");
            Console.Write("Welcome!. Kindly fill in the details below:\n");

            //Initialize the Program

            //Enter details
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter amount");
            var amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest (in %)");
            var interest = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter duration in months");
            var months = Int32.Parse(Console.ReadLine());

            var user = new FoolParadiseCalculator(name, amount, interest, months);

            try
            {
                var output = user.Deposit(name, amount, interest, months);
                Console.WriteLine(output);

                Console.WriteLine();
                Console.WriteLine("Total Interest");

                var depositResult = user.Total(user.Amount, user.Interest, user.Months);
                Console.WriteLine(depositResult);

                Console.WriteLine();
                Console.WriteLine("Net Interest");

                var netInterest = user.NetInterest(user.Interest, user.Months);
                Console.WriteLine(netInterest);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a valid month number: from 1 - 12");
            }
        }
    }
}
