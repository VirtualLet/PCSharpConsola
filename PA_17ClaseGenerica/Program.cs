using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_17ClaseGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrando uso de clase Generica");
            CPunto<int> puntoInt = new CPunto<int>(3, 4);

            CPunto<double> puntoDouble = new CPunto<double>(33.7, 44.4);

            CPunto<float> puntoFloat = new CPunto<float>(4.55f, 6.6565f);

            Console.WriteLine(puntoInt);
            Console.WriteLine(puntoDouble);
            Console.WriteLine(puntoFloat);
            //Colocamos el valor de default
            puntoInt.Reset();
            Console.WriteLine(puntoInt);

            //Verificamos si esta trabajando con enteros
            puntoInt.EncuentraTipo();
            puntoDouble.EncuentraTipo();

            Console.ReadLine();
        }
    }
}
