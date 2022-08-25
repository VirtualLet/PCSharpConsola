using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_02IEnumerable
{
    class CAuto:IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;
        public CAuto(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000 + costo + pImpuesto;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Automovil {0}, tiene un costo de {1}, y tenencia de {2}", modelo, costo, tenencia);
            Console.WriteLine("Total apagar {0}", costo+tenencia);
            Console.WriteLine("----");
        }
    }
}
