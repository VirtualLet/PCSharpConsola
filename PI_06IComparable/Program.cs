using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_06IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            CRectangulo[] rectangulo = new CRectangulo[5];
            rectangulo[0] = new CRectangulo(2, 1);
            rectangulo[1] = new CRectangulo(4, 5);
            rectangulo[2] = new CRectangulo(5, 7);
            rectangulo[3] = new CRectangulo(1, 5);
            rectangulo[4] = new CRectangulo(2, 4);

            foreach(CRectangulo item in rectangulo)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-----Muestra arreglo ordenado asc--------");

            Array.Sort(rectangulo);//Una vez implementado el metodo IComparable ya se puede usar el Método Sort

            foreach (CRectangulo item in rectangulo)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-----Muesta arreglo ordenado desc----------");

            for ( int i=rectangulo.Length-1; i>=0; i--)
            {
                Console.WriteLine(rectangulo[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
