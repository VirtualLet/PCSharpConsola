using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_04ICloneable
{
    class CAuto:IAutomovil ,ICloneable
    {
        double costo;
        double tenencia;
        string modelo;
        double impuesto;
        public CAuto(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public string Modelo { get; set; } = "BMW";
        public double Costo
        {
            get => costo;
            set => costo = value;
        }
        public double Tenencia
        {
            get { return tenencia; }
            set { tenencia = value; }
        }

      
        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000 + costo + pImpuesto;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Automovil {0}, tiene un costo de {1}, y tenencia de {2}", modelo, costo, tenencia);
            Console.WriteLine("Total apagar {0}", costo + tenencia);
            Console.WriteLine("----");
        }

        //Se implementa el método de Clone(), de la interfaz Icloneable para poder usarlo
        public Object Clone()
        {
            CAuto auto = new CAuto(modelo, costo);
            auto.tenencia = tenencia;
            return auto;
        }
    }
}
