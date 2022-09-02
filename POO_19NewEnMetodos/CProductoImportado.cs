using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_19NewEnMetodos
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;
        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pPrecioVenta, double pImpuesto)
            : base(pDescripcion, pPrecioCompra, pPrecioVenta)
        {
            impuesto = pImpuesto;
        }

        protected double FormulaProductoImportado() => FormulaProducto() * (1 + impuesto);
        public override void CalculaPrecio()
        {
            Console.WriteLine("CalcularPrecio de CProductoImportado");
            // precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
            precioVenta = FormulaProductoImportado();
        }

        //New en el método permite que hagamos uso de nuestra propia version MuestraVenta, pero rompemos con el polimorfismo
        public new void MuestraVenta()
        {
            
            Console.WriteLine("Precio Venta {0} con impuesto {1}",  precioVenta, impuesto);
        }
    }
}
