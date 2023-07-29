using System;

namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter n1: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter n2: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
