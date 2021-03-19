using System;

namespace F_Exercise_3._13._2020
{
    class CharacterM
    {
        static void Main(string[] args)
        {
            string[] arrInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrInput.Length; i++)
            {
                if (ValidateUsername(arrInput[i]))
                {
                    Console.WriteLine(arrInput[i]);
                }


            }


        }


        static bool ValidateUsername(string input)
        {
            if (input.Length < 3 | input.Length > 16)
            {
                return false;
            }

            
            for (int i = 0; i < input.Length; i++)
            {
                if (!(char.IsLetterOrDigit(input[i]) || input[i] == '-' || input[i] == '_'))
                {
                    return false;
                }

            }

            return true;

        }
    }
}
