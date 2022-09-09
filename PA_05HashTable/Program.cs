using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_05HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable miTabla = new Hashtable();
            miTabla.Add(2, "dos");
            miTabla.Add(1, "uno");
            miTabla.Add(5, "cinco");
            miTabla.Add(23, "veintitres");
            miTabla.Add(3, "tres");

            foreach(DictionaryEntry item in miTabla)
            {
                Console.WriteLine("key[{0}],valor{1}",item.Key,item.Value);
            }

            Console.WriteLine("---");
            Console.WriteLine("Cantidad de elementos existentes: {0}",miTabla.Count);

            Console.WriteLine("---Obtiene el elemento en determinada llave");
            Console.WriteLine("el valor en la llave[{0}] es:{1}",2,miTabla[2]);

            Console.WriteLine("Colocar nuevo valor en una llave indicada ");
            miTabla[23] = "Nuevo valor en llave 23";


            foreach (DictionaryEntry item in miTabla)
            {
                Console.WriteLine("key[{0}],valor{1}", item.Key, item.Value);
            }

            Console.WriteLine("---");
            Console.WriteLine("Verifica si existe la llave 3 {0}",miTabla.Contains(3));
            Console.WriteLine("---Se elimina el elemento 23");
            miTabla.Remove(23);

            foreach (DictionaryEntry item in miTabla)
            {
                Console.WriteLine("key[{0}][{1}]", item.Key, item.Value);
            }

            Console.WriteLine("---Ver el valor de las llaves");
            foreach(int llave in miTabla.Keys)
            {
                Console.WriteLine(llave);
            }
            Console.WriteLine("---Ver el valor de todos los valores de la colección hasthtable");
            foreach(string valor in miTabla.Values)
            {
                Console.WriteLine(valor);
            }
            Console.ReadLine();
        }
    }
}
