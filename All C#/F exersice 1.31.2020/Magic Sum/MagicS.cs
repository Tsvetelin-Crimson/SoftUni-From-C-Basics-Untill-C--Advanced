using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Sum
{
    class MagicS
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int currIndex = 0; currIndex < arr.Length; currIndex++)
            {
                for (int nextIndex = currIndex + 1; nextIndex < arr.Length; nextIndex++)
                {
                    if (arr[currIndex] + arr[nextIndex] == magicNumber)
                    {
                        Console.WriteLine($"{arr[currIndex]} {arr[nextIndex]}");
                    }
                }
            }


        }
    }
}
