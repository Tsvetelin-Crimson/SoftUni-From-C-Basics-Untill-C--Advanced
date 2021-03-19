using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine()),
                number2 = int.Parse(Console.ReadLine());

            for (int firstPwordDigit = 1; firstPwordDigit <= number1; firstPwordDigit++)
            {
                for (int secondPwordDigit = 1; secondPwordDigit <= number1; secondPwordDigit++)
                {
                    for (int thirdPwordDigit = 0; thirdPwordDigit < number2; thirdPwordDigit++)
                    {
                        for (int fourthPwordDigit = 0; fourthPwordDigit < number2; fourthPwordDigit++)
                        {
                            for (int fifhtPwordDigit = 1; fifhtPwordDigit <= number1; fifhtPwordDigit++)
                            {
                                if (fifhtPwordDigit >firstPwordDigit && fifhtPwordDigit > secondPwordDigit)
                                {                                 
                                    char thirdReal = (char)(thirdPwordDigit + 97);
                                    char fourthReal = (char)(fourthPwordDigit+ 97);
                                    Console.Write($"{firstPwordDigit}{secondPwordDigit}{thirdReal}{fourthReal}{fifhtPwordDigit} ");
                                }
                            }
                        }
                    }
                }
            }



        }
    }
}
