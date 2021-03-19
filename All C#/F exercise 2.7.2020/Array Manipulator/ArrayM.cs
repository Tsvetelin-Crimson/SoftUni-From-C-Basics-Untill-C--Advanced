using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class ArrayM
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            string commands = Console.ReadLine();

            
            //ExchangeCommand(array, 4);
            //PrintFirstEvenOdd(array, 10, "even");
            //PrintLastEvenOdd(array, 4, "even");
            
            
            //PrintMaxEvenOdd(array, "odd");            
            while (commands != "end")
            {
                string[] arrForCommands = commands.Split().ToArray();
                if (arrForCommands[0] == "exchange")
                {
                    ExchangeCommand(array, int.Parse(arrForCommands[1]));
                }
                else if (arrForCommands[0] == "max")
                {
                    PrintMaxEvenOdd(array, arrForCommands[1]);
                }
                else if (arrForCommands[0] == "min")
                {
                    PrintMinEvenOdd(array, arrForCommands[1]);
                }
                else if (arrForCommands[0] == "first")
                {
                    PrintFirstEvenOdd(array, int.Parse(arrForCommands[1]), arrForCommands[2]);
                }
                else if (arrForCommands[0] == "last")
                {
                    PrintLastEvenOdd(array, int.Parse(arrForCommands[1]), arrForCommands[2]);
                }

                commands = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", array));
            Console.WriteLine("]");
        }

        static void PrintFirstEvenOdd(string[] arr, int endCount, string whatIsIt)
        {
            if (endCount <= arr.Length)
            {
                if (whatIsIt == "odd")
                {
                    string printArr = "";
                    int count = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (count != endCount)
                        {
                            if (int.Parse(arr[i]) % 2 == 1)
                            {
                                printArr += arr[i];
                                count++;
                                if (count != endCount)
                                {
                                    printArr += " ";
                                }
                            }
                            if (count == endCount)
                            {
                                break;
                            }
                        }
                    }
                    List<string> realPrintArr = printArr.Split().ToList();//" ", StringSplitOptions.RemoveEmptyEntries
                    realPrintArr.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", realPrintArr));
                    Console.WriteLine("]");

                }
                else
                {
                    string printArr = "";
                    int count = 0;
                    for (int i = 0; i < arr.Length; i--)
                    {
                        if (count != endCount)
                        {
                            if (int.Parse(arr[i]) % 2 == 0)
                            {
                                printArr += arr[i];
                                count++;
                                if (count != endCount)
                                {
                                    printArr += " ";
                                }
                            }
                            if (count == endCount)
                            {
                                break;
                            }
                        }
                    }
                    List<string> realPrintArr = printArr.Split().ToList();//" ", StringSplitOptions.RemoveEmptyEntries
                    realPrintArr.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", realPrintArr));
                    Console.WriteLine("]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }

        }

        static void PrintLastEvenOdd(string[] arr, int endCount, string whatIsIt)
        {
            if (endCount <= arr.Length)
            {
                if (whatIsIt == "odd")
                {
                    string printArr = "";
                    int count = 0;                                      
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        if (count != endCount)
                        {
                            if (int.Parse(arr[i]) % 2 == 1)
                            {
                                printArr += arr[i];                                
                                count++;
                                if (count != endCount)
                                {
                                    printArr += " ";
                                }
                            }
                            if (count == endCount)
                            {
                                break;
                            }
                        }
                    }
                    List<string> realPrintArr = printArr.Split().ToList();//" ", StringSplitOptions.RemoveEmptyEntries
                    realPrintArr.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", realPrintArr));
                    Console.WriteLine("]");
                    
                }
                else
                {
                    string printArr = "";
                    int count = 0;
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        if (count != endCount)
                        {
                            if (int.Parse(arr[i]) % 2 == 0)
                            {
                                printArr += arr[i];
                                count++;
                                if (count != endCount)
                                {
                                    printArr += " ";
                                }
                            }
                            if (count == endCount)
                            {
                                break;
                            }
                        }
                    }
                    List<string> realPrintArr = printArr.Split().ToList();//" ", StringSplitOptions.RemoveEmptyEntries
                    realPrintArr.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", realPrintArr));
                    Console.WriteLine("]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }

        }
        static void ExchangeCommand(string[] arr,int index)
        {
            
            if (index < arr.Length)
            {
                index++;
                string[] firstArr = new string[index];
                for (int i = 0; i < index; i++)
                {
                    firstArr[i] = arr[i];
                }

                string[] secondArr = new string[arr.Length - index];
                for (int i = 0; i < arr.Length - index; i++)
                {
                    secondArr[i] = arr[index + i];
                }

                for (int i = 0; i < secondArr.Length; i++)
                {
                    arr[i] = secondArr[i];
                }
                for (int i = 0; i < firstArr.Length; i++)
                {
                    arr[secondArr.Length + i] = firstArr[i];
                }
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void PrintMaxEvenOdd(string[] arr, string whichHalf)
        {
            
            bool hasOddEven = false;
            if (whichHalf == "odd")
            {
                int maxIndex = 0;
                for (int i = 0; i < arr.Length; i++) //should be in methods
                {
                    if (int.Parse(arr[i]) % 2 == 1)
                    {
                        hasOddEven = true;
                        if (int.Parse(arr[i]) >= int.Parse(arr[maxIndex]))
                        {
                            maxIndex = i;
                        }
                    }
                }
                if (hasOddEven)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                int maxIndex = 0;
                for (int i = 0; i < arr.Length; i++)//this too
                {
                    if (int.Parse(arr[i]) % 2 == 0)
                    {
                        hasOddEven = true;
                        if (int.Parse(arr[i]) >= int.Parse(arr[maxIndex]))
                        {
                            maxIndex = i;
                        }
                    }
                }
                if (hasOddEven)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void PrintMinEvenOdd(string[] arr, string whichHalf)
        {

            bool hasOddEven = false;
            if (whichHalf == "odd")
            {
                int minIndex = 0;
                for (int i = 0; i < arr.Length; i++) //should be in methods
                {
                    if (int.Parse(arr[i]) % 2 == 1)
                    {
                        hasOddEven = true;
                        if (int.Parse(arr[i]) <= int.Parse(arr[minIndex]))
                        {
                            minIndex = i;
                        }
                    }
                }
                if (hasOddEven)
                {
                    Console.WriteLine(minIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                int minIndex = 0;
                for (int i = 0; i < arr.Length; i++)//this too
                {
                    if (int.Parse(arr[i]) % 2 == 0)
                    {
                        hasOddEven = true;
                        if (int.Parse(arr[i]) <= int.Parse(arr[minIndex]))
                        {
                            minIndex = i;
                        }
                    }
                }
                if (hasOddEven)
                {
                    Console.WriteLine(minIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

    }
}
