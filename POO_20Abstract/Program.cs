using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_20Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            CProductoImportado productoImportado = new CProductoImportado("Bici", 200, 400, 2);
            CProductoDetenido productoDetenido = new CProductoDetenido("Bici", 200, 400, 2, 100);

            productoImportado.CalculaPrecio();
            productoImportado.MuestraVenta();

            productoDetenido.CalculaPrecio();
            productoDetenido.MuestraVenta();

            Console.ReadLine();
        }
    }
}
