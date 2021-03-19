using System;
using System.Collections.Generic;

namespace E07RawData
{
    class RawData
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> fragileCars = new Dictionary<string, Car>();
            Dictionary<string, Car> flamableCars = new Dictionary<string, Car>();


            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]),
                    enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                double tire1Pressure = double.Parse(tokens[5]);
                int tire1Age = int.Parse(tokens[6]);
                double tire2Pressure = double.Parse(tokens[7]);
                int tire2Age = int.Parse(tokens[8]);
                double tire3Pressure = double.Parse(tokens[9]);
                int tire3Age = int.Parse(tokens[10]);
                double tire4Pressure = double.Parse(tokens[11]);
                int tire4Age = int.Parse(tokens[12]);

                List<double> tirePressures = new List<double>();
                List<int> tireAges = new List<int>();
                tirePressures.Add(tire1Pressure);
                tirePressures.Add(tire2Pressure);
                tirePressures.Add(tire3Pressure);
                tirePressures.Add(tire4Pressure);
                tireAges.Add(tire1Age);
                tireAges.Add(tire2Age);
                tireAges.Add(tire3Age);
                tireAges.Add(tire4Age);

                if (cargoType == "fragile")
                {
                    fragileCars.Add(model, new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tirePressures, tireAges));
                }
                else
                {
                    flamableCars.Add(model, new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tirePressures, tireAges));
                }
            }


            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach ((string model, Car currCar) in fragileCars)
                {
                    bool isFragile = false;

                    foreach (double pressure in currCar.CurrTires.Pressure)
                    {
                        if (pressure < 1) // may be =
                        {
                            isFragile = true;
                            break;
                        }
                    }

                    if (isFragile)
                    {
                        Console.WriteLine(model);
                    }

                }
            }
            else if (command == "flamable")
            {
                foreach ((string model, Car currCar) in flamableCars)
                {
                    if (currCar.CurrEngine.Power > 250)
                    {
                        Console.WriteLine(model);
                    }

                }
            }
        }
    }
}
