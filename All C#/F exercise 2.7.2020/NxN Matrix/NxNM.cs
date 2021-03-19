using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxN_Matrix
{
    class NxNM
    {
        static void Main(string[] args)
        {
            int nInMatrix = int.Parse(Console.ReadLine());

            printNxNRectangle(nInMatrix);
        }

        static void printNxNRectangle(int n)
        {
            for (int collums = 0; collums < n; collums++)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
