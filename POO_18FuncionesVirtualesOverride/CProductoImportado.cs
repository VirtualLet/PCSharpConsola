using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_18FuncionesVirtualesOverride
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;
        public CProductoImportado(string pDescripcion, double pPrecioCompra,double pPrecioVenta, double pImpuesto)
            :base(pDescripcion,pPrecioCompra, pPrecioVenta)
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
    }
}
