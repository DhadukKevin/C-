using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb4_6
{
    interface Shape
    {
        double Circle(double r);
        double Triangle(double b, double h);
        double Square(double l);
    }
    internal class Program : Shape
    {
        public double Circle(double r)
        {
            return Math.Round(Math.PI * r * r);
        }
        public double Triangle(double b, double h)
        {
            return Math.Round((b * h) / 2);
        }
        public double Square(double l)
        {
            return (l * l);
        }
        static void Main(string[] args)
        {
            Program obj = new Program(); Console.WriteLine("Area of Circle: {0}", obj.Circle(10)); 
            Console.WriteLine("Area of Triangle: {0}", obj.Triangle(20, 10)); 
            Console.WriteLine("Area of Square: {0}", obj.Square(15));
        }
    }
}
