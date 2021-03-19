using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Chars
{
    class SumC
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine()),
                sum = 0;

            for (int i = 0; i < numberOfChars; i++)
            {
                char repeatedInput = char.Parse(Console.ReadLine()); //could be string and without char.parse 
                                                                    // chars are saved as numbers
                sum += repeatedInput;
            }

            Console.WriteLine($"The sum equals: {sum}");


        }
    }
}
