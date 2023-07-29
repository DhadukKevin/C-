using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            // insert element in queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("Queue");
            PrintQueue(queue);

            // return element which is inserted first
            queue.Dequeue();
            Console.WriteLine("After Dequeue :");
            PrintQueue(queue);


            // return true if queue contains given element
            Console.WriteLine($"queue contains 4 : {queue.Contains(3)}");

            //clear all
            queue.Clear();
        }
        static void PrintQueue(Queue<int> queue) 
        {
            foreach (var item in queue) 
            { 
                Console.WriteLine(item); 
            } 
        }
    }
}
