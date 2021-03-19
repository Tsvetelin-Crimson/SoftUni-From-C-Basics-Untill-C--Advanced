using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Models
{
    public class Bus : Vehicle
    {
        private const double DefaultAirConditionerFuelConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsuption, double tankCapacity, bool hasAirConditioner = true) 
            : base(fuelQuantity, fuelConsuption, tankCapacity, hasAirConditioner)
        {
        }

        public override double AirConditionerFuelConsumption => DefaultAirConditionerFuelConsumption;
    }
}
