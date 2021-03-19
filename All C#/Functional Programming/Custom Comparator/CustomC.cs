using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Custom_Comparator
{
    class CustomC
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Array.Sort(nums);

            Array.Sort(nums, (x, y) =>
           {
               int res = 0;

               if (x % 2 == 0 && y % 2 != 0)
               {
                   res = -1;
               }
               else if (x % 2 != 0 && y % 2 == 0)
               {
                   res = 1;
               }
               else
               {
                   res = x.CompareTo(y);
               }
               return res;
           });

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
