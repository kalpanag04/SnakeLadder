using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game");
            SnakeLadderGame game = new SnakeLadderGame();
            game.Board();
        }
    }
}