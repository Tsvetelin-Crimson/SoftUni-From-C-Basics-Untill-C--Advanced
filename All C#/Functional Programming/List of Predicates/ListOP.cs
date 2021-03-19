using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class ListOP
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<Predicate<int>> requiredDivisions = new List<System.Predicate<int>>();
            List<int> dividees = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                dividees.Add(i);
            }
            foreach (int  num in dividers)
            {
                Predicate<int> currPred = n => n % num == 0;
                requiredDivisions.Add(currPred);
            }

            dividees = dividees.Where(n =>
            {
                bool isDivisible = true;
                foreach (var div in requiredDivisions)
                {
                    if (!div(n))
                    {
                        isDivisible = false;
                    }

                }
                return isDivisible;
            }).ToList();

            Console.WriteLine(string.Join(' ', dividees));
        }
    }
}
