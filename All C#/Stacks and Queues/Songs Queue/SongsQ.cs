using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class SongsQ
    {
        static void Main(string[] args)
        {
            string[] startSongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(startSongs);
            while (songs.Any())
            {
                string input = Console.ReadLine();                
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                              
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    
                    string song = input.Substring(4);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

            }


            Console.WriteLine("No more songs!");
        }
    }
}
