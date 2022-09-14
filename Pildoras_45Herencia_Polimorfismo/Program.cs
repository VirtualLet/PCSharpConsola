using System;

namespace Pildoras_45Herencia_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herencia con polimorfismo!");
            
            CHumano humano = new CHumano("Laura");
            CGorila gorila = new CGorila("Tomy");
            CCaballo caballo = new CCaballo("Pinto");
            CMamifero mamifero = new CMamifero("Sin nombre");

            CMamifero[] arrayMamifero = new CMamifero[3];
            arrayMamifero[0] = gorila;
            arrayMamifero[1] = caballo;
            arrayMamifero[2] = humano;

            foreach( var item in arrayMamifero)
            {
                Console.WriteLine();
                Console.WriteLine(item.ToString());               
                item.GetNombre();
                item.Pensar();
            }
         


            Console.ReadLine();



        }
    }
}
