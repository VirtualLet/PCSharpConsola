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
            List<int> lNumeros = new List<int>
            {
                1,8,43,56,7,14,3
            };

            lNumeros.Add(44);
            lNumeros.Add(84);
            MuestraValores(lNumeros);

            Console.WriteLine("La lista contiene el numero 3? {0} \n",lNumeros.Contains(3));

            Console.WriteLine("El indice del elemento 8 es:{0} \n",lNumeros.IndexOf(8));

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

            Console.ReadLine();
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
