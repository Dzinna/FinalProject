using System;
using TestPac.Logic;

namespace TestPac.Data
{
    class Ghost
    {
        private static bool _initialStart = true;
        private static char _busimasChar = ' ';

        private int newX = 0;
        private int newY = 0;

        public int GhostX { get; set; }
        public int GhostY { get; set; }
        public bool GameOver { get; set; }
        private Map Zemelapis { get; set; }
        private TimeControll Laikas { get; set; }

        public Ghost(int x, int y, Map zemelapis)
        {
            GhostX = x;
            GhostY = y;
            Zemelapis = zemelapis;
        }

        public void VaiduoklioKordinates(bool ValgomasVaiduoklis, bool pacmanasSuvalge)
        {
            var indeksas = new Random()
                .Next(0, 4);

            switch (indeksas)
            {
                case 0:
                    newX = GhostX;
                    newY = GhostY + 1;
                    break;
                case 1:
                    newX = GhostX;
                    newY = GhostY - 1;
                    break;
                case 2:
                    newX = GhostX + 1;
                    newY = GhostY;
                    break;
                case 3:
                    newX = GhostX - 1;
                    newY = GhostY;
                    break;
            }

            if (Zemelapis.ZaidimoLenta[newX, newY] != GameObjects.Siena)
            {
                if (_initialStart)
                {
                    _busimasChar = Zemelapis.ZaidimoLenta[newX, newY];
                    Zemelapis.ZaidimoLenta[GhostX, GhostY] = GameObjects.Zirniukas;
                    Zemelapis.ZaidimoLenta[newX, newY] = GameObjects.Vaiduoklis;
                    GhostX = newX;
                    GhostY = newY;
                    _initialStart = false;
                }
                else
                {
                    if (Zemelapis.ZaidimoLenta[newX, newY] == GameObjects.Pacman)
                    {
                        Console.Clear();
                        Console.Write("Oh no Ghost ! Game over !");
                        GameOver = true;
                    }

                    

                    if (Zemelapis.ZaidimoLenta[GhostX, GhostY] == GameObjects.ValgomasVaiduoklis)
                    {
                        Zemelapis.ZaidimoLenta[GhostX, GhostY] = _busimasChar;
                    }

                    if (Zemelapis.ZaidimoLenta[GhostX, GhostY] == GameObjects.Vaiduoklis)
                    {
                        Zemelapis.ZaidimoLenta[GhostX, GhostY] = _busimasChar;
                    }

                    if (Zemelapis.ZaidimoLenta[newX, newY] == GameObjects.Zirniukas)
                    {
                        _busimasChar = GameObjects.Zirniukas;
                    }
                    else
                    {
                        _busimasChar = Zemelapis.ZaidimoLenta[newX, newY];
                    }

                    Zemelapis.ZaidimoLenta[newX, newY] = GameObjects.Vaiduoklis;

                    GhostX = newX;
                    GhostY = newY;
                }
            }

            if (ValgomasVaiduoklis)
            {
                if (Laikas == null)
                {
                    Laikas = new TimeControll();
                }

                Laikas.SetTime();

                Zemelapis.ZaidimoLenta[GhostX, GhostY] = GameObjects.ValgomasVaiduoklis;
                GameObjects.LaikinasVaiduoklis = GameObjects.Vaiduoklis;
                GameObjects.Vaiduoklis = GameObjects.ValgomasVaiduoklis;
            }
            else
            {
                if (Laikas != null)
                {
                    if (Laikas.LaikasBaigesi)
                    {
                        GameObjects.Vaiduoklis = GameObjects.LaikinasVaiduoklis;
                    }

                }
            }
            if (pacmanasSuvalge)
            {
                GameObjects.Vaiduoklis = GameObjects.LaikinasVaiduoklis;
            }
        }
    }
}
