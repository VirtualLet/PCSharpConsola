using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_60GenericosH
{
    class CAlmacenObjetos
    {
        private Object[] datosElementos;
        private int i = 0;
        public CAlmacenObjetos(int numElementos)
        {
            datosElementos = new Object[numElementos];
        }

        public void AgregarElemento(Object elemento)
        {
            datosElementos[i] = elemento;
            i++;
        }
        public Object GetElemento(int posicion)
        {
            return datosElementos[posicion];
        }

        public Object[] GetArray()
        {
            return datosElementos;
        }

        public void MuestraElementosArray()
        {
            for( int i=0; i< datosElementos.Length; i++)
            {
                Console.WriteLine("[{0}]{1}",i,GetElemento(i));
            }
        }

        public void MuestraElementos()
        {
            foreach(Object item in datosElementos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
