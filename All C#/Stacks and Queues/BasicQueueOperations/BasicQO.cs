using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class BasicQO
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int enq = commands[0];
            int deq = commands[1];
            int specialNum = commands[2];


            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < enq; i++)
            {
                queue.Enqueue(items[i]);
            }

            for (int i = 0; i < deq; i++)
            {
                queue.Dequeue();
            }


            if (queue.Contains(specialNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }

        }
    }
}
