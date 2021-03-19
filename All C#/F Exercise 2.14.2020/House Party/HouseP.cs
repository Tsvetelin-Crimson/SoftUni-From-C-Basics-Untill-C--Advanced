using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Party
{
    class HouseP
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<string> people = new List<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                CommandExecute(people);
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        private static void CommandExecute(List<string> people)
        {
            string command = Console.ReadLine();
            string[] cmdArr = command.Split().ToArray();

            if (cmdArr.Length == 3)
            {
                AddPerson(people, cmdArr);
            }
            else if (cmdArr.Length == 4)
            {
                RemovePerson(people, cmdArr);
            }
        }

        private static void RemovePerson(List<string> people, string[] cmdArr)
        {
            if (people.Contains(cmdArr[0]))
            {
                people.Remove(cmdArr[0]);
            }
            else
            {
                Console.WriteLine($"{cmdArr[0]} is not in the list!");
            }
        }

        private static void AddPerson(List<string> people, string[] cmdArr)
        {
            if (people.Contains(cmdArr[0]))
            {
                Console.WriteLine($"{cmdArr[0]} is already in the list!");
            }
            else
            {
                people.Add(cmdArr[0]);
            }
        }
    }
}
