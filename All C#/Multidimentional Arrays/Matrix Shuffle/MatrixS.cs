using System;
using System.Linq;

namespace Matrix_Shuffle
{
    class MatrixS
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowDimention = dimentions[0],
                colDimention = dimentions[1];

            string[,] matrix = new string[rowDimention, colDimention];

            for (int row = 0; row < rowDimention; row++)
            {
                string[] matrixInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < colDimention; col++)
                {
                    matrix[row, col] = matrixInput[col];
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] != "swap" || tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(tokens[1]),
                    col1 = int.Parse(tokens[2]),
                    row2 = int.Parse(tokens[3]),
                    col2 = int.Parse(tokens[4]);


                bool firstCoordsCorrect = ValidateCell(matrix, row1, col1);
                bool secondCoordsCorrect = ValidateCell(matrix, row2, col2);

                if (!firstCoordsCorrect || !secondCoordsCorrect)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string temp = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temp;

                for (int row = 0; row < rowDimention; row++)
                {
                    for (int col = 0; col < colDimention; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }


        private static bool ValidateCell(string[,] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 && row <= matrix.GetLength(0) && col <= matrix.GetLength(1);
        }
    }
}
