using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_18FuncionesVirtualesOverride
{
    class CProductoDetenido:CProductoImportado
    {
        private double multa;
        public CProductoDetenido(string pDescripcion, double pPrecioCompra, double pPrecioVenta, double pImpuesto, double pMulta)
            :base (pDescripcion,pPrecioCompra,pPrecioVenta,pImpuesto)
        {
            multa = pMulta;
        }

        //Si se usa sealed, sellamos el método para que las clases que desciendan de CProductoDetenido no puedan tener su propia version de CalculaPrecio
        public sealed override void CalculaPrecio()
        {
            precioVenta = FormulaProductoImportado() + multa;
        }
    }
}
