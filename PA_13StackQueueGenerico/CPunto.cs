using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_13StackQueueGenerico
{
    class CPunto
    {
        private int x;
        private int y;

        public CPunto(int pX, int pY)
        {
            x = pX;
            y = pY;
        }
        public override string ToString()
        {
            return string.Format("coordedandas ({0},{1})", x, y);
        }
    }
}
