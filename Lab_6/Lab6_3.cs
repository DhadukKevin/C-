using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            //insert element
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Stack:");
            PrintStack(stack);

            // pop topest element
            stack.Pop();
            Console.WriteLine("Stack after pop:");
            PrintStack(stack);

            // returns top most element
            int peek = stack.Peek();
            Console.WriteLine($"Top Element: {peek}");

            //return true if element is in stack
            Console.WriteLine($"4 is available in stack : {stack.Contains(4)}");

            //clear all elements
            stack.Clear();
            
        }
        static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
