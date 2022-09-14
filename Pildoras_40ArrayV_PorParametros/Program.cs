using System;

namespace Pildoras_40ArrayV_PorParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array por párametros");

            int[] valores = LeerDatos();
            MuestraDatos(valores);

            Console.WriteLine("Muestra valores modificados sumandoles 10");
            ValoresModificados(valores);
            MuestraDatos(valores);

            Console.ReadLine();
        }

        static void ValoresModificados(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] += 10;
            }
        }
        static int[] LeerDatos()
        {
            int dato;
            int[] valores;
            Console.WriteLine("Cuantos elementos quieres en el array?");
            dato = int.Parse(Console.ReadLine());
            valores = new int[dato];
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Dame el valor del elemento [{0}]", i);
                valores[i] = int.Parse(Console.ReadLine());
            }
            return valores;
        }

        static void MuestraDatos(int[] valores)
        {
            Console.WriteLine("Muestra los valores");
            foreach (int item in valores)
            {
                Console.WriteLine(item);
            }
        }

    }
}
