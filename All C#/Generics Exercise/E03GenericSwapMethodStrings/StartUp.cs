using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace E03GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // could have used box, made a different class that stores and swaps them and use the toString override to print them using StringBuilder 
            Swapper<int> swapper = new Swapper<int>();
            for (int i = 0; i < n; i++)
            {
                int item = int.Parse(Console.ReadLine());

                swapper.Add(item);
            }

            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstIndex = indexes[0],
             secondIndex = indexes[1];
            swapper.Swap(firstIndex, secondIndex);
            Type t = typeof(int);
            foreach (var item in swapper.List)
            {
                Console.WriteLine($"{t.FullName}: {item}");
            }

        }
    }
}
