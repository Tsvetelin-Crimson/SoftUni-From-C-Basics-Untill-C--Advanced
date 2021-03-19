using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    class PasswordV
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool answer = IsCharacterLength(password);
            int count = 0;
            if (answer)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                count++;
            }
            answer = IsLettersAndDigits(password);

            if (answer)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                count++;
            }
            answer = Has2OrMoreDigits(password);

            if (answer)
            {
                Console.WriteLine("Password must have at least 2 digits");
                count++;
            }



            if (count == 0) //could just check if all others are the opposite
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool IsCharacterLength(string input)
        {
            return input.Length >= 11 || input.Length <= 5;
        }

        static bool IsLettersAndDigits(string input)
        {
            bool isTrue = false;

            for (int i = 0; i < input.Length ; i++)
            {
                if ((input[i] >= 48 && input[i] <= 57) || (input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122))
                {
                    
                }
                else
                {
                   isTrue = true;// could just return true or false
                }


            }
            return isTrue; // same here
        }

        static bool Has2OrMoreDigits(string input)
        {
            bool isTrue = true;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    count++;
                }

            }

            if (count >= 2)
            {
                isTrue = false;
            }
            return isTrue;
        }


    }
}
