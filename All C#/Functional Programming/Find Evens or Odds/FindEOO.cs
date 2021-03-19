using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class FindEOO
    {
        static void Main(string[] args)
        {
            int[] paramaters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int start = paramaters[0];
            int end = paramaters[1];

            Predicate<string> evenOrOdd = i => i == "odd";

            Func<int, int, List<int>> generateAllNumbs = (start, end) =>
            {
                List<int> nums = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);
                }
                return nums;
            };
            List<int> output = generateAllNumbs(start, end);
            Predicate<int> pred = n => n % 2 == 0;

            if (command == "odd")
            {
                pred = n => n % 2 != 0;
            }
            

            output = MyWhere(output, pred);

            Console.WriteLine(string.Join(' ', output));

        }

        private static List<int> MyWhere(List<int> input, Predicate<int> pred)
        {
            List<int> list = new List<int>();

            foreach (int num in input)
            {
                if (pred(num))
                {
                    list.Add(num);
                }
            }

            return list;
        }

    }
}
