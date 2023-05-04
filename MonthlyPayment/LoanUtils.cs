using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyPayment
{
    internal class LoanUtils
    {
            public static double monthlyPayment(double P, int Y, double R)
            {
                int n = 12;  
                int t = Y * n;  
                double r = R / (n * 100);  
                double A = P * Math.Pow(1 + r, t);
                double monthlyPayment = A * r / (1 - Math.Pow(1 + r, -t));

                return monthlyPayment;
            }
    }
}
