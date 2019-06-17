using System;
using TestPac.View;

namespace TestPac.Data
{
    class Pacman 
    {
        private int _kryptisX = 0;
        private int _kryptisY = 0;

        public int PacmanX { get; set; }
        public int PacmanY { get; set; }

        private Map Zemelapis { get; set; }
        private CalculateScore CalculateSc { get; set; }
        

        public bool GameOver { get; set; }
        public bool ValgomasVaiduoklis { get; set; }
        public bool PacmanSuvalge { get; set; }

        public Pacman (int x, int y, Map zemelapis, CalculateScore calculateSc)
        {
            PacmanX = x;
            PacmanY = y;
            Zemelapis = zemelapis;
            CalculateSc = calculateSc;
        }

        public void PacmanKordinates()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        _kryptisX = -1;
                        _kryptisY = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        _kryptisX = 1;
                        _kryptisY = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        _kryptisX = 0;
                        _kryptisY = -1;
                        break;
                    case ConsoleKey.RightArrow:
                        _kryptisX = 0;
                        _kryptisY = 1;
                        break;
                }
                
            }

            var newX = PacmanX + _kryptisX;
            var newY = PacmanY + _kryptisY;

            if (Zemelapis.ZaidimoLenta[newX, newY] != GameObjects.Siena)
            {
                CalculateSc.CalcScore(newX, newY);
                if (Zemelapis.ZaidimoLenta[newX, newY] == 'W')
                {
                    PacmanSuvalge = true;
                    Zemelapis.ZaidimoLenta[PacmanX, PacmanY] = ' ';

                    Zemelapis.ZaidimoLenta[newX, newY] = GameObjects.Pacman;

                    PacmanX = newX;
                    PacmanY = newY;
                }
                else if (Zemelapis.ZaidimoLenta[newX, newY] != GameObjects.Vaiduoklis)     
                {
                    EatGhost(newX, newY);
                    Zemelapis.ZaidimoLenta[PacmanX, PacmanY] = ' ';
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Zemelapis.ZaidimoLenta[newX, newY] = GameObjects.Pacman;

                    PacmanX = newX;
                    PacmanY = newY;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Oh no Ghost ! Game over !");
                    Console.SetCursorPosition(22, 4);
                    Console.WriteLine(CalculateSc.Score);
                    GameOver = true;
                }
            }
        }

        public void EatGhost(int x, int y)
        {
            if (Zemelapis.ZaidimoLenta[x, y] == GameObjects.StebuklingasZirniukas)
            {
                ValgomasVaiduoklis = true;
            }
        }
    }
}
