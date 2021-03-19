using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class AppendA
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split("|").ToArray();
            List<string> outputArr = new List<string>();
            FilterArrAndAppendBackwards(inputArr, outputArr);
            Console.WriteLine(string.Join(" ", outputArr));

        }

        private static void FilterArrAndAppendBackwards(string[] inputArr, List<string> outputArr)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                string[] tempArr = inputArr[inputArr.Length - 1 - i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                AppendEveryPartOfTempArr(outputArr, tempArr);
            }
        }

        private static void AppendEveryPartOfTempArr(List<string> outputArr, string[] tempArr)
        {
            for (int j = 0; j < tempArr.Length; j++)
            {
                outputArr.Add(tempArr[j]);
            }
        }
    }
}
