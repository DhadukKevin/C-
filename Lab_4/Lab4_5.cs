using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    internal interface Calculate
    {
        int Addition(int a, int b);
        int Substraction(int a, int b);
    }
    class Result : Calculate
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : "); 
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter b : "); 
            int b = Convert.ToInt32(Console.ReadLine()); 

            Result obj = new Result();
            Console.WriteLine("Addition : " + obj.Addition(a, b));
            Console.WriteLine("Substraction : " + obj.Substraction(a, b));
        }
    }
}
