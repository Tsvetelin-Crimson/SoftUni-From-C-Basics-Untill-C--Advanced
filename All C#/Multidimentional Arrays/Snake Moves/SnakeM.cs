using System;
using System.Linq;

namespace Snake_Moves
{
    class SnakeM
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] isle = new char[dimentions[0], dimentions[1]];

            string snake = Console.ReadLine();
            int counter = 0;
            bool isFromLeft = true;
            for (int row = 0; row < dimentions[0]; row++)
            {

                for (int col = 0; col < dimentions[1]; col++)
                {
                    if (isFromLeft)
                    {
                        isle[row, col] = snake[counter % snake.Length];
                    }
                    else
                    {
                        isle[row, dimentions[1] - 1 - col] = snake[counter % snake.Length];
                    }
                    counter++;
                }
                isFromLeft = !isFromLeft;
            }


            for (int row = 0; row < dimentions[0]; row++)
            {
                for (int col = 0; col < dimentions[1]; col++)
                {
                    Console.Write(isle[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
