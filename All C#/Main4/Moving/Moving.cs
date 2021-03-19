using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int roomWidth = int.Parse(Console.ReadLine()),
                roomLength = int.Parse(Console.ReadLine()),
                roomheight = int.Parse(Console.ReadLine()),
                room = roomheight * roomLength * roomWidth;

            while (room > 0)
            {
                string box = Console.ReadLine();
                if(box == "Done")
                {
                    break;
                }
                room -= int.Parse(box);
            }

            if(room > 0)
            {
                Console.WriteLine($"{room} Cubic meters left.");
            }
            else
            {
                room = Math.Abs(room);
                Console.WriteLine($"No more free space! You need {room} Cubic meters more.");
            }

        }
    }
}
