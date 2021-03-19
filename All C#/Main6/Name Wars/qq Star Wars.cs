using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(),
                winner = "";
            int winnerSum = 0;

            while (name != "STOP")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];                    
                }
                if (winnerSum < sum)
                {
                    winnerSum = sum;
                    winner = name;
                }
                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} - {winnerSum}!");


        }
    }
}
