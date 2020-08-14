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
            var inputAmount = Console.ReadLine();
            decimal.TryParse(inputAmount, out var amount);

            Console.WriteLine("Enter interest");
            var inputInterest = Console.ReadLine();
            decimal.TryParse(inputInterest, out var interest);

            Console.WriteLine("Enter duration in months");
            var inputMonths = Console.ReadLine();
            Int32.TryParse(inputMonths, out var months);

            Console.WriteLine("Hello Customer");

            Console.WriteLine(prog.Deposit(name, amount, interest, months));
            Console.Read();
            Console.WriteLine("Total expected amount is " + prog.Total(amount, interest, months));

        }

        public string Deposit(string name, decimal amount, decimal interest, int months)
        {
            //add the months entered with today's date and format it to string
            var realMonth = DateTime.Today.AddMonths(months).ToString("MMMM");

            return $"Welcome {name}, your total should be ready in {realMonth}. Thanks";
        }

        public decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal total = 0;

                // calculate the interest of the amount entered 
                var singleInterest = (interest / 100 * amount);

                // calculate the net interest for the entered month
                var netInterest = singleInterest * months;

                //total amount increase per month without net interest
                var monthlyAmountIncrease = amount * months;

                //add all together
                total = monthlyAmountIncrease + netInterest;

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

                // calculate the interest of the amount entered 
                var singleInterest = (interest / 100 * amount);

                // calculate the net interest for the entered month
                netInterest = singleInterest * months;

                return netInterest;

            }
            catch (Exception)
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
            catch (Exception)
            {

                return -1;
            }

        }
    }

}
