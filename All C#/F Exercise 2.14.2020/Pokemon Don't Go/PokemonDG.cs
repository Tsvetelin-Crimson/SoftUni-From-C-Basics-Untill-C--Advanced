using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class PokemonDG
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int sum = 0;
            //check negavite integers
            while (inputList.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                int valueOfInteger = 0;
                if (indexToRemove < 0)
                {
                    indexToRemove = 0;
                    valueOfInteger = ExecuteRemovalOfInteger(inputList, ref sum, indexToRemove);
                    valueOfInteger = inputList[inputList.Count - 1];
                    inputList.Insert(indexToRemove, valueOfInteger);
                }
                else if (indexToRemove >= inputList.Count)
                {
                    indexToRemove = inputList.Count - 1;
                    valueOfInteger = ExecuteRemovalOfInteger(inputList, ref sum, indexToRemove);
                    valueOfInteger = inputList[0];
                    inputList.Insert(indexToRemove, valueOfInteger);
                }
                else
                {

                    valueOfInteger = ExecuteRemovalOfInteger(inputList, ref sum, indexToRemove);
                }
                //Console.WriteLine(string.Join(" ", inputList));
            }
            Console.WriteLine(sum);

        }

        private static int ExecuteRemovalOfInteger(List<int> inputList, ref int sum, int indexToRemove)
        {
            int valueOfInteger;
            sum += inputList[indexToRemove];
            valueOfInteger = inputList[indexToRemove];
            inputList.RemoveAt(indexToRemove);
            for (int i = 0; i < inputList.Count; i++)
            {
                if (valueOfInteger >= inputList[i])
                {
                    inputList[i] += valueOfInteger;
                }
                else
                {
                    inputList[i] -= valueOfInteger;
                }
            }

            return valueOfInteger;
        }
    }
}
