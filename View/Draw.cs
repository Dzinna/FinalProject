using System;
using System.Text;
using TestPac.Data;

namespace TestPac.View
{
    class Draw
    {
        private int _eilutes { get; set; }
        private int _stulpeliai { get; set; }
        private Map Zemelapis { get; set; }

        public Draw(Map zemelapis)
        {

            Zemelapis = zemelapis;
            _eilutes = zemelapis.Eilutes;
            _stulpeliai = zemelapis.Stulpeliai;
        }
        public void Piesti()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorTop = 2;
            Console.CursorLeft = 0;

            StringBuilder builder = new StringBuilder();

            for (var i = 0; i < _eilutes; i++)
            {
                for (var j = 0; j < _stulpeliai; j++)
                {
                    //Console.ForegroundColor = ConsoleColor.Blue;
                    builder.Append(Zemelapis.ZaidimoLenta[i, j]);
                }
                builder.Append("\r\n");
            }

            Console.Write(builder.ToString());
        }

        /*public void AddDots()
        {
            for (int i = 0; i < _eilutes; i++)
            {
                if (i == 0 || i == 10)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                    }
                }
                else if (i == 1 || i == 9)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else if (i == 2 || i == 8)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 3 || j == 7 || j == 8 || j == 9 || j == 10 || j == 11 || j == 12 || j == 16 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else if (i == 3 || i == 7)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 3 || j == 16 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else if (i == 4 || i == 6)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 3 || j == 7 || j == 8 || j == 11 || j == 12 || j == 16 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 7 || j == 12 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }

            }
        }*/

        /*public void AddWalls()
        {
            for (int i = 0; i < _eilutes; i++)
            {
                if (i == 0 || i == 10)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                    }
                }
                else if (i == 1 || i == 9)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoTaskiukai[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else if (i == 2 || i == 8)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 3 || j == 7 || j == 8 || j == 9 || j == 10 || j == 11 || j == 12 || j == 16 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoTaskiukai[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else if (i == 3 || i == 7)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 3 || j == 16 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoTaskiukai[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else if (i == 4 || i == 6)
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 3 || j == 7 || j == 8 || j == 11 || j == 12 || j == 16 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoTaskiukai[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < _stulpeliai; j++)
                    {
                        if (j == 0 || j == 7 || j == 12 || j == 19)
                        {
                            Zemelapis.ZaidimoLenta[i, j] = GameObjects.Siena;
                        }
                        else
                        {
                            Zemelapis.ZaidimoTaskiukai[i, j] = GameObjects.Zirniukas;
                        }
                    }
                }
                
            }
        }

        public void Piesti()
        {
            //AddDots();
            AddWalls();
            
            Console.CursorTop = 2;
            Console.CursorLeft = 0;

            StringBuilder builder = new StringBuilder();

            for (var i = 0; i < _eilutes; i++)
            {
                for (var j = 0; j < _stulpeliai; j++)
                {
                    if (Zemelapis.ZaidimoLenta[i, j] == GameObjects.Siena)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        builder.Append(Zemelapis.ZaidimoLenta[i, j]);
                    }
                    else if (Zemelapis.ZaidimoTaskiukai[i, j] == GameObjects.Zirniukas)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        builder.Append(Zemelapis.ZaidimoTaskiukai[i, j]);
                    }
                    //builder.Append(Zemelapis.ZaidimoLenta[i, j]);
                    //builder.Append(Zemelapis.ZaidimoTaskiukai[i, j]);
                }
                builder.Append("\r\n");
            }

            Console.Write(builder.ToString());
        }*/
    }
}
