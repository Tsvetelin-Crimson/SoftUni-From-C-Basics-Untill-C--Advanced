using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_numbs
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int lengthOfTriangle = int.Parse(Console.ReadLine());


            for (int row = 1; row <= lengthOfTriangle; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();


            }

        }
    }
}
