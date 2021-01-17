using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> songsQueue = new Queue<string>(songs);

            string command = Console.ReadLine();

            while (songsQueue.Count > 0)
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (tokens[0])
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;

                    case "Add":
                        string songName = string.Join(" ",tokens.Skip(1).ToArray());
                        if (songsQueue.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(songName);
                        }
                        break;

                    case "Show":
                        Console.WriteLine(string.Join(", ", songsQueue));
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
