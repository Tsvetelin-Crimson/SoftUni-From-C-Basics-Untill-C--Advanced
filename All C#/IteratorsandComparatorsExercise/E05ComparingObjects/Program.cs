using System;
using System.Collections.Generic;

namespace E05ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                people.Add(new Person(name, age, town));
            }


            int n = int.Parse(Console.ReadLine());

            Person person = people[n - 1];
            int numberOfNotEqualPeople = 0;
            int matches = 0;

            foreach (Person currPerson in people)
            {
                if (currPerson.CompareTo(person) == 0)
                {
                    matches++;
                }
                else
                {
                    numberOfNotEqualPeople++;
                }
            }


            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {numberOfNotEqualPeople} {people.Count}");
            }



        }
    }
}
