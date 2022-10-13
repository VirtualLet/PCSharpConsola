using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_29JerarquiaDeInterfaces
{
    class CSuma : ICalcular
    {
        private int valorA;
        private int valorB;
        private int resultado;
        public int Calcular(int pValorA, int pvalorB)
        {
            valorA = pValorA;
            valorB = pvalorB;
            resultado = valorA + valorB;
            return resultado;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("{0}+{1}={2} ",valorA,valorB,resultado);
        }
    }
}
