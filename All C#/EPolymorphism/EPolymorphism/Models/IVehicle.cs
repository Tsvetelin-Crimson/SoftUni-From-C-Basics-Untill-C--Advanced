

namespace Vehicle.Models
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double TankCapacity { get; }

        double FuelConsumption { get; }

        bool HasAirConditioner { get; }

        double AirConditionerFuelConsumption { get; }

        bool Drive(double distance);

        bool Refuel(double fuel);

        void TurnAirConditionerOn();

        void TurnAirConditionerOff();
    }
}
