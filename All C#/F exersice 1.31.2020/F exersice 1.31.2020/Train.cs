using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_exersice_1._31._2020
{
    class Train
    {
        static void Main(string[] args)
        {
            int sum = 0,
                amountInput = int.Parse(Console.ReadLine());
            int[] trainPeople = new int[amountInput];
            //Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < trainPeople.Length; i++)
            {
                trainPeople[i] = int.Parse(Console.ReadLine());
            }                          
            for (int i = 0; i < trainPeople.Length; i++)
            {
                Console.Write(trainPeople[i] + " ");
                sum += trainPeople[i];
            }
            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}
