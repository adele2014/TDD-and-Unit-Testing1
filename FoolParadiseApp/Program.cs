using System;

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
            var total = Total(amount, interest, months);
            var month = DateTime.Now.AddMonths(months).ToString("MMMM");
            return $"Welcome {name}, your total sum, N{total} , should be ready in {month}. Thanks";
        }

        public decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal total = 0;
                var interestAccrued = NetInterest(amount, interest, months);
                total = amount + interestAccrued;
                return total;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public decimal NetInterest(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal netInterest = 0;
                netInterest = amount * (interest / 100) * months;
                return netInterest;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public decimal Accrued(decimal threshold, decimal amount, int months)
        {
            try
            {
                if (amount < threshold)
                {
                    return Total(amount, 50, months);
                }
                else
                {
                    return Total(amount, 100, months);
                }
            }
            catch (Exception)
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
