using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class SoftUniCP
    {
        static void Main(string[] args)
        {
            List<string> startingSchedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands;


            while ((commands = Console.ReadLine()) != "course start")
            {
                string[] comArray = commands.Split(":").ToArray();

                if (comArray[0] == "Add")
                {
                    if (!startingSchedule.Contains(comArray[1]))
                    {
                        startingSchedule.Add(comArray[1]);
                    }
                }
                else if (comArray[0] == "Insert")
                {
                    if (!startingSchedule.Contains(comArray[1]))
                    {
                        int index = int.Parse(comArray[2]);
                        if (index !=0 && startingSchedule[index] == $"{startingSchedule[index - 1]}-Exercise")
                        {
                            index++;
                        }
                        startingSchedule.Insert(index, comArray[1]);
                    }
                }
                else if (comArray[0] == "Remove")
                {
                    bool contains;
                    int integerWhereItExists;
                    ContainsAndWhereItIs(startingSchedule, comArray, out contains, out integerWhereItExists);

                    if (contains)
                    {
                        if (integerWhereItExists + 1 == startingSchedule.Count)
                        {
                            startingSchedule.Remove(comArray[1]);
                        }
                        else if (startingSchedule[integerWhereItExists + 1] == $"{comArray[1]}-Exercise")
                        {
                            startingSchedule.Remove(comArray[1]);
                            startingSchedule.Remove($"{comArray[1]}-Exercise");
                        }
                        else
                        {
                            startingSchedule.Remove(comArray[1]);
                        }
                        
                    }
                    
                    

                }
                else if (comArray[0] == "Swap")
                {
                    if (comArray[1] != comArray[2] && comArray[2] != $"{comArray[1]}-Exercise" && comArray[1] != $"{comArray[2]}-Exercise")
                    {
                        bool contains;
                        int integerWhereItExists;
                        ContainsAndWhereItIs(startingSchedule, comArray, out contains, out integerWhereItExists);
                        bool contains2nd;
                        int integerWhereItExists2nd;
                        ContainsAndWhereItIs2nd(startingSchedule, comArray, out contains2nd, out integerWhereItExists2nd);

                        if (contains && contains2nd)
                        {
                            string[] firstSet = new string[2];
                            firstSet[0] = comArray[1];
                            if (integerWhereItExists + 1 == startingSchedule.Count)
                            {
                            }
                            else if (startingSchedule[integerWhereItExists + 1] == $"{comArray[1]}-Exercise")
                            {
                                firstSet[1] = $"{comArray[1]}-Exercise";
                            }

                            string[] secondSet = new string[2];
                            secondSet[0] = comArray[2];
                            if (integerWhereItExists2nd + 1 == startingSchedule.Count)
                            {
                            }
                            else if (startingSchedule[integerWhereItExists2nd + 1] == $"{comArray[2]}-Exercise")
                            {
                                secondSet[1] = $"{comArray[2]}-Exercise";
                            }

                            CheckIfSecondIndexIsSmallerThanFirstAndSwapIfSo(comArray, ref integerWhereItExists, ref integerWhereItExists2nd, firstSet, secondSet);
                            ChechWhichToSwapAndDoIt(startingSchedule, comArray, integerWhereItExists, integerWhereItExists2nd, firstSet, secondSet);

                        }
                    }
                }
                else if (comArray[0] == "Exercise")
                {
                    bool contains;
                    int integerWhereItExists;
                    ContainsAndWhereItIs(startingSchedule, comArray, out contains, out integerWhereItExists);
                    if (contains)
                    {
                        if (integerWhereItExists + 1 == startingSchedule.Count)
                        {
                            startingSchedule.Add($"{comArray[1]}-Exercise");
                        }
                        else if (startingSchedule[integerWhereItExists + 1] != $"{startingSchedule[integerWhereItExists]}-Exercise")
                        {
                            startingSchedule.Insert(integerWhereItExists, $"{comArray[1]}-Exercise");
                        }
                    }
                    else
                    {
                        startingSchedule.Add(comArray[1]);
                        startingSchedule.Add($"{comArray[1]}-Exercise");
                    }


                }


                //Console.WriteLine(string.Join(", ", startingSchedule));
            }

            for (int i = 0; i < startingSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{startingSchedule[i]}");
            }


        }

        private static void CheckIfSecondIndexIsSmallerThanFirstAndSwapIfSo(string[] comArray, ref int integerWhereItExists, ref int integerWhereItExists2nd, string[] firstSet, string[] secondSet)
        {
            if (integerWhereItExists > integerWhereItExists2nd)
            {
                SwapArrays(firstSet, secondSet);
                int temp = integerWhereItExists;
                integerWhereItExists = integerWhereItExists2nd;
                integerWhereItExists2nd = temp;
                string stTemp;
                stTemp = comArray[1];
                comArray[1] = comArray[2];
                comArray[2] = stTemp;
            }
        }

        private static void ContainsAndWhereItIs2nd(List<string> startingSchedule, string[] comArray, out bool contains2nd, out int integerWhereItExists2nd)
        {
            contains2nd = false;
            integerWhereItExists2nd = 0;
            for (int i = 0; i < startingSchedule.Count; i++)
            {
                if (startingSchedule[i] == comArray[2])
                {
                    contains2nd = true;
                    integerWhereItExists2nd = i;
                }
            }
        }

        private static void ChechWhichToSwapAndDoIt(List<string> startingSchedule, string[] comArray, int integerWhereItExists, int integerWhereItExists2nd, string[] firstSet, string[] secondSet)
        {
            if (firstSet[1] == null && secondSet[1] == null)
            {
                startingSchedule.Remove(comArray[2]);
                startingSchedule.Insert(integerWhereItExists2nd, comArray[1]);
                startingSchedule.Remove(comArray[1]);
                startingSchedule.Insert(integerWhereItExists, comArray[2]);
            }
            else if (firstSet[1] == null)
            {
                startingSchedule.Remove(comArray[2]);
                startingSchedule.Remove($"{comArray[2]}-Exercise");
                startingSchedule.Insert(integerWhereItExists2nd, comArray[1]);
                startingSchedule.Remove(comArray[1]);
                startingSchedule.Insert(integerWhereItExists, $"{comArray[2]}-Exercise");
                startingSchedule.Insert(integerWhereItExists, comArray[2]);
            }
            else if (secondSet[1] == null)
            {
                startingSchedule.Remove(comArray[2]);
                startingSchedule.Insert(integerWhereItExists2nd, $"{comArray[1]}-Exercise");
                startingSchedule.Insert(integerWhereItExists2nd, comArray[1]);
                startingSchedule.Remove(comArray[1]);
                startingSchedule.Remove($"{comArray[1]}-Exercise");
                startingSchedule.Insert(integerWhereItExists, comArray[2]);
            }
            else
            {
                startingSchedule.Remove(comArray[2]);
                startingSchedule.Remove($"{comArray[2]}-Exercise");
                startingSchedule.Insert(integerWhereItExists2nd, $"{comArray[1]}-Exercise");
                startingSchedule.Insert(integerWhereItExists2nd, comArray[1]);
                startingSchedule.Remove(comArray[1]);
                startingSchedule.Remove($"{comArray[1]}-Exercise");
                startingSchedule.Insert(integerWhereItExists, $"{comArray[2]}-Exercise");
                startingSchedule.Insert(integerWhereItExists, comArray[2]);
            }
        }

        private static void SwapArrays(string[] firstSet, string[] secondSet)
        {
            string[] tempArr = firstSet.ToArray();
            for (int i = 0; i < 2; i++)
            {
                firstSet[i] = secondSet[i];
            }

            for (int i = 0; i < 2; i++)
            {
                firstSet[i] = tempArr[i];
            }
        }

        private static void ContainsAndWhereItIs(List<string> startingSchedule, string[] comArray, out bool contains, out int integerWhereItExists)
        {
            contains = false;
            integerWhereItExists = 0;
            for (int i = 0; i < startingSchedule.Count; i++)
            {
                if (startingSchedule[i] == comArray[1])
                {
                    contains = true;
                    integerWhereItExists = i;
                }
            }
        }
    }
}
