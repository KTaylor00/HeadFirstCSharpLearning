using System;
using System.Collections.Generic;

namespace ConsoleAppStackLIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("First in line");
            myStack.Push("Second in line");
            myStack.Push("Third in line");
            myStack.Push("Last in line");

            // Peek with a stack works just like it does with a queue.
            Console.WriteLine($"Peek() returned:\n{myStack.Peek()}");

            // Pop pulls the next item from the BOTTOM of the stack
            Console.WriteLine($"The first Dequeue() returned:\n{myStack.Pop()}");
            Console.WriteLine($"The second Dequeue() returned:\n{myStack.Pop()}");

            // Clear removes all of the items from the stack
            Console.WriteLine($"Count before Clear() returned:\n{myStack.Count}");
            myStack.Clear();
            Console.WriteLine($"Count after Clear() returned:\n{myStack.Count}");
        }
    }
}
