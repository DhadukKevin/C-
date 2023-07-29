//Write a program to find out Simple Interest using function. (I = PRN / 100)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.interest(10000, 10, 2);
        }

        public void interest(double p,double r,double n)
        {
            double I = (p * r * n) / 100;
            Console.WriteLine($"interest = {I}");
        }
    }
}
