using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.cars = new List<Car>();
        }

        public void Add(Car car)
        {
            if (this.Count < this.Capacity)
            {
                cars.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Car carToBeRemoved = cars.FirstOrDefault(k => k.Manufacturer == manufacturer && k.Model == model);
            bool isRemoved = false;
            if (carToBeRemoved != null)
            {
                return cars.Remove(carToBeRemoved);
            }
            return isRemoved;
        }

        public Car GetLatestCar()
        {
            Car latestCar = cars.OrderByDescending(k => k.Year).FirstOrDefault();
            return latestCar;
        }
        public Car GetCar(string manufacturer, string model)
        {
            Car neededCar = cars.FirstOrDefault(k => k.Manufacturer == manufacturer && k.Model == model);
            return neededCar;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (Car car in cars)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().Trim();
        }
        public int Count => this.cars.Count;
        public string Type { get; set; }
        public int Capacity { get; set; }

    }
}
