using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_19NewEnMetodos
{
    class CProducto
    {
        private string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcion, double pPrecioCompra, double pPrecioVenta)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = pPrecioVenta;
        }
        protected double FormulaProducto() => precioCompra * 1.3;
        public virtual void CalculaPrecio()
        {
            Console.WriteLine("CalculaPrecio de la clase CProducto");
            precioVenta = FormulaProducto();
        }

        public  void MuestraVenta()
        {
            Console.WriteLine("{0} se vende en {1}", descripcion, precioVenta);
        }
    }
}
