using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Characters
{
    class MiddleC
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleSymbol(input);
        }

        static void PrintMiddleSymbol(string text)
        {
            if (text.Length % 2 == 0)
            {
                char firstLetter = text[text.Length / 2 - 1],
                     secondLetter = text[text.Length / 2];
                Console.WriteLine(firstLetter + "" + secondLetter);
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }


        }

    }
}
