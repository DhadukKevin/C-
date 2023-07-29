//Write a program to find out whether a given year is a leap year or not.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 400 == 0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else if(year % 100 == 0)
            {
                Console.WriteLine($"{year} is not leap year");
            }
            else if (year % 4 ==0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not leap year");
            }
        }
    }
}
