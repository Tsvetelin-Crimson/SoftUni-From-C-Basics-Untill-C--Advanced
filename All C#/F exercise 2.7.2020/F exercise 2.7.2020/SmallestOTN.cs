using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_exercise_2._7._2020
{
    class SmallestOTN
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()),
                secondNum = int.Parse(Console.ReadLine()),
                thirdNum = int.Parse(Console.ReadLine());

            GetBiggest(firstNum, secondNum, thirdNum);

        }

        static void GetBiggest(int first, int second, int third)
        {
            if (first < second && first < third)
            {
                Console.WriteLine(first);
            }
            else if (second < third)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(third);
            }

        }
    }
}
