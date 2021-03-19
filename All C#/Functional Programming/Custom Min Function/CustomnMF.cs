using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace Custom_Min_Function
{
    class CustomnMF
    {
        static void Main(string[] args)
        {
            Func<int[], int> f = f =>
            {
                int smallest = int.MaxValue;
                for (int i = 0; i < f.Length; i++)
                {
                    if (f[i] < smallest)
                    {
                        smallest = f[i];
                    }
                }
                return smallest;
            };
            
            int[] input =  Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(f(input));
        }
    }
}
