using System;
using System.Collections.Generic;

namespace E03ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<string>();
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty"); 
                }
                name = value; 
            }
        }
        public decimal Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value; 
            }
        }
        public List<string> Bag
        {
            get { return bag; }
            private set { bag = value; }
        }
    }
}
