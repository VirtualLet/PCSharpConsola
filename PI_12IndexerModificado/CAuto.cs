using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_12IndexerModificado
{
    class CAuto
    {
        double costo;
        double tenencia;
        string modelo;
        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }
        public void MuestraInformacion()
        {
            Console.WriteLine("Automovil:{0} \nCosto:{1}", modelo, costo);
        }

        public override string ToString()
        {
            return string.Format("Automovil:{0} Costo:{1}", modelo, costo);
        }
    }
}
