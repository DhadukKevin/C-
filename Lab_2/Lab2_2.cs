//The marks obtained by a student in 5 different subjects are input through the keyboard. The student gets a grade as per the following rules:
//a.Percentage above or equals to 60-first grade
//b. Percentage between 50 to 59-second grade
//c. Percentage between 40 and 49-Third grade
//d. Percentage less than 40-poor Grade
//Write a program to assign the grade obtained by the student.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Sub1 Marks : ");
            double sub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Sub2 Marks : ");
            double sub2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Sub3 Marks : ");
            double sub3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Sub4 Marks : ");
            double sub4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Sub5 Marks : ");
            double sub5 = Convert.ToDouble(Console.ReadLine());

            double Percentage = (sub1 + sub2 + sub3 + sub4 + sub5) / 5;
            
            if(Percentage <= 40)
            {
                Console.WriteLine($"poor grade with {Percentage}");
            }
            else if(Percentage > 40 && Percentage <=49)
            {
                Console.WriteLine($"third grade with {Percentage}");
            }
            else if (Percentage > 49 && Percentage <= 59)
            {
                Console.WriteLine($"second grade with {Percentage}");
            }
            else
            {
                Console.WriteLine($"firts grade with {Percentage}");
            }
        }
    }
}
