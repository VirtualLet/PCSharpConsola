using System;

namespace Pildoras_36Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array: Estructura de datos que contiene una colección de valores del mismo tipo");

            int[] enteros; //declaración
            enteros = new int[3]; //inicialización
            enteros[0] = 1;
            enteros[1] = 2;
            enteros[2] = 3;

            MuestraValoresArray(enteros);
            Console.WriteLine("-------");

            string[] palabras = new string[4];
            palabras[0] = "Edith";
            palabras[1] = "Pedro";
            palabras[2] = "Erick";
            palabras[3] = "Manuel";

            MuestraValoresArray(palabras);
            Console.WriteLine("-------");

            string[] frutas = { "Pera", "Manzana", "Melon", "Platano" };

            MuestraValoresArray(frutas);
            Console.WriteLine("-------");

            int[] saldo = new int[4] { 100, 200, 300, 400 };

            for (int i = 0; i < saldo.Length; i++)
            {
                Console.WriteLine("[{0}]{1}", i, saldo[i]);
            }

            Console.WriteLine("valor de saldo en posición {0} = {1}", 3, saldo[3]);


            Console.ReadLine();

        }


      

        public static void ArrayEstructuraSimpleVersionLarga()
        {
            int[] enteros; //declaración
            enteros = new int[3]; //inicialización
            enteros[0] = 1;
            enteros[1] = 2;
            enteros[2] = 3;


            foreach (int item in enteros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------");

            string[] palabras = new string[4];
            palabras[0] = "Edith";
            palabras[1] = "Pedro";
            palabras[2] = "Erick";
            palabras[3] = "Manuel";

            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
            }

            Console.WriteLine("-------");

            string[] frutas = { "Pera", "Manzana", "Melon", "Platano" };


            foreach (string item in frutas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------");

            int[] saldo = new int[4] { 100, 200, 300, 400 };

            for (int i = 0; i < saldo.Length; i++)
            {
                Console.WriteLine("[{0}]{1}", i, saldo[i]);
            }

            Console.WriteLine("valor de saldo en posición {0} = {1}", 3, saldo[3]);
        }
        public static void MuestraValoresArray( Array valores)
        {
            foreach (var item in valores)
            {
                Console.WriteLine(item);
            }
        }

    }
}
