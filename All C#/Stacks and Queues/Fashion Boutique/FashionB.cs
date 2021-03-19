using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class FashionB
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int racksSize = int.Parse(Console.ReadLine());
            Stack<int> boxes = new Stack<int>(clothes);

            int racks = 1;
            int rackAmmount = 0;
            while (boxes.Any())
            {
                int curBox = boxes.Peek();

                if (curBox + rackAmmount == racksSize)
                {
                    rackAmmount = 0;
                    racks++;
                    boxes.Pop();
                }
                else if (curBox + rackAmmount > racksSize)
                {
                    rackAmmount = 0;
                    racks++;
                }
                else
                {
                    rackAmmount += curBox;
                    boxes.Pop();
                }
            }
            if (rackAmmount == 0)
            {
                racks--;
            }
            Console.WriteLine(racks);
        }
    }
}
