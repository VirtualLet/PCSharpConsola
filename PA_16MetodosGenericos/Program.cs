using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_16MetodosGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Probando con enteros");
            int x = 5;
            int y = 3;

            Console.WriteLine("x={0}, y={1}",x,y);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("x={0}, y={1}", x, y);

            Console.WriteLine("---Probando con doubles");
            double dx = 10.5;
            double dy = 20.4;

            Console.WriteLine("x={0}, y={1}", dx, dy);
            Intercambio<double>(ref dx, ref dy);
            Console.WriteLine("x={0}, y={1}", dx, dy);

            Console.WriteLine("---Probando con strings");
            string cadenaA = "Hola";
            string cadenaB = "Adios";

            Console.WriteLine("x={0}, y={1}", cadenaA, cadenaB);
            Intercambio<string>(ref cadenaA, ref cadenaB);
            Console.WriteLine("x={0}, y={1}", cadenaA,cadenaB);
            Console.ReadLine();
        }
        static void Intercambio<T>(ref T elementoA , ref T elementoB)
        {
            T valorTemporal;
            valorTemporal = elementoA;
            elementoA = elementoB;
            elementoB = valorTemporal;
        }
    }
}
