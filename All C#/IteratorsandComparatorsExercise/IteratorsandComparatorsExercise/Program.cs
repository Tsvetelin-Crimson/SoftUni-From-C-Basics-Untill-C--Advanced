using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsandComparatorsExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;


            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] tokens = input.Split();
                    string command = tokens[0];

                    switch (command)
                    {
                        case "Create":
                            List<string> list = tokens.Skip(1).ToList();
                            listyIterator = new ListyIterator<string>(list);
                            break;
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "PrintAll":
                            listyIterator.PrintAll();
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        default:
                            break;
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }




        }
    }
}
