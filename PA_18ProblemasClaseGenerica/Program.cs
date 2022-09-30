using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_ProblemasClaseGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            //InconvenienteDeUsoEnClaseGenerica();
            InconvenienteDeUsoEnClaseGenericaModificado();
            Console.ReadLine();
        }
        public static void InconvenienteDeUsoEnClaseGenericaModificado()
        {

            Console.WriteLine("Clase generica a tener en cuenta cuando se usa genericos");
            COperacionModificado<int> iOperacion = new COperacionModificado<int>();           
            Console.WriteLine("{1} Resultado:{0}", iOperacion.Suma(3, 4),iOperacion);

            COperacionModificado<float> floatOperacion = new COperacionModificado<float>();
            Console.WriteLine("{1} Resultado:{0}", floatOperacion.Resta(8.5f, 4.5f), floatOperacion);

            COperacionModificado<string> sOperacion = new COperacionModificado<string>();
            Console.WriteLine("{1} Resultado:{0}", sOperacion.Suma("hola", "mundo")??sOperacion.Mensaje , sOperacion);

            //Como es generica y no hemos puesto restricciones la invocación al método
            // multiplicar siendo de tipo string los parametros hara que el programa falle
            Console.WriteLine("{1} Resultado:{0}", sOperacion.Multiplicacion("hola", "mundo")??sOperacion.Mensaje, sOperacion);
        }

        public static void InconvenienteDeUsoEnClaseGenerica()
        {

            Console.WriteLine("Mostrando algunas situaciones donde una clase generica puede tener inconvenientes");
            COperacion<int> iOperacion = new COperacion<int>();
            Console.WriteLine("Resultado:{0}", iOperacion.Suma(3, 4));


            COperacion<float> fOperacion = new COperacion<float>();
            Console.WriteLine("Resultado:{0}", fOperacion.Resta(8.5f, 4.5f));

            COperacion<string> sOperacion = new COperacion<string>();
            Console.WriteLine("Resultado:{0}", sOperacion.Suma("hola", "mundo"));

            //Como es generica y no hemos puesto restricciones la invocación al método
            // multiplicar siendo de tipo string los parametros hara que el programa falle
            Console.WriteLine("Resultado:{0}", sOperacion.Multiplicacion("hola", "mundo") );
        }
    }
}
