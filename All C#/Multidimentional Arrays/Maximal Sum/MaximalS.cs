using System;
using System.Linq;

namespace Maximal_Sum
{
    class MaximalS
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowDimention = dimentions[0],
                colDimention = dimentions[1];

            int[,] matrix = new int[rowDimention, colDimention];

            for (int row = 0; row < rowDimention; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < colDimention; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int rowOfSquare = -1;
            int colOFSquare = -1;
            int maxSum = int.MinValue;
            for (int row = 0; row < rowDimention - 2; row++)
            {

                for (int col = 0; col < colDimention - 2; col++)
                {
                    int currSum = 0;
                    currSum += matrix[row, col];
                    currSum += matrix[row, col + 1];
                    currSum += matrix[row, col + 2];
                    currSum += matrix[row + 1, col];
                    currSum += matrix[row + 1, col + 1];
                    currSum += matrix[row + 1, col + 2];
                    currSum += matrix[row + 2, col];
                    currSum += matrix[row + 2, col + 1];
                    currSum += matrix[row + 2, col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        colOFSquare = col;
                        rowOfSquare = row;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            //check if 
           if (rowOfSquare != -1)
           {
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{matrix[rowOfSquare + i, colOFSquare + j]} ");
                    }
                    Console.WriteLine();
                }
           }

        }
    }
}
