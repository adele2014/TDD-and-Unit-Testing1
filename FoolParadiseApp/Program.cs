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

            var fool = new Fool(name, amount, interest, months);

            Console.WriteLine("Hello Customer");

            Console.WriteLine(fool.Deposit(name, amount, interest, months));
            Console.Read();
            Console.WriteLine("Total expected amount is " + fool.Total(amount, interest, months));

        }


        /*        public decimal Accrued(decimal interest, int months)
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

                }*/
    }
}
