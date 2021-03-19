using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    class Sixth
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int firstDigit = input / 100,
                secondDigit = input / 10 % 10,
                thirdDigit = input % 10;
            for (int firstDigitOfTable = 1; firstDigitOfTable <= thirdDigit; firstDigitOfTable++)
            {
                for (int secondDigitOFTable = 1; secondDigitOFTable <= secondDigit; secondDigitOFTable++)
                {
                    for (int thirdDigitOfTable = 1; thirdDigitOfTable <= firstDigit; thirdDigitOfTable++)
                    {
                        Console.WriteLine($"{firstDigitOfTable} * {secondDigitOFTable} * {thirdDigitOfTable} = {firstDigitOfTable * secondDigitOFTable * thirdDigitOfTable};");
                    }
                }
            }
        }
    }
}
