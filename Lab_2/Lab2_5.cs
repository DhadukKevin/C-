//Write a program to print Fibonacci series.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.Write(a+" ");
            Console.Write(b+" ");
            int fibbo = 0;
            for (int i=2;i<10;i++)
            {
                fibbo = a + b;
                Console.Write(fibbo + " ");
                a = b;
                b=fibbo;
            }
        }
    }
}
