using System;
using System.Collections.Generic;

namespace F_Exercise_2._21._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4,
                c = 9,
                d = 10,
                e = a + b + c + d;
            double average = (double)e / 4;
            Console.WriteLine($"{average:F2}");
        }
    }


    class Vehicle
    {
        public Vehicle(string name, string model, int horsepower)
        {
            this.Name = name;
            this.Model = model;
            this.Horsepower = horsepower;


        }
        
        public string Name { get; set; }

        public string Model { get; set; }

        public int Horsepower { get; set; }
    }
}
