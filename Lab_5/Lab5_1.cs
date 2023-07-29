//Write a program using method overloading by changing datatype of
//arguments to perform addition of two integer numbers and two float
//numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter Int N1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Int N2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Double N2: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Double N2: ");
            double n4 = Convert.ToDouble(Console.ReadLine());

            p.addition(n1, n2);
            p.addition(n3, n4);

        }

        public void addition(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine(ans);
        }
        public void addition(double a, double b)
        {
            double ans = a + b; 
            Console.WriteLine(ans);
        }
    }
}
