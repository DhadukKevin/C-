using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> StudentNames = new List<string>();
            StudentNames.Add("Kevin");
            StudentNames.Add("Jenil");
            StudentNames.Add("Nevil");
            StudentNames.Add("Jadoo");
            StudentNames.Add("Deep");
            StudentNames.Add("Krish");
            StudentNames.Add("kkr");

            Console.WriteLine("Student Names:");
            PrintList(StudentNames);

            // Remove from specific index
            Console.WriteLine("After Remove At 1:");
            StudentNames.RemoveAt(1);
            PrintList(StudentNames);

            // Remove from given index to given step
            Console.WriteLine("After Remove between range 2,4:");
            StudentNames.RemoveRange(2, 3);
            PrintList(StudentNames);

            //clear all
            StudentNames.Clear();
        }
        static void PrintList(List<string> list)
        {
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
