using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class MultiplyBN
    {
        static void Main(string[] args)
        {
            char[] bigNumber = Console.ReadLine().ToCharArray();
            int multiplier = int.Parse(Console.ReadLine());
            int exess = 0;
            StringBuilder sb = new StringBuilder();

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(bigNumber[i].ToString());
                int result = (currDigit * multiplier) + exess;
                sb.Append(result % 10);
                exess = result / 10; 
            }
            //Console.WriteLine(sb);
            if (exess != 0)
            {
                sb.Append(exess);
            }
            List<char> resultArr = sb.ToString().Reverse().ToList();
            RemoveTrailingZeros(resultArr);
            Console.WriteLine(string.Join("", resultArr));
        }

        private static void RemoveTrailingZeros(List<char> resultArr)
        {
            if (resultArr[0] == '0')
            {
                int endIndex = 1;

                for (int i = 1; i < resultArr.Count; i++)
                {
                    if (resultArr[i] != '0')
                    {
                        endIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < endIndex; i++)
                {
                    resultArr.RemoveAt(0);
                }

            }


        }
    }
}
