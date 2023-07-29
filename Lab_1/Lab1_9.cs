//Write a program to find maximum numbers from given 3 numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if(a>c)
                {
                    Console.WriteLine($"{a} is largest");
                }
                else
                {
                    Console.WriteLine($"{c} is largest");
                }
            }
            else if (b > c) 
            {
                Console.WriteLine($"{b} is largest");
            }
            else
            {
                Console.WriteLine($"{c} is largest");
            }
        }
    }
}
