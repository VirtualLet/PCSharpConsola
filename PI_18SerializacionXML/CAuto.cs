using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_18SerializacionXML
{
    [Serializable]
    //La clase debe ser publica
   public class CAuto
    {
        private double costo;
        private string modelo;
        public CAuto()//El constructor no debe tener parametros
        {
            Costo = 1000;
            Modelo = "Vocho";
        }

        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public void MuestraInformacion()
        {
            Console.WriteLine("Automovil {0} Costo {1}",Modelo,Costo);
            Console.WriteLine("----");
        }
    }
}
