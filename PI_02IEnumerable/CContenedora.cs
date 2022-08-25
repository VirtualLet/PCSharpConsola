using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_02IEnumerable
{
    class CContenedora: IEnumerable
    {
        private int[] valores = new int[10];
        public CContenedora()
        {
            for (int i=0; i<10; i++)
            {
                valores[i] = i * i;
            }
        }

        //Se implementa el GetEnumerator requerido por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            //se instancia el enumerator y se regresa;
            return (new CContenedoraEnum(valores));
        }
    }

    class CContenedoraEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;
       public CContenedoraEnum(int [] pArreglo)
        {
            arreglo = pArreglo;
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                 return true;
            else
                return false;
        }
        public void Reset()
        {
            posicion = -1;
        }

        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
    }
}
