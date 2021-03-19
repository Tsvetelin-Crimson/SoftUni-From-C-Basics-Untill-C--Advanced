using System;
using System.Collections.Generic;
using System.Text;

namespace E06SpeedRacing
{
    public class Car
    {
        public Car()
        {

        }

        public void Drive(double kilometersToDrive)
        {
            double usedFuel = kilometersToDrive * this.FuelConsumptionPerKilometer;

            if (usedFuel <= this.FuelAmount)
            {
                this.FuelAmount -= usedFuel;
                this.TravelledDistance += kilometersToDrive;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }


    }
}
