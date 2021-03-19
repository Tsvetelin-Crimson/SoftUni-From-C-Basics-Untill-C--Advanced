using System;
using System.Linq;

namespace Multidimentional_Arrays
{
    class DiagonalD
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());
            int[,] square = new int[dimentions, dimentions];

            for (int row = 0; row < dimentions; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < dimentions; col++)
                {
                    square[row, col] = input[col];
                }
            }

            int firstDiagonalSum = 0,
                secondDiagonalSum = 0,
                counter = dimentions - 1;

            for (int row = 0; row < dimentions; row++)
            {
                firstDiagonalSum += square[row, row];
                secondDiagonalSum += square[row, counter--];
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
