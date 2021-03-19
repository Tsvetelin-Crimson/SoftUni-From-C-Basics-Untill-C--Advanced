using System;
using System.Linq;

namespace ConsoleApp1
{
    class JaggedAM
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] arrInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jagged[row] = arrInput;
            }

            for (int row = 0; row < n - 1; row++)
            {
                double[] rowOne = jagged[row];
                double[] rowTwo = jagged[row + 1];

                if (rowOne.Length == rowTwo.Length)
                {
                    jagged[row] = rowOne.Select(e => e * 2).ToArray();
                    jagged[row + 1] = rowTwo.Select(e => e * 2).ToArray();
                }
                else
                {
                    jagged[row] = rowOne.Select(e => e / 2).ToArray();
                    jagged[row + 1] = rowTwo.Select(e => e / 2).ToArray();
                }
            }


            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string keyword = tokens[0];
                int row = int.Parse(tokens[1]),
                    col = int.Parse(tokens[2]),
                    value = int.Parse(tokens[3]);

                if (!IsValidCell(jagged, row, col))
                {
                    continue;
                }
                
                if (keyword == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (keyword == "Subtract")
                {
                    jagged[row][col] -= value;
                }
            }


            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }

        

        private static bool IsValidCell(double[][] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length;
        }
    }

    
}
