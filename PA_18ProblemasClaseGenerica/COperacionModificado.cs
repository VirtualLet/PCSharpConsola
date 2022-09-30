using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_ProblemasClaseGenerica
{
    class COperacionModificado<T>
    {
        dynamic itemA;
        dynamic itemB;
        public string Mensaje { get =>  "\nEl tipo de valor ingresado no puede hacer uso del Método"; }
        public T Suma(T pValorA, T pValorB)
        {
            itemA = pValorA;
            itemB = pValorB;

            if (EncuentraTipo())                       
                return itemA + itemB;
            else
                return default(T);
        }
        public T Multiplicacion(T pValorA, T pValorB)
        {
            itemA = pValorA;
            itemB = pValorB;

            if (EncuentraTipo())
                return itemA * itemB;
            else
                return default(T);
        }

        public T Dividir(T pValorA, T pValorB)
        {
            itemA = pValorA;
            itemB = pValorB;

            if (EncuentraTipo())
                return itemA / itemB;
            else
                return default(T);
        }
        public T Resta(T pValorA, T pValorB)
        {
            itemA = pValorA;
            itemB = pValorB;

            if (EncuentraTipo())
                return itemA - itemB;
            else
                return default(T);
        }

        private bool EncuentraTipo()
        {
            if (typeof(T) == typeof(int))
                return true;
            if (typeof(T) == typeof(double))
                return true;
            if (typeof(T) == typeof(float))
                return true;
            else return false;
        }
        public override string ToString()
        {
            return string.Format("\nnum={0}  num={1}", itemA, itemB);
        }
    }
}
