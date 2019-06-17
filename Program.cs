using System;
using TestPac.Logic;

namespace TestPac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("PACMAN GAME\n");

            var game = new GameController();
            game.Start();
            Console.ReadKey();
        }
    }
}
