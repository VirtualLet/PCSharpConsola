using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_21Casting
{
    class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcion, double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
        }

        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de CProducto");
            precioVenta = precioCompra * 1.3;
        }

        public override string ToString()
        {
            return string.Format("El producto {0} preciocompra {1} precio venta {2}", descripcion, precioCompra, precioVenta);
        }

    }
}
