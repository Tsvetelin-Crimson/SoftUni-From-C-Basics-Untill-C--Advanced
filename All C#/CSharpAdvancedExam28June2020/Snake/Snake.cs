using System;
using System.Linq;

namespace Snake
{
    class Snake
    {
        static void Main(string[] args)
        {
            int territorySize = int.Parse(Console.ReadLine());
            char[,] territory = new char[territorySize, territorySize];

            int snakeRow = -1;
            int snakeCol = -1;

            int firstBurrowRow = -1;
            int firstBurrowCol = -1;
            int secondBurrowRow = -1;
            int secondBurrowCol = -1;


            for (int row = 0; row < territorySize; row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < territorySize; col++)
                {
                    territory[row, col] = currRow[col];

                    if (currRow[col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (currRow[col] == 'B' && firstBurrowCol == -1)
                    {
                        firstBurrowRow = row;
                        firstBurrowCol = col;
                    }
                    else if (currRow[col] == 'B')
                    {
                        secondBurrowRow = row;
                        secondBurrowCol = col;
                    }
                }
            }
            int foodCount = 0;
            bool isOutOfBounds = false;
            while (foodCount < 10)
            {
                territory[snakeRow, snakeCol] = '.';
                string direction = Console.ReadLine();
                switch (direction)
                {
                    case "up":
                        snakeRow--;
                        break;
                    case "down":
                        snakeRow++;
                        break;
                    case "left":
                        snakeCol--;
                        break;
                    case "right":
                        snakeCol++;
                        break;
                    default:
                        break;
                }
                if (snakeRow == -1 || snakeRow == territorySize || snakeCol == -1 || snakeCol == territorySize)
                {
                    Console.WriteLine("Game over!");
                    isOutOfBounds = true;
                    break;
                }

                if (territory[snakeRow, snakeCol] == '*')
                {
                    foodCount++;
                }

                if (territory[snakeRow, snakeCol] == 'B')
                {
                    if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                    {
                        territory[snakeRow, snakeCol] = '.';
                        snakeRow = secondBurrowRow;
                        snakeCol = secondBurrowCol;
                    }
                    else
                    {
                        territory[snakeRow, snakeCol] = '.';
                        snakeRow = firstBurrowRow;
                        snakeCol = firstBurrowCol;
                    }
                }

            }

            if (!isOutOfBounds)
            {
                territory[snakeRow, snakeCol] = 'S';
            }
            if (foodCount == 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodCount}");

            for (int row = 0; row < territorySize; row++)
            {
                for (int col = 0; col < territorySize; col++)
                {
                    Console.Write(territory[row, col]);
                }
                Console.WriteLine();
            }

            ;
        }
    }
}
