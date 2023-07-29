


//Create a class Hospital with HospitalDetails() method.Create another
//classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
//HospitalDetails() method.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            MyDelegate Mydel = new MyDelegate(p.Factorial);

            Console.WriteLine(Mydel(n));
        }

        delegate int MyDelegate(int n);
        public int Factorial(int n)
        {
            int fact = 1;

            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}

