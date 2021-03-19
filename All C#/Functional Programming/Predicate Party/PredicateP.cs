using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party
{
    class PredicateP
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0],
                    caviat = tokens[1],
                    argument = tokens[2];
                //people.
                if (command == "Remove")
                {
                    switch (caviat)
                    {
                        case "StartsWith":
                            people.RemoveAll(k => k.StartsWith(argument));
                            break;
                        case "EndsWith":
                            people.RemoveAll(k => k.EndsWith(argument));
                            break;
                        case "Length":
                            people.RemoveAll(k => k.Length == int.Parse(argument));
                            break;
                        default:
                            break;
                    }
                }
                else if (command == "Double")
                {
                    List<string> doubledPeople = new List<string>();
                    switch (caviat)
                    {
                        case "StartsWith":
                            DoubleNames(people, k => k.StartsWith(argument));                            
                            break;
                        case "EndsWith":
                            DoubleNames(people, k => k.EndsWith(argument));                           
                            break;
                        case "Length":
                            DoubleNames(people, k => k.Length == int.Parse(argument));                           
                            break;
                        default:
                            break;
                    }
                }

                //PrintPeople(people);
            }


            PrintPeople(people);
        }

        private static void DoubleNames(List<string> people, Func<string, bool> predicate)
        {
            for (int i = people.Count - 1; i >= 0; i--)
            {
                if (predicate(people[i]))
                {
                    people.Add(people[i]);
                }
            }


        }


        private static void PrintPeople(List<string> people)
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ", people));
                Console.WriteLine(" are going to the party!");
            }
        }
    }
}
