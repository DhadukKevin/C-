//Write program to prompt a user to input his/her name and country name and then output will be shown as given: Hello<yourname> from country <countryname>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Country : ");
            string country = Console.ReadLine();

            Console.WriteLine($"Hello {name} from country {country}");
        }
    }
}
