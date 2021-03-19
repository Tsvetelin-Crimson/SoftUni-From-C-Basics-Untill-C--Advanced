using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Models
{
    public class Truck : Vehicle
    {
        private const double DefaultAirConditionerFuelConsumption = 1.6;
        private const double RefuelPercentage = 0.95;

        public Truck(double fuelQuantity, double fuelConsuption, double tankCapacity, bool hasAirConditioner = true) 
            : base(fuelQuantity, fuelConsuption, tankCapacity, hasAirConditioner)
        {
        }

        public override double AirConditionerFuelConsumption => DefaultAirConditionerFuelConsumption;

        public override bool Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            if (fuel + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            return base.Refuel(fuel * RefuelPercentage);                    
        }
        
    }
}
