using System;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());
            char[,] board = new char[dimentions, dimentions];

            for (int row = 0; row < dimentions; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < dimentions; col++)
                {
                    board[row, col] = input[col];
                }
                
            }

            int allRemoveKnights = 0;

            while (true)
            {
                int currAtt = 0;
                int biggestAttack = 0;
                int rowBiggestK = -1;
                int colBiggestK = -1;
                for (int row = 0; row < dimentions; row++)
                {
                    
                    for (int col = 0; col < dimentions; col++)
                    {
                        char ch = board[row, col];

                        if (ch == 'K')
                        {
                            currAtt = NumberOfAttacks(board, row, col);
                            if (currAtt > biggestAttack)
                            {
                                biggestAttack = currAtt;
                                rowBiggestK = row;
                                colBiggestK = col;
                            }
                        }
                    }
                }

                if (rowBiggestK == -1)
                {
                    break;
                }
                else
                {
                    board[rowBiggestK, colBiggestK] = '0';
                    allRemoveKnights++;
                }
            }


            Console.WriteLine(allRemoveKnights);
        }

        private static int NumberOfAttacks(char[,] board, int row, int col)
        {
            int counter = 0;
            int n = board.GetLength(0);
            //upper 4
            if (row - 2 >= 0  && col - 1 >= 0 && board[row - 2, col - 1] == 'K')
            {
                counter++;
            }

            if (row - 2 >= 0 && col + 1 < n && board[row - 2, col + 1] == 'K')
            {
                counter++;
            }

            if (row - 1 >= 0 && col - 2 >= 0 && board[row - 1, col - 2] == 'K')
            {
                counter++;
            }

            if (row - 1 >= 0 && col + 2 < n && board[row - 1, col + 2] == 'K')
            {
                counter++;
            }


            //lower 4
            if (row + 1 < n && col - 2 >= 0 && board[row + 1, col - 2] == 'K')
            {
                counter++;
            }

            if (row + 1 < n && col + 2 < n && board[row + 1, col + 2] == 'K')
            {
                counter++;
            }

            if (row + 2 < n && col - 1 >= 0 && board[row + 2, col - 1] == 'K')
            {
                counter++;
            }

            if (row + 2 < n && col + 1 < n && board[row + 2, col + 1] == 'K')
            {
                counter++;
            }
            return counter;
        }


    }
}
