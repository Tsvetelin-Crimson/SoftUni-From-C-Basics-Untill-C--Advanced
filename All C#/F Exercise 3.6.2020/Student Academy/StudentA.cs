using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class StudentA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> studends = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studends.ContainsKey(name))
                {
                    studends[name] = grade;
                }
                else
                {
                    studends[name] = (studends[name] + grade) / 2;
                }
            }

            studends = studends.Where(a => a.Value >= 4.5).OrderByDescending(a => a.Value).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in studends)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
