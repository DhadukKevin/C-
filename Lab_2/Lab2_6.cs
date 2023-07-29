//Write a program that takes a number as input and displays its equivalent binary form.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] binaryNum = new int[32];

            int i = 0;
            while (n > 0)
            {
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }

            for(int j=i-1;j>=0;j--)
            {
                Console.Write(binaryNum[j]);
            }
            Console.WriteLine();
        }
    }
}
