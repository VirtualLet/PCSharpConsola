using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_07Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue miQ = new Queue();// FIFO primero en entrar , primero en salir (Cola)
            Console.WriteLine(" Adicionando objetos");
            miQ.Enqueue("Manzana");
            miQ.Enqueue("Pera");
            miQ.Enqueue("Uva");
            miQ.Enqueue("Melon");

            foreach( string item in miQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("--Se obtienen objetos--");
            Console.WriteLine("Dequeue {0}",miQ.Dequeue());
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());
            Console.WriteLine("----");
            foreach (string item in miQ)
            {
                Console.WriteLine("Despues de Dequeue ->{0}", item);
            }

            Console.WriteLine();
            Console.WriteLine("---Se agregan más elementos");
            miQ.Enqueue("DURAZNO");
            miQ.Enqueue("FRESA");

            foreach (string item in miQ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Se observa el objeto usando Peek {0}",miQ.Peek());


            foreach (string item in miQ)
            {
                Console.WriteLine("Despues de Peek ->{0}", item);
            }
            Console.WriteLine();
            Console.WriteLine("conteo de objetos: {0}",miQ.Count);
            Console.WriteLine("Verificando si existe el elemento FRESA {0}",miQ.Contains("FRESA"));



            Console.ReadLine();

        }
    }
}
