using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Operatrions
{
    class ListO
    {
        static void Main(string[] args)
        {// needs a fix
            List<int> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArr = input.Split().ToArray();
                if (inputArr.Length == 2)
                {
                    if (int.Parse(inputArr[1]) < list.Count)
                    {
                        ExecuteCommands(list, inputArr);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (inputArr.Length == 3)
                {
                    if (int.Parse(inputArr[2]) < list.Count)
                    {
                        ExecuteCommands(list, inputArr);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

            }
            Console.WriteLine(string.Join(" ", list));

        }

        private static void ExecuteCommands(List<int> list, string[] inputArr)
        {
            if (inputArr[0] == "Add")
            {
                list.Add(int.Parse(inputArr[1]));

            }
            else if (inputArr[0] == "Insert")
            {
                list.Insert(int.Parse(inputArr[2]), int.Parse(inputArr[1]));
            }
            else if (inputArr[0] == "Remove")
            {
                list.RemoveAt(int.Parse(inputArr[1]));
            }
            else if (inputArr[0] == "Shift" && inputArr[1] == "left")
            {
                ShiftLeft(list, inputArr);
            }
            else if (inputArr[0] == "Shift" && inputArr[1] == "right")
            {
                ShiftRight(list, inputArr);
            }
        }
        private static void ShiftRight(List<int> list, string[] inputArr)
        {                      
            int actualCount = int.Parse(inputArr[2]) % list.Count;
                       
            for (int i = 0; i < actualCount; i++)
            {
                list.Insert(0, list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);
            }
        }

        private static void ShiftLeft(List<int> list, string[] inputArr)
        {
            int actualCount = int.Parse(inputArr[2]) % list.Count;

            for (int i = 0; i < actualCount; i++)
                {
                    list.Add(list[0]);
                    list.RemoveAt(0);
                }
        }
    }
}
