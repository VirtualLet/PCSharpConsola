using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_22ExpresionesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExpresionLambdaEjemUno();
            Console.WriteLine("----");
            ExpresionLambdaEjemDos();
            Console.ReadLine();
        }
        public static void Informativo()
        {
            string.Format("Las expresiones lambda" +
                "Se pueden usar donde se haga uso de un método anonimo " +
                "o un delegado fuertemente tipificado" +
                "sintaxis:" +
                "lista de parametros=> instrucciones a realizar" +
                "El tipo de los parametros puede ser implicito o explicito (int i)");
            
        }

        public static void ExpresionLambdaEjemUno()
        {
            List<int> listNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Hacemos uso de la expresion lambda
            List<int> listPares = listNumeros.FindAll(item => (item % 2) == 0);
            listPares.ForEach(item => Console.WriteLine(item));
        }

        public static void ExpresionLambdaEjemDos()
        {
            List<int> listNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> listPares = listNumeros.FindAll((item) =>
             {
                 if (item % 2 == 0)
                 {
                     Console.WriteLine("Par");
                     return true;
                 }
                 else
                 {
                     Console.WriteLine("Impar");
                     return false;
                 }
             });

            Console.WriteLine("\n-----Muestra numeros pares");
            listPares.ForEach(item => Console.WriteLine(item));
        }
    }
}
