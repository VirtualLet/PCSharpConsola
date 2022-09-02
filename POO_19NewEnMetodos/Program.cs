using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_19NewEnMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CProducto producto = new CProducto("Bicicleta", 2000, 3000);

            producto.CalculaPrecio();
            producto.MuestraVenta();

            Console.WriteLine("---------"); ;

            CProductoImportado productoImportado = new CProductoImportado("Bici", 2000, 3000, 2);
            productoImportado.CalculaPrecio();
            productoImportado.MuestraVenta();

            Console.WriteLine("---------"); ;
            CProducto productoPolimorfico=new  CProductoImportado("Bici", 2000, 3000, 2);
            productoPolimorfico.CalculaPrecio();
            productoPolimorfico.MuestraVenta();

            Console.ReadLine();
        }
    }
}
