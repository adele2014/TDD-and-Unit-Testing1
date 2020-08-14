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

            var foolApp = new foolApp(name, amount, interest, months);


            try
            {
                // deposit cash
                var outputDeposit = foolApp.Deposit(foolApp.Name, foolApp.Amount, foolApp.Interest, foolApp.Months);
                Console.WriteLine(outputDeposit);
                
                // total interest
                var totalInterest = foolApp.TotalInterest(foolApp.Amount, foolApp.Interest, foolApp.Months);
                Console.WriteLine(totalInterest);

                // netinterest
                var netInterest = foolApp.NetInterest(foolApp.Interest, foolApp.Months);
                Console.WriteLine(netInterest);


            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid operation ");
            }

        }
    }
  
}
