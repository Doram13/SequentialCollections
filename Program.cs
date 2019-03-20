using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
            //Queue<string> copyQueue = new Queue<string>(myQueue.ToArray());
            while (myQueue.Count >= 1)
            {
                if (!String.IsNullOrEmpty(myQueue.Peek()))
                {
                    Console.WriteLine(myQueue.Dequeue());
                }

            }
            Console.ReadLine();
        }
    }
}
