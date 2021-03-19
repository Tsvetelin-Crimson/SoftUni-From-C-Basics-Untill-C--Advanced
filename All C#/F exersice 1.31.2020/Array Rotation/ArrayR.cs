using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Rotation
{
    class ArrayR
    {
        static void Main(string[] args)
        {
            int[] mainArr = Console.ReadLine().Split().Select(int.Parse).ToArray(); // could be changed to string since there are no maths done
            int numberOfRotations = int.Parse(Console.ReadLine()); // optimise so that if you get the answer early to stop the program (numbOfRotations % mainarr.length)

            for (int i = 0; i < numberOfRotations; i++)
            {
                for (int j = 0; j < mainArr.Length - 1; j++)
                {
                    int temp = mainArr[j];
                    if (j - 1 < 0)
                    {
                        mainArr[j] = mainArr[mainArr.Length - 1];
                        mainArr[mainArr.Length - 1] = temp;
                    }
                    else
                    {
                        mainArr[j] = mainArr[j - 1];
                        mainArr[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", mainArr));


        }
    }
}
