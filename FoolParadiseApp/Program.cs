using System;

namespace FoolParadiseApp
{
    /// <summary>
    /// Application's entry point
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal amount;
            string name;
            decimal interest;
            int month;
            bool success;

            // Receives customer's name
            Console.Write("Kindly enter your name:    ");
            name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Kindly input your name.");
                Console.Write("Enter name:      ");
                name = Console.ReadLine();
            }

            // Receives deposit amount
            Console.Write("Enter deposit amount:      ");
            success = decimal.TryParse(Console.ReadLine(), out amount);
            while (success && amount < 1 || !success)
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Enter deposit amount:      ");
                success = decimal.TryParse(Console.ReadLine(), out amount);
            }

            // Receives desired interest
            Console.Write("Enter desired interest:    ");
            success = decimal.TryParse(Console.ReadLine(), out interest);
            while (success && interest < 1 || !success)
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Enter deposit amount:      ");
                success = decimal.TryParse(Console.ReadLine(), out interest);
            }

            // Receives the investment month
            Console.Write("Planned investment months: ");
            success = int.TryParse(Console.ReadLine(), out month);
            while (success && month < 1 || !success)
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Enter deposit amount:      ");
                success = int.TryParse(Console.ReadLine(), out month);
            }


            // Logs customer's investement details. 
            Console.WriteLine();
            Console.WriteLine("Hello Customer");
            Console.WriteLine();
            Console.WriteLine($"        {Calculations.Deposit(name.ToUpper(), month)}");
            Console.WriteLine();
            Console.WriteLine($"        Total expected amount is ${Calculations.Total(amount, interest, month)}");
            Console.WriteLine();
            Console.WriteLine($"        Your total returns after {2 * month} months will be ${2 * Calculations.Total(amount, interest, month)}");

        }
    }
}
