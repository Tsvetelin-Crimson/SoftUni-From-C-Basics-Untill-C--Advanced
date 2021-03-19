using System;
using System.Collections.Generic;

namespace A_miner_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            string resourse;
            while ((resourse = Console.ReadLine()) != "stop")
            {
                int amount = int.Parse(Console.ReadLine());

                if (resourses.ContainsKey(resourse))
                {
                    resourses[resourse] += amount;
                }
                else
                {
                    resourses[resourse] = amount;
                }
            }

            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
