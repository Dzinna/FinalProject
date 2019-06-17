using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPac.Data;

namespace TestPac.View
{
    class CalculateScore
    {
        public int Score { get; set; }
        private Map Zemelapis { get; }

        public CalculateScore(Map zemelapis)
        {
            Zemelapis = zemelapis;
        }

        public void CalcScore(int x, int y)
        {
            if (Zemelapis.ZaidimoLenta[x, y] == GameObjects.Zirniukas)
            {
                Score += 10;
                Console.SetCursorPosition(22, 4);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Score);
            }
            else if (Zemelapis.ZaidimoLenta[x, y] == GameObjects.ValgomasVaiduoklis)
            {
                Score += 50;
                Console.SetCursorPosition(22, 4);
                Console.WriteLine(Score);
            }
        }
    }
}
