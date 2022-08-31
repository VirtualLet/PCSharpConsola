using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_12MetodosEstaticos
{
    class CCalculadora
    {

        private double valorA;
        private double valorB;
        private double resultado;
        public CCalculadora(double pValorA, double pValorB)
        {
            valorA = pValorA;
            valorB = pValorB;
        }

        public void Suma()=> resultado = valorA + valorB;
        public void Resta() => resultado = valorA - valorB;

        public double Resultado { get => resultado; }
    }
}
