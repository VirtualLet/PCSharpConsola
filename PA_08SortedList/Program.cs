using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_08SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sLista = new SortedList();
            sLista.Add(34, "luna");
            sLista.Add(2, "tierra");
            sLista.Add(40, "estrellas");
            sLista.Add(3, "sol");

            foreach(DictionaryEntry item in sLista)
            {
                Console.WriteLine("[{0}]{1}",item.Key,item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de elementos {0}",sLista.Count);
            Console.WriteLine("Contiene la llave 2? {0}",sLista.Contains(2));
            Console.WriteLine("Contiene la llave 40 ?{0}",sLista.ContainsKey(40));
            Console.WriteLine("Contiene el elemento tierra? {0}",sLista.ContainsValue("cielo"));
            Console.WriteLine("----");
            //En este caso no es muy fiable usar la busqueda por indices ya que la lista SortedList
            //Va ordenando los elementos al momento de incluirlos lo que puede hacer que los indices cambien
            Console.WriteLine("Obtener la llave en el indice indicado {0}",sLista.GetKey(2));
            Console.WriteLine("Obtiene le valor en el indice indicado {0}",sLista.GetByIndex(2));

            Console.ReadLine();
        }
    }
}
