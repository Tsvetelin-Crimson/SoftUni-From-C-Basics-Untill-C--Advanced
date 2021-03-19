using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_in_Range
{
    class CharachtersIR
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char firstInput = char.Parse(Console.ReadLine()),
                secondInput = char.Parse(Console.ReadLine());

            PrintAllASCII(firstInput, secondInput);
        }

        static void PrintAllASCII(char first, char second)
        {
            if (first > second)
            {
                for (int i = first - 1; i > second; i--)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = first + 1; i < second; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }

    }
}
