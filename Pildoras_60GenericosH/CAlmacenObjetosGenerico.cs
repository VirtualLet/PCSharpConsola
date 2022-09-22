using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_60GenericosH
{
    class CAlmacenObjetosGenerico<T>
    {
        private T[] datosElementos;
        private int i = 0;
        public CAlmacenObjetosGenerico(int numElementos)
        {
            datosElementos = new T[numElementos];
        }

        public void AgregarElemento(T elemento)
        {
            datosElementos[i] = elemento;
            i++;
        }
        public T GetElemento(int posicion)
        {
            return datosElementos[posicion];
        }

        public T[] GetArray()
        {
            return datosElementos;
        }

        //public void MuestraElementosArray()
        //{
        //    for (int i = 0; i < datosElementos.Length; i++)
        //    {
        //        Console.WriteLine("[{0}]{1}", i, GetElemento(i));
        //    }
        //}

        //public void MuestraElementos()
        //{
        //    foreach (T item in datosElementos)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}

