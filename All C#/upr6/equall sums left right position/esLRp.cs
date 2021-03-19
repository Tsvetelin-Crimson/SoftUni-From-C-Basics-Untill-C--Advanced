using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equall_sums_left_right_position
{
    class esLRp
    {
        static void Main(string[] args)
        {
            int realFirst = int.Parse(Console.ReadLine()),
                realSecond = int.Parse(Console.ReadLine());

            for (int outNumb = realFirst; outNumb <= realSecond; outNumb++)
            {
                int leftSum = 0,
                    rightSum = 0,
                    dummyNumb = outNumb;

                for (int i = 0; i < 2; i++)
                {
                    int currentDigit = dummyNumb % 10;
                    rightSum += currentDigit;
                    dummyNumb /= 10;
                }
                int excessNumb = dummyNumb % 10;
                dummyNumb = dummyNumb / 10;
                for (int i = 0; i < 2; i++)
                {
                    int currentDigit = dummyNumb % 10;
                    leftSum += currentDigit;
                    dummyNumb /= 10;
                }

                if (leftSum > rightSum)
                {
                    rightSum += excessNumb;
                }
                else if (rightSum > leftSum)
                {
                    leftSum += excessNumb;
                }

                if (rightSum == leftSum)
                {
                    Console.Write(outNumb + " ");

                }

            }
        }
    }
}
