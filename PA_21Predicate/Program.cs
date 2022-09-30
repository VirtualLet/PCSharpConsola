using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_21Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumeros = new List<int>();
            listNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6,7 });

            Predicate<int> delPredicate = new Predicate<int>(Pares);
            List<int> listPares = new List<int>();
            listPares= listNumeros.FindAll(delPredicate);

            foreach(int item in listPares)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-Numeros Pares--");
            listPares.ForEach(item => Console.WriteLine(item));

           
            delPredicate = new Predicate<int>(Rango);
            List<int> listRango = new List<int>();
            listRango= listNumeros.FindAll(delPredicate);

            Console.WriteLine("-Muestra valores de Rango");
            listRango.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("ListaOriginal");
            listNumeros.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("--HAciendo uso de RemoveAll");           
            Console.WriteLine("Total eliminados {0}",listNumeros.RemoveAll(delPredicate));
            listNumeros.ForEach(item => Console.WriteLine(item));

            Console.ReadLine();

        }

        public static bool Pares(int numero)
        {
            if (numero % 2 == 0) return true;
            else return false;
        }

        public static bool Rango(int numero)
        {
            if (numero > 5 && numero < 10)
                return true;
            else
                return false;
        }

        public static void Informativo()
        {
            string info = string.Format("Ejemplo con delegados" +
                "System.Predicate<T> es un delegado generico que representa un método que" +
                "va a definir un criterio y dice si el objetivo cumple o no con ese criterio" +
                "public List<T> FindAll(Predicate<T> match). Recorre los elementos de la lista y" +
                "los pasa con parametros al delegado, si este regresa true los pone en la lista de retorno");

        }

    }
}
