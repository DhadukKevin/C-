using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Clc clc = new Clc();
        Console.WriteLine("Enter Number A : ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Number B : ");
        double b = Convert.ToDouble(Console.ReadLine());

        MyDelegate<double> add = new MyDelegate<double>(clc.add);
        MyDelegate<double> sub = new MyDelegate<double>(clc.sub);
        MyDelegate<double> mul = new MyDelegate<double>(clc.mul);
        MyDelegate<double> div = new MyDelegate<double>(clc.div);

        Console.WriteLine($"{a} + {b} = {add(a, b)}");
        Console.WriteLine($"{a} - {b} = {sub(a, b)}");
        Console.WriteLine($"{a} * {b} = {mul(a, b)}");
        Console.WriteLine($"{a} / {b} = {div(a, b)}");
    }

    
}

public delegate T MyDelegate<T>(T a, T b);
class Clc
{
    public double add(double a, double b)
    {
        return a + b;
    }
    public double sub(double a, double b)
    {
        return a - b;
    }
    public double mul(double a, double b)
    {
        return a * b;
    }
    public double div(double a, double b)
    {
        return (a / b);
    }
}
