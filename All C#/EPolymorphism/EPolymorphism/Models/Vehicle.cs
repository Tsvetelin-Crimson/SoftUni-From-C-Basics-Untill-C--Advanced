using System;

namespace Vehicle.Models
{
    public abstract class Vehicle : IVehicle
    {
        private const double DefaultFuelQuantity = 0;

        private double tankCapacity;
        protected Vehicle(double fuelQuantity, double fuelConsuption, double tankCapacity, bool hasAirConditioner = true)
        {
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsuption;
            this.HasAirConditioner = hasAirConditioner;
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = DefaultFuelQuantity;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; }

        public bool HasAirConditioner { get; private set; }

        public abstract double AirConditionerFuelConsumption { get; }

        public double TankCapacity {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                this.tankCapacity = value;
            }

            }

        public bool Drive(double distance)
        {
            double spentFuel = FuelConsumption * distance;

            if (HasAirConditioner)
            {
                spentFuel += this.AirConditionerFuelConsumption * distance;
            }

            if (spentFuel > FuelQuantity)
            {
                return false;
            }

            FuelQuantity -= spentFuel;
            return true;
        }

        public virtual bool Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            if (fuel + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            this.FuelQuantity += fuel;
            return true;
        }

        public void TurnAirConditionerOff()
        {
            this.HasAirConditioner = false;
        }

        public void TurnAirConditionerOn()
        {
            this.HasAirConditioner = true;

        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";

        }
    }
}
