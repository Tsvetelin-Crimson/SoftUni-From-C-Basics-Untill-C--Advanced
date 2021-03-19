using System;
using System.Collections.Generic;


namespace E03ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {    
            try
            {
                string[] allPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, Person> people = new Dictionary<string, Person>();                
                for (int i = 0; i < allPeople.Length; i++)
                {

                    string[] currPerson = allPeople[i].Split('=');
                    Person currPersonClass = new Person(currPerson[0], decimal.Parse(currPerson[1]));
                    people.Add(currPerson[0], currPersonClass);
                }     
                
                string[] allProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, Product> products = new Dictionary<string, Product>();
                for (int i = 0; i < allProducts.Length; i++)
                {
                    string[] currProduct = allProducts[i].Split('=');
                    Product currProductClass = new Product(currProduct[0], decimal.Parse(currProduct[1]));
                    products.Add(currProduct[0], currProductClass);
                }

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input.Split();
                    string person = tokens[0];
                    string product = tokens[1];

                    if (people[person].Money - products[product].Cost >= 0)
                    {
                        Console.WriteLine($"{person} bought {product}");
                        people[person].Money -= products[product].Cost;
                        people[person].Bag.Add(product);
                    }
                    else
                    {
                        Console.WriteLine($"{person} can't afford {product}");
                    }
                }


                foreach ((string name, Person person) in people)
                {
                    if (person.Bag.Count == 0)
                    {
                        Console.WriteLine($"{name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{name} - {string.Join(", ", person.Bag)}");
                    }

                }
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
