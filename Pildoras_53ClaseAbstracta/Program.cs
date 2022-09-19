using System;

namespace Pildoras_53ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando funcionamiento de clase abstracta");
            CLagartija lagartija = new CLagartija("Juancho");
            lagartija.Respirar();
            lagartija.GetNombre();
            CHumano humano = new CHumano("Tomas");
            humano.GetNombre();
            humano.Respirar();
            Console.WriteLine("---------");
            CMamifero mamifero = new CMamifero("Mamiferooo");
            mamifero.GetNombre();
            mamifero.Pensar();
            mamifero = new CHumano("Ramon");
            mamifero.GetNombre();
            mamifero.Pensar();

            Console.ReadLine();
        }
    }
}
