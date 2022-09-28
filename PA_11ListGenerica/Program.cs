using System.Collections.Generic;
using System;
namespace PA_11ListGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> lNumeros = new List<int>();
            //lNumeros.Add(1);
            //lNumeros.Add(8);
            //lNumeros.Add(43);
            //lNumeros.Add(14);
            List<int> lNumeros = new List<int> { 1, 8, 43, 56, 7, 14, 3 };

            lNumeros.Add(44);
            lNumeros.Add(84);

            //Muestra valores otra manera de expresar foreach en lista con expresiones lambda
            lNumeros.ForEach(item => Console.WriteLine(item));
           

            Console.WriteLine("La lista contiene el numero 3? {0} \n", lNumeros.Contains(3));

            Console.WriteLine("El indice del elemento 8 es:{0} \n", lNumeros.IndexOf(8));

            Console.WriteLine("Insertando  en el indice 2 el valor 55");
            lNumeros.Insert(2, 55);
            MuestraValores(lNumeros);

            Console.WriteLine("Eliminar el valor del indice 3");
            lNumeros.RemoveAt(3);
            MuestraValores(lNumeros);

            Console.WriteLine("Eliminar el valor 1");
            lNumeros.Remove(1);
            MuestraValores(lNumeros);

            Console.WriteLine("Muestra la lista en sentido contrario");
            lNumeros.Reverse();
            MuestraValores(lNumeros);

            Console.WriteLine("Se ordena la lista");
            //La lista por si sola ya cuenta con el método sort pero en caso de querer
            //ordenar una clase se tendría que implementar IComparable para poder usar el método sort
            lNumeros.Sort();
            MuestraValores(lNumeros);
            Console.WriteLine("-------");
            Console.WriteLine("Mostrando Lista con los valores de un conjunto de clases");
            List<CPunto> lPunto = new List<CPunto>() 
                {   new CPunto(5,3),
                    new CPunto(7,8),
                    new CPunto(12,5),
                    new CPunto(6,2)
                };
            MuestraValoresClase(lPunto);

            Console.WriteLine("--Usando método sort en una clase ya implementado IComparable ");
            lPunto.Sort();
            MuestraValoresClase(lPunto);

            Console.WriteLine("--Mostrando reverse--");
            lPunto.Reverse();
            MuestraValoresClase(lPunto);

            Console.WriteLine("Adicionando otro elemento a la lista de clase");
            lPunto.Add(new CPunto(1, 2));
            MuestraValoresClase(lPunto);

            Console.WriteLine("Insertando otro elemento a la lista de clase");
            lPunto.Insert(2, new CPunto(100, 2));
            MuestraValoresClase(lPunto);

            Console.WriteLine("Convertir de Lista de clase a un arreglo normal");
            CPunto[] arregloPunto = lPunto.ToArray();
            for (int i = 0; i < arregloPunto.Length; i++)
            {
                Console.WriteLine(arregloPunto);
            }

            ConvirtiendoArryAList();

            ConvirtiendoListAArray();

            Console.ReadLine();
        }

        public static void ConvirtiendoArryAList()
        {
            Console.WriteLine("Conviertiendo arreglos a lista generica");
            int[] arregloPrueba = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            List<int> listPrueba = new List<int>(arregloPrueba);
            MuestraValores(listPrueba);

            Console.WriteLine("Otra forma de convertir arreglo a lista generica");
            List<int> listPruebaDos = new List<int>();
            listPruebaDos.AddRange(arregloPrueba);
            MuestraValores(listPruebaDos);

            Console.WriteLine("Convirtiendo arreglo de clase a una lista generica");
            CPunto[] arrayPuntos = new CPunto[]
            {       new CPunto(5,3),
                    new CPunto(7,8),
                    new CPunto(12,5),
                    new CPunto(6,2)
            };
            List<CPunto> listaPuntos = new List<CPunto>(arrayPuntos);
            MuestraValoresClase(listaPuntos);

            Console.WriteLine("Agregando un arreglo de clase a una lista generica");
            List<CPunto> listaPuntosDos = new List<CPunto>();
            listaPuntosDos.AddRange(arrayPuntos);
            MuestraValoresClase(listaPuntos);

        }

        public static void ConvirtiendoListAArray()
        {
            List<int> lNumeros = new List<int> { 1, 8, 43, 56, 7, 14, 3 };

            List<CPunto> lPunto = new List<CPunto>()
                {   new CPunto(30,3),
                    new CPunto(4,8),
                    new CPunto(10,5),
                    new CPunto(2,2)
                };

            Console.WriteLine("Convertir de Lista de clase a un arreglo normal");
            CPunto[] arregloPunto = lPunto.ToArray();
            for (int i = 0; i < arregloPunto.Length; i++)
            {
                Console.WriteLine("[{2}]=({0},{1})", arregloPunto[i].X, arregloPunto[i].Y, i);
            }

            Console.WriteLine("Convertir la lista de entero a un arreglo normal");
            int[] arregloNumero = lNumeros.ToArray();
            for (int i = 0; i < arregloNumero.Length; i++)
            {
                Console.WriteLine("[{0}]={1}", i, arregloNumero[i]);
            }

        }

        public static void MuestraValoresClase (List<CPunto> pListPunto)
        {
            foreach (CPunto item in pListPunto)
            {
                Console.WriteLine(item);
            }
        }

        public static void MuestraValores(List<int> lista)
        {

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i, lista[i]);
            }
        }
    }
}
