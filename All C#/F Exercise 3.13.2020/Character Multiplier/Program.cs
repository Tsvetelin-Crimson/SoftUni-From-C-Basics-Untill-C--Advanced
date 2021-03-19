using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];
            if (firstString.Length > secondString.Length) // always first string will be longer
            {
                string temp = firstString;
                firstString = secondString;
                secondString = temp;
            }


            //Console.WriteLine(firstString);
            //Console.WriteLine(secondString);
            int sum = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            int extras = secondString.Length - firstString.Length;

            for (int i = 0; i < extras; i++)
            {
                sum += secondString[firstString.Length + i];
            }

            Console.WriteLine(sum);
        }
    }
}
