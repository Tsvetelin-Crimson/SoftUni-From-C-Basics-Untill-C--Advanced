using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamino_Factory2
{
    class KaminoF2
    {


        static void Main(string[] args)
        {
            int lenghtOfDNA = int.Parse(Console.ReadLine());

            int longestStreak = 0;
            int biggestSum = 0;
            int currArr = 0;
            int endArrCount = 0;
            int leftMostInteger = int.MaxValue;
            int[] endArr = new int[lenghtOfDNA];
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] arr = input.Split((char)StringSplitOptions.RemoveEmptyEntries, '!').Select(int.Parse).ToArray();
                currArr++;
                for (int i = 0; i < arr.Length; i++)
                {
                    int currStreak = 0;
                    for (int J = i + 1; J < arr.Length; J++)
                    {
                        if (arr[i] == 1 && arr[i] == arr[J])
                        {
                            currStreak++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (currStreak >= longestStreak)
                    {
                        longestStreak = currStreak;
                        endArr = arr.ToArray();
                        endArrCount = currArr;
                        biggestSum = arr.Sum();
                        if (leftMostInteger >= i) // remove =
                        {
                            leftMostInteger = i;
                            endArr = arr.ToArray();
                            endArrCount = currArr;
                            if (biggestSum < arr.Sum()) //check if the same lengh and if bigger sum
                            {                               
                                endArr = arr.ToArray();
                                endArrCount = currArr;
                                biggestSum = arr.Sum();
                            }

                        }
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {endArrCount} with sum: {biggestSum}.");
            Console.WriteLine(string.Join(" ", endArr));



        }


    }
}
