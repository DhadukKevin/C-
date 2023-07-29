using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    public abstract class Sum
    {
        public abstract int sumOfTwo(int n1, int n2);
        public abstract int sumOfThree(int n1, int n2, int n3);
    }
    internal class Program : Sum
    {
        public override int sumOfTwo(int a, int b)
        {
            return a + b;
        }
        public override int sumOfThree(int a, int b, int c)
        {
            return (a + b + c);
        }
        static void Main(string[] args)
        {
            Sum s = new Program(); 
            Console.WriteLine("SumOfTwo:" + s.sumOfTwo(1, 2));
            Console.WriteLine("SumOfThree:" + s.sumOfThree(1, 2, 3));
        }
    }
}
