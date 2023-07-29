using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "Hii, My Name Is Dhaduk Kevin"; 
            Console.WriteLine(line); 
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None); 
            string word = ""; 
            int ctr = 0; 
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s; 
                    ctr = s.Length;
                }
            }
            Console.WriteLine("Longest word: {0}", word);
        }
    }
}
