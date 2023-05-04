using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter principal amount: ");
            double P = double.Parse(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int Y = int.Parse(Console.ReadLine());

            Console.Write("Enter interest rate: ");
            double R = double.Parse(Console.ReadLine());

            double monthlyPayment = LoanUtils.monthlyPayment(P, Y, R);

            Console.WriteLine($"Monthly Payment: {monthlyPayment}");
        }
    }
}
