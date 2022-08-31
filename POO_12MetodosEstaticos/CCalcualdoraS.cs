using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_12MetodosEstaticos
{
    class CCalcualdoraS
    {
        public static double Suma(double valorA, double valorB)
        {
            return valorA + valorB;
        }

        public static double Resta(double valorA, double valorB)
        {
            return valorA - valorB;
        }

        public void Saludos()
        {
            Console.WriteLine("Este es el método no estatico Saludando");
        }
    }
}
