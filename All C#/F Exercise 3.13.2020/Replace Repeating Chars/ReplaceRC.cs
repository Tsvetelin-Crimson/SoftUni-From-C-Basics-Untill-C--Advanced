using System;
using System.Text;

namespace Replace_Repeating_Chars
{
    class ReplaceRC
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            char currChar = input[0];
            sb.Append(currChar);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != currChar)
                {
                    currChar = input[i];
                    sb.Append(currChar);
                }

            }
            Console.WriteLine(sb);
        }
    }
}
