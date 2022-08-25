using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NI_01Interfaces
{
    class Division : IOperacion
    {
        private double resultado;

        public void Calcular(double valorA, double valorB)
        {
            resultado = valorA / valorB;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la división es: {0}", resultado);
        }
    }
}
