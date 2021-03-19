using Vehicle.Models;

namespace Vehicle.Factories
{
    class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsuption, double tankCapacity, bool hasAirConditioner = true)
        {
            IVehicle vehicle = null;
            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsuption, tankCapacity, hasAirConditioner);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsuption, tankCapacity, hasAirConditioner);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsuption, tankCapacity, hasAirConditioner);
            }

            return vehicle;
        }
    }
}
