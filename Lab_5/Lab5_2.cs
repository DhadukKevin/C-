//Write a program using method overloading by changing number of
//arguments to calculate area of square and rectangle.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Multiplication(2, 3);
            p.Multiplication(2, 3, 4);
        }

        public void Multiplication(int a,int b)
        {
            int ans = a * b;
            Console.WriteLine(ans);
        }
        public void Multiplication(int a, int b,int c)
        {
            int ans = a * b * c;
            Console.WriteLine(ans);
        }
    }
}
