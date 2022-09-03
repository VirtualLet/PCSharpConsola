using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_20Abstract
{
    class CProductoDetenido:CProducto
    {
        private double multa;
        private double impuesto;
        public CProductoDetenido(string pDescripcion, double pPrecioCompra, double pPrecioVenta, double pImpuesto,  double pMulta)
            : base(pDescripcion, pPrecioCompra, pPrecioVenta)
        {
            impuesto = pImpuesto;
            multa = pMulta;
        }

        //Si se usa sealed, sellamos el método para que las clases que desciendan de CProductoDetenido no puedan tener su propia version de CalculaPrecio
        public override void CalculaPrecio()
        {
            Console.WriteLine("Calculo de cProducto Detenido");
            precioVenta = (precioCompra * 1.3 * (1 + impuesto)) + multa;
        }

        public override void MuestraVenta()
        {
            Console.WriteLine("El producto en aduana {0} tiene un costo de {1}",descripcion,precioVenta);
        }
    }
}
