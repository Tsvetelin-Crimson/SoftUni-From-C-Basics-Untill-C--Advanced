using Vehicle.Models;

namespace Vehicle
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string type,double fuelQuantity, double fuelConsuption, double tankCapacity, bool hasAirConditioner = true);
    }
}
