using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_21Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting
            /*Podemos hacer casting de una clase en la cadena de herencia
             * CProductoImportado es un CProducto
             * */
            CProducto producto = new CProductoImportado("Televisión", 2500, 0.15);
            producto.CalculaPrecio();
            Console.WriteLine(producto);

            /* CASO aplicando Type Cast
             * producto no puede invocar lo que no es común  producto.Mensaje();            
             para acceder al método de cProductoImportado se tiene  que realizar el casting            
            */
            ((CProductoImportado)producto).Mensaje();
            Console.WriteLine("------------");
            
            //CASO cuando CProducto es un Objeto

            Object productoObj= new CProducto("Radio", 2500);
            ((CProducto)productoObj).CalculaPrecio();
            Console.WriteLine((CProducto)productoObj);

            Console.WriteLine("------------");
            CProducto producto4 = new CProducto("Balon", 30.3);
            DetectaTipoDeClase(producto);
            Console.WriteLine("--");
            DetectaTipoDeClase(((CProducto)productoObj));
            Console.WriteLine("--");
            DetectaTipoDeClase(producto4);



            Console.ReadLine();

            
        }

        public static void DetectaTipoDeClase (CProducto pProducto)
        {
            if (pProducto is CProducto)
            {
                Console.WriteLine("Es  Producto");
                pProducto.CalculaPrecio();
                Console.WriteLine(pProducto);
            }
            if( pProducto is CProductoImportado)
            {
                Console.WriteLine("Es productoImportado");
                pProducto.CalculaPrecio();
                Console.WriteLine(pProducto);
                ((CProductoImportado)pProducto).Mensaje();
            }

            
        }
    }
}
