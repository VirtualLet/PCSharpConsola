using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_14SortedSet
{
    class CPunto : IComparable<CPunto>
    {
        private int x;
        private int y;

        public CPunto(int pX, int pY)
        {
            x = pX;
            y = pY;
        }
        public int X { get => x; }
        public int Y { get => y; }

        private int SumaXY { get => x + y; }

        //Comparando por la suma de los dos puntos x+y para ordenar
        public int CompareTo(object obj)
        {
            CPunto punto = (CPunto)obj;
            if (SumaXY < punto.SumaXY) return 1;
            else if (SumaXY > punto.SumaXY) return -1;
            else return 0;
        }

        public int CompareTo(CPunto objPunto)
        {
            double magnitudA = Math.Sqrt(x * x + y * y);
            double magnitudB = Math.Sqrt(objPunto.x * objPunto.x + objPunto.y * objPunto.y);
            if (magnitudA > magnitudB)
                return 1;
            else if (magnitudA < magnitudB)
                return -1;
            else return 0;
        }

        //Comparando a x para ordenarlo por x
        //public int CompareTo(object obj)
        //{
        //    CPunto punto = (CPunto)obj;
        //    if (x < punto.x) return 1;
        //    else if (x > punto.x) return -1;
        //    else return 0;

        //}

        public override string ToString()
        {
            return string.Format("coordedandas ({0},{1})", x, y);
        }
    }
}
