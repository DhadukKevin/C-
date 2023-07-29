//Write a program to calculate area of Square, Rectangle and Circle.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1 for area of circle \nEnter 2 for area of square \nEnter 3 for area of rectangle");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1 :
                    Console.Write("Enter radius : ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    double area_circle = 3.14 * r * r;
                    Console.WriteLine(area_circle);
                    break;

                case 2:
                    Console.Write("Enter lenght : ");
                    int l = Convert.ToInt32(Console.ReadLine());
                    double area_square = l * l;
                    Console.WriteLine(area_square);
                    break;

                case 3:
                    Console.Write("Enter lenght : ");
                    int l1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter lenght : ");
                    int l2 = Convert.ToInt32(Console.ReadLine());
                    double area_rectangle = l1 * l2;
                    Console.WriteLine(area_rectangle);
                    break;
            }
            

        }
    }
}
