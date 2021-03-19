using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class TruckT
    {
        static void Main(string[] args)
        {
            int stations = int.Parse(Console.ReadLine());
            Queue<int> pumps = new Queue<int>();

            for (int i = 0; i < stations; i++)
            {
                int[] station = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int ammountOfPetrol = station[0] - station[1];
                pumps.Enqueue(ammountOfPetrol);
            }


            
            int index = 0;
            for (int i = 0; i < stations; i++)
            {
                int truck = 0;
                bool isCompleted = true;

                for (int j = 0; j < stations; j++)
                {
                    int currStation = pumps.Dequeue();
                    pumps.Enqueue(currStation);

                    if (currStation + truck >= 0)
                    {
                        truck += currStation;
                    }
                    else
                    {
                        isCompleted = false;
                    }
                }

                pumps.Enqueue(pumps.Dequeue());

                if (isCompleted)
                {
                    index = i;
                    break;
                }
            }



            Console.WriteLine(index);
        }
    }
}
