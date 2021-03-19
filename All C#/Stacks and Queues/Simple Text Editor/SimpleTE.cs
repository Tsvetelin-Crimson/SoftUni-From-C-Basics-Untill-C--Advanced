using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Text_Editor
{
    class SimpleTE
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder stringb = new StringBuilder();
            Stack<string[]> lastCommands = new Stack<string[]>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "1")
                {
                    stringb.Append(input[1]);
                    lastCommands.Push(input);

                }
                else if (command == "2")
                {
                    int countToRemove = int.Parse(input[1]);
                    stringb.Remove(stringb.Length - countToRemove - 1, countToRemove);
                    lastCommands.Push(input);
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(stringb[index]);
                }
                else if (command == "4")
                {
                    string[] lastCommand = lastCommands.Pop();
                    string inputString = lastCommand[1];

                    if (lastCommand[0] == "1")
                    {
                        int countToRemove = inputString.Length;

                        stringb.Remove(stringb.Length - countToRemove - 1, countToRemove);
                    }
                    else
                    {
                        stringb.Append(inputString);
                    }
                }
            }



        }
    }
}
