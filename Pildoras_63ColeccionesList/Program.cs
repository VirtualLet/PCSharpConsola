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

        public static void FormaAgregaElementosAListaUno()
        {
            List<CPersona> listPersona = new List<CPersona> {
                    new CPersona { Nombre = "Leticia", Edad = 37 },
                    new CPersona { Nombre = "Lucia", Edad = 7 },
                    new CPersona { Nombre = "Lia", Edad = 30 },
                    new CPersona { Nombre = "Laura", Edad = 17 }};

            foreach (CPersona item in listPersona)
            {
                Console.WriteLine("{0} {1} ", item.Nombre, item.Edad);
            }

        }

        public static void FormaAgregaElementosAListaDos()
        {
            List<CPersona> listPersona = new List<CPersona>();
            listPersona.AddRange(new CPersona[]{ new CPersona { Nombre = "Tomas", Edad = 20 },
                                                 new CPersona { Nombre = "Pedro", Edad = 40 } });
            foreach (CPersona item in listPersona)
            {
                Console.WriteLine("{0} {1} ", item.Nombre, item.Edad);
            }
        }

        public static void FormaAgregaElementosAListaTres()
        {
            List<CPersona> listPersona = new List<CPersona>();
            CPersona persona1 = new CPersona();
            persona1.Nombre = "Tylor";
            persona1.Edad = 32;
            CPersona persona2 = new CPersona();
            persona2.Nombre = "Oscar";
            persona2.Edad = 22;

            listPersona.AddRange(new CPersona[] { persona1, persona2 });

            foreach (CPersona item in listPersona)
            {
                Console.WriteLine("{0} {1} ", item.Nombre, item.Edad);
            }
        }
        public static void DiversasFormasDeAgregarElementosALista()
        {
            Console.WriteLine("\nMostrando Predicado usando Clases \n");
            List<CPersona> listPersona = new List<CPersona> {
                    new CPersona { Nombre = "Leticia", Edad = 37 },
                    new CPersona { Nombre = "Lucia", Edad = 7 },
                    new CPersona { Nombre = "Lia", Edad = 30 },
                    new CPersona { Nombre = "Laura", Edad = 17 }};

            listPersona.AddRange(new CPersona[]{ new CPersona { Nombre = "Tomas", Edad = 20 },
                                                 new CPersona { Nombre = "Pedro", Edad = 40 } });
            CPersona persona1 = new CPersona();
            persona1.Nombre = "Tylor";
            persona1.Edad = 32;
            CPersona persona2 = new CPersona { Nombre = "Marcus", Edad = 20 };

            listPersona.AddRange(new CPersona[] { persona1, persona2 });

            foreach (CPersona item in listPersona)
            {
                Console.WriteLine("{0} {1} ", item.Nombre, item.Edad);
            }
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
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(4);
            listaNumeros.Add(33);

            int[] arrayNumeros = new int[] { 2, 3, 4, 5 };

            Console.WriteLine("Para agregar elementos de un array a una lista");
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                listaNumeros.Add(arrayNumeros[i]);
            }

            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }
        }

        public static void AgregarArrayAunaListaOtraForma()
        {
            int[] arrayNumeros = new int[] { 2, 3, 4, 5 };
            List<int> listaNumeros = new() { 4, 33 };   

            Console.WriteLine("Para agregar elementos de un array a una lista");
            listaNumeros.AddRange(arrayNumeros);

            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }
        }

        public static void AgregarArrayAunaListaOtraFormaDos()
        {
            int[] arrayNumeros = new int[] { 2, 3, 4, 5 };
            Console.WriteLine("Para agregar elementos de un array a una lista");
            List<int> listaNumeros = new List<int>(arrayNumeros);
            listaNumeros.AddRange(new int[] { 4, 33 }); //por si quisiera agregar mas elementos 

            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }
        }

        public static void AgregarArrayAunaListaOtraFormaTres()
        {
            Console.WriteLine("Para agregar elementos de un array a una lista");
            List<int> listaNumeros = new List<int>(new int[] { 2, 3, 4, 5 }); //lo incluyo directamente
            listaNumeros.AddRange(new int[] { 4, 33 }); //por si quisiera agregar mas elementos 

            foreach (int item in listaNumeros)
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
