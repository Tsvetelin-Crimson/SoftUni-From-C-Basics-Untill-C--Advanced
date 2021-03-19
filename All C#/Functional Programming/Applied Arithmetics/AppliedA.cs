using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class AppliedA
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<int, int> addFunc = n => n + 1;
            Func<int, int> multFunc = n => n * 2;
            Func<int, int> subtFunc = n => n - 1;
            Action<List<int>> printFunc = n => Console.WriteLine(string.Join(' ', n));
            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                switch (command)
                {
                    case "add":
                        inputList = inputList.Select(addFunc).ToList();
                        break;
                    case "multiply":
                        inputList = inputList.Select(multFunc).ToList();
                        break;
                    case "subtract":
                        inputList = inputList.Select(subtFunc).ToList();
                        break;
                    case "print":
                        printFunc(inputList);
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
