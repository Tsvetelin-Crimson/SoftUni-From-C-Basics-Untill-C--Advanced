using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class FastF
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();


            for (int i = 0; i < orders.Length; i++)
            {
                int currOrder = orders[i];
                queue.Enqueue(currOrder);
            }

            int biggestOrder = 0;

            while (queue.Any())
            {
                int currOrder = queue.Peek();

                if (currOrder > biggestOrder)
                {
                    biggestOrder = currOrder;
                }
                if (currOrder > food)
                {
                    break;
                }
                else
                {

                    food -= currOrder;
                    queue.Dequeue();
                }
            }

            Console.WriteLine(biggestOrder);

            if (queue.Any())
            {
                Console.Write($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
