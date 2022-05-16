using System;
using System.Collections.Generic;

namespace ConsoleAppQueueFIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("First in line");
            myQueue.Enqueue("Second in line");
            myQueue.Enqueue("Third in line");
            myQueue.Enqueue("Last in line");

            // Peek "looks" at the first item in the queue without removing it.
            Console.WriteLine($"Peek() returned:\n{myQueue.Peek()}");

            // Dequeue pulls the next item from the FRONT of the queue
            Console.WriteLine($"The first Dequeue() returned:\n{myQueue.Dequeue()}");
            Console.WriteLine($"The second Dequeue() returned:\n{myQueue.Dequeue()}");

            // Clear removes all of the items from the queue
            Console.WriteLine($"Count before Clear() returned:\n{myQueue.Count}");
            myQueue.Clear();
            Console.WriteLine($"Count after Clear() returned:\n{myQueue.Count}");
        }
    }
}
