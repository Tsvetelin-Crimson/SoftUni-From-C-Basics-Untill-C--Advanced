using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Anonymous
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
           
            string commands = "";
            while ((commands = Console.ReadLine()) != "3:1")
            {
                string[] comArr = commands.Split().ToArray();
                int firstNumb = int.Parse(comArr[1]),
                    secondNumb = int.Parse(comArr[2]);
                if (comArr[0] == "merge")
                {
                    if ( firstNumb < inputList.Count) 
                    {
                        if (firstNumb < 0)
                        {
                            firstNumb = 0;
                        }
                        if (secondNumb - firstNumb >= inputList.Count - firstNumb) //check if merge length too long //eff up here prob
                        {
                            secondNumb = inputList.Count - 1;
                        }
                        MergeCommand(inputList, firstNumb, secondNumb);
                    }
                }
                else if (comArr[0] == "divide")
                {
                    char[] tempArr = inputList[firstNumb].ToCharArray();
                    int lengthPerPart = tempArr.Length / secondNumb;
                    int charPart = 0;
                    string[] arrTobeAdded = new string[secondNumb];
                    int endCharPart = lengthPerPart;
                    for (int i = 0; i < secondNumb; i++)
                    {
                        for (int j = charPart; j < endCharPart; j++)
                        {
                            arrTobeAdded[i] += tempArr[j];
                        }
                        charPart += lengthPerPart;
                        endCharPart += lengthPerPart;
                    }

                    if (tempArr.Length % secondNumb != 0)
                    {
                        for (int i = 0; i < tempArr.Length % secondNumb; i++)
                        {
                            arrTobeAdded[arrTobeAdded.Length - 1] += tempArr[charPart++];
                        }                         
                    }

                    inputList.RemoveAt(firstNumb);
                    
                    for (int i = 0; i < secondNumb; i++)
                    {
                        inputList.Insert(firstNumb , arrTobeAdded[arrTobeAdded.Length - 1 - i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", inputList));

        }

        private static void MergeCommand(List<string> inputList, int firstNumb, int secondNumb)
        {
            string tempArr = "";
            for (int i = firstNumb; i < secondNumb + 1; i++)
            {
                tempArr += inputList[i];
            }
            for (int i = firstNumb; i < secondNumb + 1; i++)
            {
                inputList.RemoveAt(firstNumb);
            }
            inputList.Insert(firstNumb, tempArr);
        }
    }
}
