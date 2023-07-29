//Write a program to calculate the size of the area in square-feet based on Specified length and width.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Lenght in feet : ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width in feet : ");
            double w = Convert.ToDouble(Console.ReadLine());

            double area = l * w;

            Console.WriteLine($"Area = {area}");
        }
    }
}
