using System;
using System.Collections.Generic;

namespace Pildoras_63ColeccionesList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colecciones List!");
            List<int> numeros = new List<int>();
            Console.WriteLine("Introduce elementos en la colección (0 para salir)");
            int elemento = 1;
            while (elemento != 0)
            {
                elemento = Int32.Parse(Console.ReadLine());
                numeros.Add(elemento);
            }

            Console.WriteLine("MuestraLista");
            numeros.Remove(0);
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            
            // EjemploUsandoLista()
            // AgregarArrayAunaLista();


            Console.ReadLine();
        }





        public static void EjemploUsandoLista()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Cuantos elementos tendra la lista?");
            int totalElementos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar los numeros de la lista");
            for (int i = 0; i < totalElementos; i++)
            {
                Console.Write("[{0}]=", i);
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Los elementos fueron");
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numeros[i]);
            }
        }

        public static void AgregarArrayAunaLista()
        {
            List<int> numeros = new List<int>();
            numeros.Add(4);
            numeros.Add(33);

            int[] listaNumeros = new int[] { 2, 3, 4, 5 };

            Console.WriteLine("Para agregar elementos de un array a una lista");
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
        }


        public void Informativo()
        {
          string info=  string.Format("Colecciones ¿Qué son?\n" +
                ".Son clases que pertenecen al namespace System.Collection.Generic \n" +
                ".Estas clases permiten almacenar elementos \n" +
                ".Son clases genéricas\n" +
                ".No tienen las limitaciones de los arrays (a cambio de mayor consumo de recursos).Permiten \n" +
                ".Ordenar, Añadir, Eliminar, Buscar, Etc.");
            Console.WriteLine(info);
        }
    }
}
