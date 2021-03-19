using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_By_Age
{
    class OrderBA
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {               
                string[] inpArray = input.Split();
                if (inpArray.Length == 3)
                {
                    People newPeople = new People(inpArray[0], inpArray[1], int.Parse(inpArray[2]));
                    list.Add(newPeople);
                }
                
            }
            List<People> sortedPeople = list.OrderBy(a => a.Age).ToList();
            Console.WriteLine(string.Join("\n", sortedPeople));
        }
    }

    class People
    {
        public People(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;


        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
