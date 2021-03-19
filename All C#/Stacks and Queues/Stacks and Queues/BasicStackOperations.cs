using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int push = commands[0];
            int pops = commands[1];
            int specialNum = commands[2];

            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < push; i++)
            {
                stack.Push(items[i]);
            }

            for (int i = 0; i < pops; i++)
            {
                stack.Pop();
            }

            
            if (stack.Contains(specialNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            
        }
    }
}
