using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Building
    {
        static void Main(string[] args)
        {
            int stories = int.Parse(Console.ReadLine()),
                rooms = int.Parse(Console.ReadLine()),
                maxStories = stories;

            for (; 0 < stories; stories--)
            {
                for (int i = 0; i < rooms; i++)
                {
                    if (stories == maxStories)
                    {
                        Console.Write($"L{stories}{i} ");
                    }
                    else if(stories % 2 == 0)
                    {
                        Console.Write($"O{stories}{i} ");
                    }
                    else
                    {
                        Console.Write($"A{stories}{i} ");
                    }
                    
                }
                Console.WriteLine("");
            }

        }
    }
}
