using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_Exercise_2_1._24._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine()),
                secondNumber = int.Parse(Console.ReadLine()),//combine
                thirdNumber = int.Parse(Console.ReadLine()),//divide
                forthNumber = int.Parse(Console.ReadLine()),//multiply
                endNumber = 0;

            endNumber = ((firstNumber + secondNumber) / thirdNumber) * forthNumber;

            Console.WriteLine(endNumber);





        }
    }
}
