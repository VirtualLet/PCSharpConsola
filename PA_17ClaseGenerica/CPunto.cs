using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_17ClaseGenerica
{
    class CPunto<T>
    {
        private T x;
        private T y;

        public CPunto(T pX, T pY)
        {
            x = pX;
            y = pY;
        }
        public T X { get => x; }
        public T Y { get => y; }

        public void Reset()
        {//Colocamos el valor de default para el tipo T
            //Numericos 0
            //Referencias null
            x = default(T);
            y = default(T);
        }

        public void EncuentraTipo()
        {
            if (typeof(T) == typeof(int))
                Console.WriteLine("Trabaja con enteros");
            else
                Console.WriteLine("Soy de otro tipo");
        }
        public override string ToString()
        {
            return string.Format("coordedandas ({0},{1})", x, y);
        }
    }
}
