using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_09Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();// LIFO El ultimo que entra es el primero que sale
            Console.WriteLine(" Adicionando objetos");
            stack.Push("Manzana");
            stack.Push("Pera");
            stack.Push("Uva");
            stack.Push("Melon");

            foreach (string item in stack)
            {
                Console.WriteLine("->{0}",item);
            }
            Console.WriteLine();
            //Sacamos elemento
            Console.WriteLine("Sacamos elemento {0}",stack.Pop());
            Console.WriteLine();
            foreach (string item in stack)
            {
                Console.WriteLine("->{0}", item);
            }

            //hacemos peek, solo lo muestra no lo saca 
            Console.WriteLine("Mostramos elemento {0}",stack.Peek());
            Console.WriteLine();
            foreach (string item in stack)
            {
                Console.WriteLine("->{0}", item);
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de elemntos en la coleccion existentes {0}",stack.Count);
            Console.ReadLine();
        }
    }
}
