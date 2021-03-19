using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class SetsOE
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSetLength = lenghts[0];
            int secondSetLength = lenghts[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }
            for (int i = 0; i < secondSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));

        }
    }
}
