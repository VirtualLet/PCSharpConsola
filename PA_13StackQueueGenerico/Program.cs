using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_13StackQueueGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            STACK();
            Console.WriteLine("\n---");
            QUEUE();
            Console.ReadLine();
        }

        public static void QUEUE()
        {
            Console.WriteLine("Haciendo QUEUE");
            //FIFO-Primero en entrar primero en salir -Cola
            Queue<CPunto> puntos = new Queue<CPunto>();
            puntos.Enqueue(new CPunto(33, 47));
            puntos.Enqueue(new CPunto(54, 76));
            puntos.Enqueue(new CPunto(95, 11));
            puntos.Enqueue(new CPunto(12, 64));

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);

            Console.WriteLine("----");
            //Hacemos un peek para mostrarlo sin sacarlo
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);

            Console.WriteLine("-----");
            //Hacemos un pop
            Console.WriteLine("Dequeue {0}", puntos.Dequeue());
            Console.WriteLine("Dequeue {0}", puntos.Dequeue());

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);

            Console.WriteLine("----");
            //Hacemos un peek para mostrarlo sin sacarlo
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);
        }
        public static void STACK()
        {
            Console.WriteLine("Haciendo STACK");
            //LIFO-Ultimo en entrar primro en salir Pila
            Stack<CPunto> puntos = new Stack<CPunto>();
            puntos.Push(new CPunto(3, 4));
            puntos.Push(new CPunto(5, 7));
            puntos.Push(new CPunto(9, 11));
            puntos.Push(new CPunto(1, 4));

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);

            Console.WriteLine("----");
            //Hacemos un peek para mostrarlo sin sacarlo
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);

            Console.WriteLine("-----");
            //Hacemos un pop
            Console.WriteLine("Pop {0}", puntos.Pop());
            Console.WriteLine("Pop {0}", puntos.Pop());

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);

            Console.WriteLine("----");
            //Hacemos un peek para mostrarlo sin sacarlo
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (CPunto item in puntos)
                Console.WriteLine("->{0}", item);
        }
    }
}
