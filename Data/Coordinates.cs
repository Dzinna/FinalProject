using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPac.Data
{
    abstract class Coordinates
    {
        protected int positionX;
        protected int positionY;        

        public Coordinates(int x, int y)
        {
            positionX = x;
            positionY = y;
        }
    }
}
