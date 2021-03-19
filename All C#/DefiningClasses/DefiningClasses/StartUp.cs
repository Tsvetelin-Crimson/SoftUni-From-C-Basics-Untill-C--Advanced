using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] personTokens = Console.ReadLine().Split();
                string name = personTokens[0];
                int age = int.Parse(personTokens[1]);

                people.Add(new Person(name, age));
            }

            people = people.Where(k => k.Age > 30).OrderBy(k => k.Name).ToList();

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
