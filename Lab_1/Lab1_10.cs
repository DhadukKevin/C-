//Write a program to Swapping without using third variable.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            Console.WriteLine($"Before Swaping \na={a} \nb={b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"After Swaping \na={a} \nb={b}");

        }
    }
}
