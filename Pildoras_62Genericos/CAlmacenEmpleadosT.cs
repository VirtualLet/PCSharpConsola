using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_62Genericos
{
    class CAlmacenEmpleadosT<T>where T:IParaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleados;
        public CAlmacenEmpleadosT(int numElementos)
        {
            datosEmpleados = new T[numElementos];
        }

        public void AgregarElemento(T elemento)
        {
            datosEmpleados[i] = elemento;
            i++;
        }
        public T GetElemento(int posicion)
        {
            return datosEmpleados[posicion];
        }
    }
}
