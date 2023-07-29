
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);

            Console.WriteLine("array list");
            PrintDetails();

            // Remove at specific index
            arr.Remove(1);
            Console.WriteLine("After Remove");
            PrintDetails();

            // Remove from given index to given step
            arr.RemoveRange(2, 3);
            Console.WriteLine("After RemoveRange(2,3)");
            PrintDetails();

            // clear all
            arr.Clear();

            void PrintDetails()
            {
                foreach (int i in arr)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
