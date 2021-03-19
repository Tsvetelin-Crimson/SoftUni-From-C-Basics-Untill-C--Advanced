using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class BombN
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> bombNumberAndStrength = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int bombNumber = bombNumberAndStrength[0],
                strength = bombNumberAndStrength[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    i = ExecuteBombExplosions(list, strength, i);

                }
            }

            Console.WriteLine(list.Sum());
        }

        private static int ExecuteBombExplosions(List<int> list, int strength, int i)
        {
            int strengthRight = strength;
            strengthRight = CheckIfStrengthTooMuchRight(list, strength, i, strengthRight);

            for (int j = 0; j <= strengthRight; j++)
            {
                list.RemoveAt(i);
            }
            int strengthLeft = strength;
            strengthLeft = CheckIfStrengthTooMuchLeft(list, strength, i, strengthLeft);

            for (int j = 0; j < strengthLeft; j++)
            {
                list.RemoveAt(i - (1 + j));
            }
            //list.RemoveAt(i - strengthLeft);
            if (list.Count - (list.Count - i) < strength)
            {
                i--;
            }

            return i;
        }

        private static int CheckIfStrengthTooMuchLeft(List<int> list, int strength, int i, int strengthLeft)
        {
            if (list.Count - (list.Count - i) < strength)
            {
                strengthLeft = list.Count - (list.Count - i);
            }

            return strengthLeft;
        }

        private static int CheckIfStrengthTooMuchRight(List<int> list, int strength, int i, int strengthRight)
        {
            if (i + strength >= list.Count)
            {
                strengthRight = list.Count() - (i + 1);
            }

            return strengthRight;
        }
    }
}
