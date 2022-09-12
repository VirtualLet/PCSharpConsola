using System;
using System.Text;

namespace Pildoras_35ClasesAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Clases Anónimas=====");
            //StringBuilder cadena = new StringBuilder();
            //cadena.AppendFormat(".Solo pueden contener campos públicos \n" +
            //                           ".Todos los campos deben estar iniciados \n" +
            //                           ".Los campos no pueden ser static \n" +
            //                           ".No se pueden definir métodos \n");

            string cadena= string.Format(".Solo pueden contener campos públicos \n" +
                                       ".Todos los campos deben estar iniciados \n" +
                                       ".Los campos no pueden ser static \n" +
                                       ".No se pueden definir métodos \n");
        

            Console.WriteLine(cadena);
            var miVariable = new { Nombre = "Leticia", Edad = 20 };
            Console.WriteLine("Nombre={0},Edad={1}",miVariable.Nombre, miVariable.Edad);

            var miOtraVariable = new { Nombre = "Lia", Edad = 18 };

            miVariable = miOtraVariable;

           

            Console.WriteLine("Nombre={0},Edad={1}", miVariable.Nombre, miVariable.Edad);

            Console.WriteLine("===Arreglo de clases Anónimas=====");
            var variableArreglo = new[] {
               new{ Nombre = "Let", Edad = 20 },
               new{ Nombre="Rocio", Edad=35},
               new {Nombre ="Ramon",Edad=20},
               miVariable
            };

            foreach(var item in variableArreglo)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
