using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_20MetodosAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Método anonimo un método que no tiene nombre
            CPunto punto = new CPunto(5, 4);
            punto.delMensaje += delegate ()
            {
                Console.WriteLine("Mostrando Delegado anonimo");
            };

            Console.WriteLine(punto);
            Console.WriteLine("----");
            //Invocamos
            punto.delMensaje();

            //Adicionamos otro
            punto.delMensaje += delegate ()
            {
                Console.WriteLine("Añadiendo otro delegado anonimo");
            };
            Console.WriteLine("----");
            punto.delMensaje();

            Console.WriteLine("-----");
            ProbandoDelegadosAnonimos();
            Console.ReadLine();
        }

        public static void ProbandoDelegadosAnonimos()
        {
            CPunto punto = new CPunto(4, 4);
            punto.delPrueba += delegate (string pMensaje)
             {
                 Console.WriteLine("!!Mostrando mensaje con parametro:{0}", pMensaje);
                 Console.WriteLine(punto);
             };
            punto.delPrueba("MSJ=por parmetro HOLA :)");

            Console.WriteLine("==");

            punto.delPrueba += delegate (string pNombre)
              {
                  Console.WriteLine("El nombre es:{0}",pNombre);
              };
            punto.delPrueba("LETYY");
        }
    }
}
