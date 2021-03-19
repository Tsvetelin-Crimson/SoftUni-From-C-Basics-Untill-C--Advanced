using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int[] firstArr = new int[numberOfInputs];
            int[] secondArr = new int[numberOfInputs];
            
            for (int i = 0; i < numberOfInputs; i++)
            {
                int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] += inputArr[0];
                    secondArr[i] += inputArr[1];
                }
                else
                {
                    secondArr[i] += inputArr[0];
                    firstArr[i] += inputArr[1];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));

        }
    }
}
