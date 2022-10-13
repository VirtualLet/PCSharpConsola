using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_29ImplementacionExplicitaInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {

            CCuadrado cuadrado = new CCuadrado(5);
            ((IPerimetro)cuadrado).Calcular();
            ((IArea)cuadrado).Calcular();
            Console.ReadLine();
        }
    }
}
