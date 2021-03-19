using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class SoftUniP
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registered = new Dictionary<string, string>();
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokensInput = input.Split();

                string cmd = tokensInput[0];
                string name = tokensInput[1];
                if (cmd == "unregister")
                {
                    if (registered.ContainsKey(name))
                    {
                        registered.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
                else if (cmd == "register")
                {
                    string plateNumber = tokensInput[2];

                    if (!registered.ContainsKey(name))
                    {
                        registered[name] = plateNumber;
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registered[name]}");
                    }
                }
            }

            foreach (var item in registered)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
