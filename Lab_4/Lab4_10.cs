using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character : ");
            char c = Console.ReadLine().ToCharArray()[0]; 
            char ans; 
            if (Char.IsUpper(c)) 
                ans = Char.ToLower(c); 
            else 
                ans = Char.ToUpper(c); 

            Console.WriteLine("Changed case of character : " + ans);
        }
    }
}
