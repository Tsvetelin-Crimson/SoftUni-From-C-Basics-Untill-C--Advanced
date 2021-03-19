using System;

namespace F_Exam_4._4._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] inputArgs = input.Split(">>>");
                string command = inputArgs[0];

                if (command == "Contains")
                {
                    if (key.Contains(inputArgs[1]))
                    {
                        Console.WriteLine($"{key} contains {inputArgs[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    int startIndex = int.Parse(inputArgs[2]);
                    int endIndex = int.Parse(inputArgs[3]);

                    string partToBeTransformed = key.Substring(startIndex, endIndex- startIndex);
                    if (inputArgs[1] == "Upper")
                    {
                        partToBeTransformed = partToBeTransformed.ToUpper();
                    }
                    else
                    {
                        partToBeTransformed = partToBeTransformed.ToLower();
                    }
                    string firstPartOfKey = key.Substring(0, startIndex);
                    string lastPartOfKey = key.Substring(endIndex, key.Length - endIndex);
                    key = firstPartOfKey + partToBeTransformed + lastPartOfKey;
                    Console.WriteLine(key);
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(inputArgs[1]);
                    int endIndex = int.Parse(inputArgs[2]);
                    string partToBeRemoved = key.Substring(startIndex, endIndex - startIndex);
                    string firstPartOfKey = key.Substring(0, startIndex);
                    string lastPartOfKey = key.Substring(endIndex, key.Length - endIndex);
                    key = firstPartOfKey + lastPartOfKey;
                    Console.WriteLine(key);
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
