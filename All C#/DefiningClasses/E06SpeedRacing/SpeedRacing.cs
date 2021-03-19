using System;
using System.Collections.Generic;

namespace E06SpeedRacing
{
    public class SpeedRacing
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] currCars = Console.ReadLine().Split();
                string model = currCars[0];
                double fuelAmount = double.Parse(currCars[1]),
                    fuelConsumption = double.Parse(currCars[2]);
                Car currCar = new Car();

                if (!cars.ContainsKey(model))
                {
                    cars[model] = new Car();
                }

                cars[model].Model = model;
                cars[model].FuelAmount = fuelAmount;
                cars[model].FuelConsumptionPerKilometer = fuelConsumption;
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string model = tokens[1];
                double kilometers = double.Parse(tokens[2]);

                //maybe check if car exists
                cars[model].Drive(kilometers);
            }

            foreach ((string model, Car currCar) in cars)
            {
                Console.WriteLine($"{model} {currCar.FuelAmount:F2} {currCar.TravelledDistance:F0}");


            }
        }
    }
}
