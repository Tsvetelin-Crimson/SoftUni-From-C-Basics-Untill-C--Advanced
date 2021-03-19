using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    class VehicleC
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> AllVehicles = new List<Vehicle>();

            int sumOfHorsepowerCars = 0;
            int sumOfHorsepowerTrucks = 0;
            int allCars = 0;
            int allTrucks = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "car")
                {
                    tokens[0] = "Car";
                    sumOfHorsepowerCars += int.Parse(tokens[3]);
                    allCars++;
                }
                else if (tokens[0] == "truck")
                {
                    tokens[0] = "Truck";
                    sumOfHorsepowerTrucks += int.Parse(tokens[3]);
                    allTrucks++;
                }
                Vehicle newVehicle = new Vehicle(tokens[0], tokens[1], tokens[2], int.Parse(tokens[3]));
                AllVehicles.Add(newVehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                if (AllVehicles.Find(a => a.Model == input) != null)
                {
                      Console.WriteLine(AllVehicles.Find(a => a.Model == input).ToString().Trim());
                }               
            }

            double averageCarsHorsePower = (double)sumOfHorsepowerCars / allCars;
            double averageTruckHorsePower = (double)sumOfHorsepowerTrucks / allTrucks;

            if (allCars == 0)
            {
                averageCarsHorsePower = 0;
            }
            if (allTrucks == 0)
            {
                averageTruckHorsePower = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:F2}.");

        }
    }

    class Vehicle
    {
        public Vehicle(string typeCar, string model, string color, int horsepower)
        {
            this.TypeOfCar = typeCar;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string TypeOfCar { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            string output = $"Type: {this.TypeOfCar}\n";
            output += $"Model: {this.Model}\n";
            output += $"Color: {this.Color}\n";
            output += $"Horsepower: {this.Horsepower}\n";
            return output;
        }

    }

    

}
