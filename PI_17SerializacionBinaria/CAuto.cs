using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_17SerializacionBinaria
{
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }
        public void MuestraInformacion()
        {
            Console.WriteLine("Automovil {0} Costo {1}",modelo,costo);
            Console.WriteLine("----");
        }
    }
}
