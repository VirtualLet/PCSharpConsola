using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_23ConversionExplicitaEntreClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversion custom de tipo
            CComplejo complejo = new CComplejo(3, 4);
            Console.WriteLine(complejo);

            //No se puede asignar el valor entero a la clase real
            // CReal real = complejo;

            //Lo que se pretende es que la clase complejo que tiene  3, 4i
            //se le asigne el valor entero de la clase complejo a la clase real
            //siendo real en este ejemplo el 3
            //Para hacer posible esto , se debe generar en la clase CComplejo
            //un método explicito para indicarle que dependiendo de la clase
            //que se quiera igualar,realice la operación para asignarle el
            //valor que se desea asignar
            CReal real =(CReal)complejo;
            Console.WriteLine(real);

            Console.ReadLine();
        }
    }
}
