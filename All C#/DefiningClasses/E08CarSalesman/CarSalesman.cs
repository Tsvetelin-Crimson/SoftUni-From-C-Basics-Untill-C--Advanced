using System;
using System.Collections.Generic;
using System.Linq;

namespace E08CarSalesman
{
    class CarSalesman
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Engine> engines = new List<Engine>();
            
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                Engine currEngine = new Engine(model, power);
             
                if (tokens.Length == 3)
                {
                    string efficiency = tokens[2];
                    int displacement;
                    bool isDisplacement = int.TryParse(efficiency, out displacement);
                    if (isDisplacement)
                    {
                        currEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        currEngine = new Engine(model, power, efficiency);
                    }

                }
                else if (tokens.Length == 4)
                {
                    int displacement = int.Parse(tokens[2]);
                    string efficiency = tokens[3];

                    currEngine = new Engine(model, power, displacement, efficiency);
                    
                }
                engines.Add(currEngine);
            }



            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                Engine engine = engines.Find(k => k.Model == tokens[1]);
                Car currCar = new Car(model, engine);                

                if (tokens.Length == 3)
                {
                    string color = tokens[2];
                    int weight;
                    bool isWeight = int.TryParse(color, out weight);

                    if (isWeight)
                    {
                        currCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        currCar = new Car(model, engine, color);
                    }
                }
                else if (tokens.Length == 4)
                {
                    int weight = int.Parse(tokens[2]);
                    string color = tokens[3];
                    currCar = new Car(model, engine, weight, color);
                }

                cars.Add(currCar);
            }

            ;
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }


        }
    }
}
