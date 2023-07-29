//Write a programs to Find Area of Square, Rectangle and Circle using
//Method Overloading.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Area(2);
            program.Area(2, 3);
            program.Area(12.2);
        }

        public void Area(double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area Of Circle = "+area);
        }

        public void Area(double b,double h)
        {
            double area =  b * h;
            Console.WriteLine("Area Of Rectangle = " + area);
        }

        public void Area(int l)
        {
            double area = l * l;
            Console.WriteLine("Area Of Squre = " + area);
        }
    }
}
