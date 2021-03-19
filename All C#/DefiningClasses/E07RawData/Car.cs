using System;
using System.Collections.Generic;
using System.Text;

namespace E07RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,  List<double> tiresPressure ,List<int> tiresAges)
        {
            this.Model = model;
            this.CurrEngine = new Engine(engineSpeed, enginePower);

            this.CurrCargo = new Cargo(cargoWeight, cargoType);
            this.CurrTires = new Tires(tiresAges, tiresPressure);
            
        }

        public Engine CurrEngine { get; set; }
        public Cargo CurrCargo { get; set; }
        public Tires CurrTires { get; set; }
        public string Model { get; set; }


    }
}
