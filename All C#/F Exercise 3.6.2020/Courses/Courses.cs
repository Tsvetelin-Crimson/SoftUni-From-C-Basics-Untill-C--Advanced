using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Courses
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokensInput = input.Split(" : ");
                string course = tokensInput[0],
                    name = tokensInput[1];
                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();
                }
                courses[course].Add(name);
            }

            

            foreach (var item in courses.OrderByDescending(k => k.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}" + 
                    "\n-- " + string.Join("\n-- ", item.Value.OrderBy(k => k).ToList()));
            }


        }
    }
}
