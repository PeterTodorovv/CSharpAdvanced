using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));

            while(songs.Count > 0)
            {
                string[] input = Console.ReadLine().Split(" ", 2);
                string command = input[0];

                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        if (songs.Contains(input[1]))
                        {
                            Console.WriteLine($"{input[1]} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(input[1]);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;

                }
            }         
            Console.WriteLine("No more songs!");

        }
    }
}
