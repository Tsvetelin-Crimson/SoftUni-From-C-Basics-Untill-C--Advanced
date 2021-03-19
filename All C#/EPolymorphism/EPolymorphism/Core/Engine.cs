using System;
using Vehicle.Factories;
using Vehicle.Models;

namespace Vehicle.Core
{
    public class Engine : IEngine

    {
        private VehicleFactory vehicleFactory = new VehicleFactory();

        public void Run()
        {
            string[] carData = Console.ReadLine().Split();
            IVehicle car = CreateVehicle(carData);

            string[] truckData = Console.ReadLine().Split();
            IVehicle truck = CreateVehicle(truckData);

            string[] BusData = Console.ReadLine().Split();
            IVehicle bus = CreateVehicle(BusData);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();
                string command = args[0];
                string vehicleType = args[1];
                double arg = double.Parse(args[2]);

                try
                {
                    if (command == "Drive")
                    {
                        DriveCommand(car, truck, bus, vehicleType, arg);
                    }
                    else if (command == "DriveEmpty")
                    {
                        DriveEmptyCommand(bus, vehicleType, arg);
                    }
                    else if (command == "Refuel")
                    {
                        if (vehicleType == nameof(Car))
                        {
                            car.Refuel(arg);
                        }
                        else if (vehicleType == nameof(Truck))
                        {
                            truck.Refuel(arg);
                        }
                        else if (vehicleType == nameof(Bus))
                        {
                            bus.Refuel(arg);
                        }
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);

                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());

        }

        private void DriveEmptyCommand(IVehicle bus, string vehicleType, double arg)
        {
            bus.TurnAirConditionerOff();
            bool hasDriven = bus.Drive(arg);

            if (hasDriven)
            {
                Console.WriteLine($"{vehicleType} travelled {arg} km");
            }
            else
            {
                Console.WriteLine($"{vehicleType} needs refueling");
            }
        }

        private static void DriveCommand(IVehicle car, IVehicle truck, IVehicle bus, string vehicleType, double arg)
        {
            bool hasDriven = false;

            if (vehicleType == nameof(Car))
            {
                hasDriven = car.Drive(arg);
            }
            else if (vehicleType == nameof(Truck))
            {
                hasDriven = truck.Drive(arg);
            }
            else if (vehicleType == nameof(Bus))
            {
                bus.TurnAirConditionerOn();
                hasDriven = bus.Drive(arg);
            }

            if (hasDriven)
            {
                Console.WriteLine($"{vehicleType} travelled {arg} km");
            }
            else
            {
                Console.WriteLine($"{vehicleType} needs refueling");
            }
        }

        private IVehicle CreateVehicle(string[] data)
        {
            string type = data[0];
            double fuelQuantity = double.Parse(data[1]);
            double fuelConsumption = double.Parse(data[2]);
            double tankCapacity = double.Parse(data[3]);

            IVehicle vehicle = this.vehicleFactory.CreateVehicle(type, fuelQuantity, fuelConsumption, tankCapacity);
            return vehicle;
        }
    }
}
