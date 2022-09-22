using System;
using System.Collections.Generic;

namespace Pildoras_65ColeccionesQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando colecciones Queue! FIFO:Primero en entrar primero en salir");
            Queue<int> numeros = new Queue<int>();
            //Agregando elementosS
            foreach(int item in new int[] {2,3,5,6})
            {
                numeros.Enqueue(item);
            }
            
            Console.WriteLine("recorriendo la queue");
            foreach(int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Eliminando elemento");
            numeros.Dequeue();
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
