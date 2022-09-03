using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_20Abstract
{
 abstract   class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto( string pDescripcion, double pPrecioCompra, double pPrecioVenta)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = pPrecioVenta;
        }

        public virtual void CalculaPrecio()
        {
            precioVenta = precioCompra * 1.3;
        }

        public abstract void MuestraVenta();
    }

}
