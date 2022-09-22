using System;
using System.Collections.Generic;

namespace Pildoras_66ColeccionesStack_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // EjemploColeccionStack();
            EjemploColeccionDiccionario();
            Console.ReadLine();
        }

        public static void EjemploColeccionStack()
        {
            Console.WriteLine("Coleccion Stack Lifo Last In First Out!");
            Stack<int> numeros = new Stack<int>();
            //Agregando elementosS
            foreach (int item in new int[] { 2, 3, 5, 6 })
            {
                numeros.Push(item);
            }
            Console.WriteLine("recorriendo la stack");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Eliminando elemento");
            numeros.Pop();
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
        }

        public static void EjemploColeccionDiccionario()
        {
            Dictionary<String, int> dicionario = new Dictionary<string, int>();
            dicionario.Add("uno", 1);
            dicionario.Add("dos", 2);
            dicionario.Add("tres", 3);
            //Otra forma de agregar valores a la coleccion de un diccionario
            dicionario["cuatro"] = 4;
            dicionario["cinco"] = 5;
            foreach(KeyValuePair<string,int> item in dicionario)
            {
                Console.WriteLine("[{0}][{1}]",item.Key,item.Value);
            }



            Console.ReadLine();
        }
    }
}
