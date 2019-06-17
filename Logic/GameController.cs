using System;
using System.Threading;
using TestPac.Data;
using TestPac.View;

namespace TestPac.Logic
{
    class GameController
    {
        private Pacman _pacman { get; }
        private Ghost _ghost { get; }
        private Ghost _ghostTwo { get; }
        private Draw _draw { get; }
        private Map Zemelapis { get; set; }
        private char[,] ZaidimoLenta { get; set; }

        public GameController()
        {     
            Zemelapis = new Map();
            _pacman = new Pacman(5, 5, Zemelapis);
            _ghost = new Ghost(1, 5, Zemelapis);
            Console.ForegroundColor = ConsoleColor.Gray;
            Zemelapis.ZaidimoLenta[_pacman.PacmanX, _pacman.PacmanY] = GameObjects.Pacman;
            Zemelapis.ZaidimoLenta[_ghost.GhostX, _ghost.GhostY] = GameObjects.Vaiduoklis;
            _draw = new Draw(Zemelapis);
        }

        public void Start()
        {
            Console.CursorVisible = false;
            while (!_pacman.GameOver && !_ghost.GameOver)
            {
                _pacman.PacmanKordinates();
                _ghost.VaiduoklioKordinates(_pacman.ValgomasVaiduoklis, _pacman.PacmanSuvalge);
                _pacman.ValgomasVaiduoklis = false;
                Console.SetCursorPosition(22, 3);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("SCORE:");
                if (_pacman.score == 1230)
                {
                    Console.Clear();
                    Console.Write("!!!! YOU WON !!!!");
                    break;
                }
                 else if (!_pacman.GameOver && ! _ghost.GameOver)
                    _draw.Piesti();

                Thread.Sleep(400);
            }
        }
    }
}
