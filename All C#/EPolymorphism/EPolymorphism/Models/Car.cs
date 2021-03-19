namespace Vehicle.Models
{
    public class Car : Vehicle
    {
        private const double DefaultAirConditionerFuelConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsuption, double tankCapacity, bool hasAirConditioner = true) 
            : base(fuelQuantity, fuelConsuption, tankCapacity, hasAirConditioner)
        {           
        }

        public override double AirConditionerFuelConsumption => DefaultAirConditionerFuelConsumption;

        
    }
}
