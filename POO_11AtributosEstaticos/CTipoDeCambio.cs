using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_11AtributosEstaticos
{
    class CTipoDeCambio
    {
        private static double tipoCambio;
        private string producto;
        private double costo;

        public CTipoDeCambio()
        {
            producto = "Moneda";
            costo = 100;
        }

        public CTipoDeCambio(string pProducto, double pCosto)
        {
            producto = pProducto;
            costo = pCosto;
        }

        public double TipoCambio
        {
            set=>  tipoCambio = value;
        }

        public void MuestraDolares()
        {
            Console.WriteLine("Producto:{0} Costo:{1} TipoCambio:{2}, PrecioTotal:{3} ",producto,costo,tipoCambio,costo*tipoCambio);
        }
    }
}
