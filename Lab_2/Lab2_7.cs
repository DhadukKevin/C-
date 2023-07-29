//Write a program to calculate the nPr. (nPr = n! / (n - r)!)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact(int x)
            {
                if (x <= 1)
                {
                    return 1;
                }
                return x * fact(x - 1);
            }

            int nPr(int a, int b)
            {
                return fact(a) / fact(a - b);
            }

            Console.Write("Enter N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter R : ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nPr(n, r));
        }
    }
}
