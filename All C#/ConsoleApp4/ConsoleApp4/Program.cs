using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];
                int index = int.Parse(inputArr[1]);
                int value = int.Parse(inputArr[2]);

                if (command == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }

                    }
                }
                else if (command == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    if (index < 0 || index >= targets.Count || index + value >= targets.Count || index - value < 0)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        for (int i = 0; i < value * 2 + 1; i++)
                        {
                            targets.RemoveAt(index - value);
                        }
                    }
                }
            }



            Console.WriteLine(string.Join('|', targets));
        }
    }
}
