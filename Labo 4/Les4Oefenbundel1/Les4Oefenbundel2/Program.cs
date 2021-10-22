using System;
using System.Collections.Generic;

namespace Les4Oefenbundel2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>() {
                new Game() { Name = "Starcraft 2", Genre = "RTSG", PickOrder = "idk" },
                new Game() { Name = "Tarkov", Genre = "FPS", PickOrder = "idk" }
            };

            foreach (var game in games)
            {
                Console.WriteLine(game.ToString());
            }
        }
    }
}
