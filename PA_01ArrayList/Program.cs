using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_01ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList palabras = new ArrayList();
            int valor;
            //Podemos adicionar un arrango
            palabras.AddRange(new string[] { "uno", "dos", "tres", "cuatro" });
            Console.WriteLine("Número de elementos {0}",palabras.Count);            

            foreach(string item in palabras)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---Adicionando y recorriendo con for----");
            palabras.Add("cincoo");
            
            for( int i= 0; i< palabras.Count; i++)
            {
                Console.WriteLine(palabras[i]);
            }
          

            Console.WriteLine("----Array de enteros");
            ArrayList enteros = new ArrayList();
            enteros.AddRange(new int[] { 1, 2, 3, 4 });
          
            for(int i= 0; i< enteros.Count; i++)
            {
                valor =(int) enteros[i];
                Console.WriteLine(valor);
            }
            Console.WriteLine("-Verifica si existe el valor dentro del arreglo enteros--");
            Console.WriteLine("En array enteros contiene el numero 4? {0}", enteros.Contains(4));

            Console.WriteLine("---Inserción de valor en indice especificado");
            enteros.Insert(3, 54);
            MuestraInformacion(enteros);

            Console.WriteLine("---Remover elemento del valor indicado");
            enteros.Remove(54);
            MuestraInformacion(enteros);

            Console.WriteLine("---Remover el elemento del indice indicado");
            enteros.RemoveAt(1);
            MuestraInformacion(enteros);

            Console.ReadLine();

        }


        private static void MuestraInformacion(ArrayList arrayList )
        {           
            for (int i = 0; i < arrayList.Count; i++)
            {               
                Console.WriteLine("[{0}]={1}",i,arrayList[i]);
            }
            Console.WriteLine("---");
        }

    }
}
