using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Inventory
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string command;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] comTokens = command.Split(" - ");

                if (comTokens[0] == "Collect")
                {
                    if (!inventory.Contains(comTokens[1]))
                    {
                        inventory.Add(comTokens[1]);
                    }
                }
                else if (comTokens[0] == "Drop")
                {
                    inventory.Remove(comTokens[1]);
                }
                else if (comTokens[0] == "Combine Items")
                {
                    string[] items = comTokens[1].Split(":");
                    if (inventory.Contains(items[0]))
                    {
                        int index = inventory.IndexOf(items[0]) + 1;
                        inventory.Insert(index, items[1]);
                    }
                }
                else if (comTokens[0] == "Renew")
                {
                    if (inventory.Contains(comTokens[1]))
                    {
                        inventory.Remove(comTokens[1]);
                        inventory.Add(comTokens[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
