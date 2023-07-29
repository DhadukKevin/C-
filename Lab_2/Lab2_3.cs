//Write a program to check prime number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for(int i=2 ; i<a; i++)
            {
                if (a % i == 0)
                {
                    flag = true; 
                    break;
                }
            }

            if(flag)
            {
                Console.WriteLine($"{a} is no prime");
            }
            else
            {
                Console.WriteLine($"{a} is prime");
            }
        }
    }
}
