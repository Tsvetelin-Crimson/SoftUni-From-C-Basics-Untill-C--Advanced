using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Cound
{
    class VowelsC
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintVowelNumb(input);
        }

        static void PrintVowelNumb(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y' 
                   || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U' || input[i] == 'Y') 
                {
                    count++;
                }
                
                
            }
            Console.WriteLine(count);

        }



    }
}
