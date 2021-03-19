using System;
using System.Collections.Generic;

namespace E04PizzaCalories
{
    public class Pizza
    {
        private const int MaxNameLength = 15;
        private const int MinNumberOfToppings = 0;
        private const int MaxNumberOfToppings = 10;
        private string name;
        private Dough dough;
        private List<Topping> Toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.Toppings = new List<Topping>();
        }

        public int CountOfToppings => this.Toppings.Count;
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > MaxNameLength)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and {MaxNameLength} symbols.");
                }
                name = value;
            }
        }

        public double TotalCalories()
        {
            double res = this.dough.TotalCalories;

            foreach (Topping topping in Toppings)
            {
                res += topping.TotalCaloreis;
            }

            return res;
        }
        public void AddTopping(Topping topping)
        {
            if (this.CountOfToppings == MaxNumberOfToppings + 1)
            {
                throw new ArgumentException($"Number of toppings should be in range [{MinNumberOfToppings}..{MaxNumberOfToppings}].");
            }
            this.Toppings.Add(topping);
        }

    }
}
