using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ExerciseB
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());

            double    sum = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                double setOfNumbers = double.Parse(Console.ReadLine());
                sum += setOfNumbers;
            }

            Console.WriteLine(sum);


        }
    }
}
