using System;
using System.Linq;

namespace E03CustomMiniStack
{
    class CustomMiniStack
    {
        static void Main(string[] args)
        {
            CustomStackMini<int> myStack = new CustomStackMini<int>();


            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(new string[] {" ", ", "}, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Push")
                {
                    

                    foreach (var item in tokens.Skip(1))
                    {
                        int intItem = int.Parse(item);
                        myStack.Push(intItem);
                    }

                }
                else if (command == "Pop")
                {
                    if (myStack.Count == 0)
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        myStack.Pop();
                    }
                }

            }


            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }
            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }

        }
    }
}
