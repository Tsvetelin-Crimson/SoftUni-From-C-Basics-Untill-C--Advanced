using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class SquaresIM
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowDimention = dimentions[0],
                colDimention = dimentions[1];

            char[,] matrix = new char[rowDimention, colDimention];

            for (int row = 0; row < rowDimention; row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < colDimention; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int numberOf2x2Squares = 0;

            for (int row = 0; row < rowDimention - 1; row++)
            {
               
                for (int col = 0; col < colDimention - 1; col++)
                {
                    char currChar = matrix[row, col];

                    if (currChar == matrix[row, col + 1] && currChar == matrix[row + 1, col] && currChar == matrix[row + 1, col + 1])
                    {
                        numberOf2x2Squares++;
                    }
                }
            }

            Console.WriteLine(numberOf2x2Squares);
        }
    }
}
