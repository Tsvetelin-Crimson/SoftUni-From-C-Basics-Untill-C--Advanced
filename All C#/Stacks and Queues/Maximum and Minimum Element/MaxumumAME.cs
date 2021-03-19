﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class MaxumumAME
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            

            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (commands[0] == 1)
                {
                    stack.Push(commands[1]);

                   
                }
                else if (commands[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        int currNum = stack.Pop();
                    }
                }
                else if (commands[0] == 3)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (commands[0] == 4)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }


            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
