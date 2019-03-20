using System;
using System.Collections.Generic;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("First");
            myQueue.Enqueue("Second");
            myQueue.Enqueue("Third");
            myQueue.Enqueue("Fourth");
            Console.WriteLine("Queue:");
            while (myQueue.Count >= 1)
            {
                if (!String.IsNullOrEmpty(myQueue.Peek()))
                {
                    Console.WriteLine(myQueue.Dequeue());
                }
            }
            Stack<string> myStack = new Stack<string>();
            myStack.Push("First");
            myStack.Push("Second");
            myStack.Push("Third");
            myStack.Push("Fourth");
            Console.WriteLine("STack:");
            while (myStack.Count >= 1)
            {
                if (!String.IsNullOrEmpty(myStack.Peek()))
                {
                    Console.WriteLine(myStack.Pop());
                }
            }
            Console.ReadLine();
        }
    }
}
