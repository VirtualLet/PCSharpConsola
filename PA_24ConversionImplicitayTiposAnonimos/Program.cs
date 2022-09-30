using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_24ConversionImplicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Conversion Explicita");
            CComplejo complejo = new CComplejo(3, 4);
            CReal real = (CReal)complejo;
            Console.WriteLine("Conversion Explicita :{0}",real);

            Console.WriteLine("---Conversion Implicita---");
            CReal realUno = new CReal(4);
            CComplejo complejoUno = realUno;
            Console.WriteLine(complejoUno);

            Console.ReadLine();
        }
    }
}
