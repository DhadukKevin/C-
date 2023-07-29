//Body Mass Index (BMI) is a measure of health on weight. It can be calculated by taking your weight in kilograms and dividing by the square of your height in meters.
//Write a program that prompts the user to enter a weight in pounds and height in inches and displays the BMI.
//(Note: -1 pound = 0.45359237 Kg and 1 inch = 0.0254 meters)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Weight : ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height : ");
            double h = Convert.ToDouble(Console.ReadLine());

            w = w * 0.45359237;
            h = h * 0.0254;

            double BMI = w / (h * h);

            Console.WriteLine($"Your BMI is {BMI}");
            Console.ReadLine();
        }
    }
}
