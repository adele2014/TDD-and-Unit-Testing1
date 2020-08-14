﻿using System;
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
            DateTime due = DateTime.Now.AddMonths(months);
            return $"Welcome {name}, your total should be ready in {due:MMMM}. Thanks";
        }

        public decimal Total(decimal amount, decimal interest, int months)
        {
            try
            {
                decimal total = (amount * months) + ((amount * (interest / 100)) * months);
                //----- ur logic

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
                decimal netInterest = (amount * interest / 100) * months;
                //----- ur logic

                return netInterest;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        //public decimal Accrued(decimal interest, int months)
        //{
        //    try
        //    {
        //        decimal netInterest = 0;
        //        //----- ur logic

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