//Create a class named RBI with calculateInterest() method.Create another
//classes HDFC, SBI, ICICI which overrides calculateInterest() method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RBI rbi = new RBI();
            SBI sbi = new SBI();
            HDFC hdfc= new HDFC();
            ICICI icici = new ICICI();

            rbi.calculateInterest();
            sbi.calculateInterest();
            hdfc.calculateInterest();
            icici.calculateInterest();
        }
    }

    class RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Intrest of RBI");
        }
    }

    class SBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Intrest of SBI");
        }
    }

    class HDFC
    {
        public void calculateInterest()
        {
            Console.WriteLine("Intrest of HDFC");
        }
    }
    class ICICI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Intrest of ICICI");
        }
    }
}
