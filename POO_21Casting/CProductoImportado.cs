using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_21Casting
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;
        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
            : base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
        }

        protected double FormulaProductoImportado() => precioCompra * 1.3 * (1 + impuesto);
        public override void CalculaPrecio()
        {
            Console.WriteLine("CalcularPrecio de CProductoImportado");
            // precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
            precioVenta = FormulaProductoImportado();
        }

        public override  string ToString()
        {
           return string.Format("El productoImportado {0} se vende en:{1}", descripcion, precioVenta);
        }
        public void Mensaje()
        {
            Console.WriteLine("Soy un producto importado");
        }
    }
}
