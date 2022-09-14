using System;

namespace Pildoras_44Herencia_PrincipioSustitucion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CHumano humano = new CHumano("Lety");
            CCaballo caballo = new CCaballo("Copito");
            CGorila gorila = new CGorila("Ramon");

            humano.GetNombre();
            humano.Pensar();
            humano.Respirar();

            //Usando principio de sustitución
            Console.WriteLine("---------------------");
            Console.WriteLine("Aplicando principio de sustitución (Es siempre un)");
            CMamifero animal = new CCaballo("Pinto");
            animal.GetNombre();
            //Otra forma de usar el principio de sustitución
            CMamifero mamifero = new CMamifero("La Luna");
            CCaballo caballo1 = new CCaballo("La clara");
            mamifero = caballo1;
            mamifero.GetNombre();
            //Tambien lo podemos expresar de esta otra manera
            //Pero de esta manera tendriamos que usar un casting porque no hay métodos comunes
            Object caballo2 = new CCaballo("Rani");
            ((CCaballo)caballo2).GetNombre();

            Console.WriteLine("---Usando el método de sustitución para almacenar las diferentes clases en un array");
            CMamifero[] arrayMamifero = new CMamifero[3];
            arrayMamifero[0] = humano;
            arrayMamifero[1] = caballo;
            arrayMamifero[2] = gorila;

            foreach (var item in arrayMamifero)
            {
                Console.WriteLine(item);
                item.GetNombre();
                item.CuidarCrias();
                item.Respirar();
            }
            for (int i = 0; i < arrayMamifero.Length; i++)
            {
                arrayMamifero[i].GetNombre();
            }

            Console.ReadLine();
        }
    }
}
