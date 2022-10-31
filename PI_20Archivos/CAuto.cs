using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_20Archivos
{
    internal class CAuto
    {
        private double costo;
        private string modelo;
        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        //Constructor
        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }
        public void MuestraInformacion()
        {
            Console.WriteLine("Automovi {0}, Costo {1}\n----------",modelo, costo);
        }
    }
}
