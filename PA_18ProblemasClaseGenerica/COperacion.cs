using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_ProblemasClaseGenerica
{
    class COperacion<T>
    {
        public T Suma(T valorA, T valorB)
        {
            dynamic dA = valorA, dB = valorB;
            return dA + dB;
        }
        public T Multiplicacion(T valorA, T valorB)
        {
            dynamic dA = valorA, dB = valorB;
            return dA * dB;
        }

        public T Dividir(T valorA, T valorB)
        {
            dynamic dA = valorA, dB = valorB;
            return dA / dB;
        }
        public T Resta(T valorA, T valorB)
        {
            dynamic dA = valorA, dB = valorB;
            return dA - dB;
        }

    }
}
