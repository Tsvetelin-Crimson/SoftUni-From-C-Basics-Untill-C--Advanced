using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Sumbtract
{
    class AddAS
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()),
                secondNum = int.Parse(Console.ReadLine());
            int sum = SumFirstAndSecondNumbs(firstNum, secondNum);

            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{SubtractThirdNum(sum, thirdNum)}");

        }

        static int SumFirstAndSecondNumbs(int first, int second)
        {
            return first + second;
        }
        
        static int SubtractThirdNum(int sum, int third)
        {
            return sum - third;


        }
    }
}
